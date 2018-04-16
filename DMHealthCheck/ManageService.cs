using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DMHealthCheck
{
    public class ManageService
    {

        //private static WebService ExampleAPI = new WebService("https://dm501ds.dmhostedservice.com/DM_DS/DecisionStrategy.asmx");    // DEFAULT location of the WebService, containing the WebMethods

        //public static void ChangeUrl(string webserviceEndpoint)
        //{
        //    ExampleAPI = new WebService(webserviceEndpoint);
        //}

        //public static string ExampleWebMethod(string name)
        //{
        //    ExampleAPI.PreInvoke();

        //    //ExampleAPI.AddParameter("CountryName", name);                    // Case Sensitive! To avoid typos, just copy the WebMethod's signature and paste it
           
        //    try
        //    {
        //        ExampleAPI.Invoke("http://www.decisionmetrics.co.uk/xsd/ServiceRequest");                // name of the WebMethod to call (Case Sentitive again!)
        //    }
        //    finally { ExampleAPI.PosInvoke(); }

        //    return ExampleAPI.ResultString;                           // you can either return a string or an XML, your choice
        //}

        public static void Invoke()
        {
            var _url = "https://dm501ds.dmhostedservice.com/DM_DS/DecisionStrategy.asmx";
            //var _action = "https://dm501ds.dmhostedservice.com/DM_DS/DecisionStrategy.asmx?op=ServiceRequest";

            //var _url = "http://www.webservicex.net/globalweather.asmx";
            var _action = "http://www.webservicex.net/globalweather.asmx?op=GetCitiesByCountry";

            XmlDocument soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url, _action);
            webRequest.Credentials = CredentialCache.DefaultCredentials;
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }


        private static HttpWebRequest CreateWebRequest(string url, string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
    
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelop = new XmlDocument();

            //soapEnvelop.Load(@"Resources\Template.xml");
            soapEnvelop.Load(@"Resources\XMLFile1.xml");
           
            return soapEnvelop;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
    }
}
