using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DMHealthCheck
{
    public partial class Form1 : Form
    {
        //public string XMLRequest = string.Empty;
        public string ApplicationNo = string.Empty;
        public Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOverallDecision.ForeColor = Color.DarkMagenta;
            SetDataToGetDecision("accept");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmendDefaultData.Checked)
                EnableControls(true);
            else
                EnableControls(false);
        }

        private void EnableControls(bool enable)
        {
            cmbTitle.Enabled = enable;
            txtFirstName.Enabled = enable;
            txtLastName.Enabled = enable;
            dtpDOB.Enabled = enable;
            txtFlatNo.Enabled = enable;
            txtHouseNo.Enabled = enable;
            txtHouseName.Enabled = enable;
            txtStreet.Enabled = enable;
            txtTown.Enabled = enable;
            txtPostCode.Enabled = enable;
            txtSortCode.Enabled = enable;
            txtAcctNo.Enabled = enable;
            chkEnfBankChk.Enabled = enable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;

                Cursor.Current = Cursors.WaitCursor;

                bool enforceBnkChk = chkEnfBankChk.CheckState == CheckState.Checked;

                if (enforceBnkChk
                    && (string.IsNullOrEmpty(txtAcctNo.Text) | string.IsNullOrEmpty(txtSortCode.Text)))
                {
                    MessageBox.Show("To enforce bank check bank details are mandatory", "Required Bank Details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    button1.Enabled = true;
                    return;
                }

                //ManageService.ExampleWebMethod("http://www.decisionmetrics.co.uk/xsd/ServiceRequest");

                bool isIDCheckSuccess = false;
                bool is3DCheckSuccess = false;
                bool isBankCheckSuccess = !chkEnfBankChk.Checked ? true : false;
                bool isSIRACheckSuccess = false;
                string strReq = string.Empty;
                string strRes = string.Empty;
                //strRes = File.ReadAllText(@"..\..\Resources\XMLFile1.xml");
                isIDCheckSuccess = ValidateXMLResponse(RequestState.IDCheck);

                if (isIDCheckSuccess)
                {
                    if (enforceBnkChk)
                    {
                        isBankCheckSuccess = ValidateXMLResponse(RequestState.BankCheck);
                    }
                    else
                    {
                        is3DCheckSuccess = ValidateXMLResponse(RequestState.ThreeDCheck);
                        lblBankCheckStatus.Text = "Not Applicable";
                    }
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
            button2.Enabled = true;
        }

        private bool ValidateXMLResponse(RequestState req)
        {
            bool isSuccess = false;

            string AppStatusResult = string.Empty;            

            #region IDCheck
            if (req == RequestState.IDCheck)
            {
                try
                {
                    lblIDCheckStatus.Text = "ID Check in progress....";
                    string strReq = GetRequestXMLAsString(RequestState.IDCheck, string.Empty);
                    string strRes = WebService.InvokeWebService(RequestState.IDCheck, strReq);

                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.LoadXml(strRes);
                    XmlNodeList nodeList = xmldoc.GetElementsByTagName("CV");
                    XmlNodeList applnNodeList = xmldoc.GetElementsByTagName("application_id");

                    ApplicationNo = applnNodeList[0].InnerText;

                    if (nodeList.Count > 0)
                    {
                        string node = nodeList.Cast<XmlNode>()
                                   .Where(n => n.Attributes["c"].InnerText == "GC_D_App_Status")
                                   .Select(x => x.Attributes["v"].InnerText).FirstOrDefault();

                        if (node != string.Empty)
                        {
                            lblApplicationNo.Text = ApplicationNo;

                            if (node == "REQ3D")
                            {
                                isSuccess = true;
                                lblIDCheckStatus.Text = "Success";
                            }
                            else
                            {
                                lblIDCheckStatus.Text = "Failed";
                                lblIDCheckStatus.ForeColor = Color.Red;
                                lblApplicationNo.ForeColor = Color.Red;
                            }
                            lblIDCheckStatus.Refresh();
                        }
                    }
                }
                catch (Exception e)
                {
                    lblIDCheckStatus.Text = "Error invoking DM Service";
                    lblIDCheckStatus.ForeColor = Color.Red;
                }
            }
            #endregion

            #region Other Checks
            else
            {
                try
                {
                    if (chkEnfBankChk.Checked)
                    {
                        lblBankCheckStatus.Text = "Bank Check in progress....";
                    }

                    string strReq = GetRequestXMLAsString(req, ApplicationNo);
                    string strRes = WebService.InvokeWebService(req, strReq);

                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.LoadXml(strRes);
                    XmlNodeList nodeList = xmldoc.GetElementsByTagName("CV");
                    XmlNodeList applnNodeList = xmldoc.GetElementsByTagName("application_id");

                    ApplicationNo = applnNodeList[0].InnerText;

                    if (nodeList.Count > 0)
                    {
                        string status = nodeList.Cast<XmlNode>()
                                   .Where(n => n.Attributes["c"].InnerText == "GC_D_App_Status")
                                   .Select(x => x.Attributes["v"].InnerText).FirstOrDefault();

                        string decision = nodeList.Cast<XmlNode>()
                                   .Where(n => n.Attributes["c"].InnerText == "GC_D_Decision")
                                   .Select(x => x.Attributes["v"].InnerText).FirstOrDefault();

                        if (status != string.Empty)
                        {
                            lblApplicationNo.Text = ApplicationNo;

                            if (status == "COMPLETE")
                            {
                                if (decision == "ACCEPT")
                                {
                                    isSuccess = true;
                                    lblBankCheckStatus.Text = "Success";
                                    lblSIRACheckStatus.Text = "Success";
                                    lblOverallDecision.Text = "ACCEPT";
                                }
                                else if (decision == "DECLINE")
                                {
                                    isSuccess = false;

                                    if (chkEnfBankChk.Checked)
                                    {
                                        lblBankCheckStatus.Text = "Failed";
                                        lblBankCheckStatus.ForeColor = Color.Red;
                                        lblOverallDecision.Text = "DECLINE";
                                    }
                                }
                            }
                            else if (status == "PENDING")
                            {
                                string dbReturnCode = nodeList.Cast<XmlNode>()
                                   .Where(n => n.Attributes["c"].InnerText == "DB_Return_Code")
                                   .Select(x => x.Attributes["v"].InnerText).FirstOrDefault();
                                
                                if (!dbReturnCode.Equals("100"))
                                {
                                    XmlNodeList errorTextNode = xmldoc.GetElementsByTagName("DB_Error_Text");
                                    string dbErrorText = errorTextNode[0].InnerText;

                                    if (!string.IsNullOrEmpty(dbErrorText))
                                    {
                                        lblErrMsg.Visible = true;
                                        lblErrMsgText.Visible = true;
                                        lblErrMsgText.Text = dbErrorText;
                                    }

                                    lblSIRACheckStatus.Text = "Failed";
                                    lblSIRACheckStatus.ForeColor = Color.Red;
                                    lblApplicationNo.ForeColor = Color.Red;
                                    lblOverallDecision.Text = "PENDING";
                                    lblOverallDecision.ForeColor = Color.DarkOrange;
                                }                                
                            }
                            else if (status == "ERROR")
                            {
                                XmlNodeList errorTextNode = xmldoc.GetElementsByTagName("DB_Error_Text");
                                string dbErrorText = errorTextNode[0].InnerText;

                                if (!string.IsNullOrEmpty(dbErrorText))
                                {
                                    lblErrMsg.Visible = true;
                                    lblErrMsgText.Visible = true;
                                    lblErrMsgText.Text = dbErrorText;
                                }

                                lblBankCheckStatus.Text = "Failed";
                                lblBankCheckStatus.ForeColor = Color.Red;
                                lblApplicationNo.ForeColor = Color.Red;
                                lblOverallDecision.Text = "PENDING";
                                lblOverallDecision.ForeColor = Color.DarkOrange;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (lblBankCheckStatus.Text == "Bank Check in progress....")
                    {
                        lblBankCheckStatus.Text = "Error invoking DM Service";
                    }
                }
            }
            #endregion   
           
            return isSuccess;
        }

        private string GetRequestXMLAsString(RequestState req, string AppID)
        {
            string request = string.Empty;
            ds_request theRequest = null;

            string head = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsd=""http://www.decisionmetrics.co.uk/xsd"">
   <soapenv:Header/>
   <soapenv:Body>
      <xsd:ServiceRequest>
         <xsd:name>ATOMUATAPI</xsd:name>
         <xsd:password>atomuatpwd</xsd:password>
         <xsd:service>Atom_Savings</xsd:service>
         <xsd:processflow_id>55750</xsd:processflow_id>
         <!--Optional:-->
         <xsd:payload><![CDATA[";
            string tail = @"]]></xsd:payload>
      </xsd:ServiceRequest>
   </soapenv:Body>
</soapenv:Envelope>";

            theRequest = BuildRequestObject();

            if (req != RequestState.IDCheck && !string.IsNullOrEmpty(AppID))
            {
                theRequest.control.request_type = "UPDATE";
                theRequest.control.application_id = AppID;
            }

            var serializer = new XmlSerializer(typeof(ds_request));  
            using (StringWriter textWriter = new StringWriter())
            {
                serializer.Serialize(textWriter, theRequest);
                request = head + textWriter.ToString() + tail;
            }

            return request;
        }


        private ds_request BuildRequestObject()
        {
            ds_request theRequest = new ds_request();
                        
            additionalclient addlClient = new additionalclient();

            applicant1 appl1 = new applicant1();
            name applicantName = new name();
            
            applicantName.title = cmbTitle.Text;
            applicantName.forename = txtFirstName.Text;
            applicantName.surname = txtLastName.Text;
            applicantName.dob = Convert.ToDateTime(dtpDOB.Text).ToString("yyyy-MM-dd");

            appl1.name = applicantName;
            appl1.current_address = new current_address();
            appl1.contact_telephone_1 = new contact_telephone_1();
            appl1.contact_email_1 = new contact_email_1();

            addresses addrs = new addresses();
            Address1 addr1 = new Address1();
                       
            UKAddress ukaddr = new UKAddress();

            ukaddr.abodeno = txtFlatNo.Text;
            ukaddr.house_name = txtHouseName.Text;
            ukaddr.house_number = txtHouseNo.Text;
            ukaddr.street1 = txtStreet.Text;
            ukaddr.posttown = txtTown.Text;
            ukaddr.postcode = txtPostCode.Text;

            addr1.UKAddress = ukaddr;
            addrs.Address1 = addr1;

            if (chkEnfBankChk.Checked)
            {
                addlClient.val_3d_status = "FAIL";
                appl1.bank = new bank();
                appl1.bank.account_number = txtAcctNo.Text.Trim();
                appl1.bank.sort_code = txtSortCode.Text.Trim();
            }

            theRequest.control = new control();
            theRequest.strategy = new strategy();
            theRequest.additionalclient = addlClient;
            theRequest.applicant1 = appl1;
            theRequest.addresses = addrs;

            return theRequest;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblApplicationNo.Text = "";
            lblBankCheckStatus.Text = "";
            lblSIRACheckStatus.Text = "";
            lblIDCheckStatus.Text = "";
            lblOverallDecision.Text = "";
            chkEnfBankChk.Checked = false;
            button1.Enabled = true;
            button2.Enabled = false;
            lblErrMsg.Visible = false;
            lblErrMsgText.Visible = false;
            lblOverallDecision.ForeColor = Color.DarkMagenta;
            lblIDCheckStatus.ForeColor = Color.DarkGreen;
            lblApplicationNo.ForeColor = Color.DarkGreen;
            lblBankCheckStatus.ForeColor = Color.DarkGreen;

        }

        private void cmbDecision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDecision.Text.ToUpper() == "ACCEPT")
            {
                SetDataToGetDecision("accept");
            }
            else if (cmbDecision.Text.ToUpper() == "REFER")
            {
                SetDataToGetDecision("refer");
            }
            else if(cmbDecision.Text.ToUpper() == "DECLINE")
            {
                SetDataToGetDecision("Decline");
            }
        }

        private void SetDataToGetDecision(string decision)
        {
            string dcs = decision.ToUpper();
            switch (dcs)
            {
                case "ACCEPT":
                    cmbTitle.Text = "Mr";
                    txtFirstName.Text = "Sally";
                    txtLastName.Text = "Seal";
                    dtpDOB.Text = "8/1/1970";
                    //txtFlatNo.Text=string.Empty;
                    txtHouseNo.Text = "24";
                    //txtHouseName.Text=string.Empty;
                    txtStreet.Text = "Zoofield Grove";
                    txtTown.Text = "Test Town";
                    txtPostCode.Text = "X9 9AD";
                    txtSortCode.Text = "999998";
                    txtAcctNo.Text = "29250201";
                    break;

                case "REFER":
                    cmbTitle.Text = "Mr";
                    txtFirstName.Text = "Thomas Alan";
                    txtLastName.Text = "Court";
                    //dtpDOB.Text = "24/3/1961";
                    //txtFlatNo.Text=string.Empty;
                    txtHouseNo.Text = "72";
                    //txtHouseName.Text=string.Empty;
                    txtStreet.Text = "Two Acres Court";
                    txtTown.Text = "Test Town";
                    txtPostCode.Text = "X9 9JD";
                    txtSortCode.Text = "999998";
                    txtAcctNo.Text = "29250496";             
                    break;

                case "DECLINE":
                    cmbTitle.Text = "Mr";
                    txtFirstName.Text = "Sally";
                    txtLastName.Text = "Seal";
                    dtpDOB.Text = "8/1/1970";
                    //txtFlatNo.Text=string.Empty;
                    txtHouseNo.Text = "24";
                    //txtHouseName.Text=string.Empty;
                    txtStreet.Text = "Zoofield Grove";
                    txtTown.Text = "Test Town";
                    txtPostCode.Text = "X9 9AD";
                    txtSortCode.Text = "999998";
                    txtAcctNo.Text = "29250201";             
                    break;
            }
        }
    }
}
