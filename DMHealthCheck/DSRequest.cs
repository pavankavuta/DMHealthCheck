using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMHealthCheck
{
    public class ds_request
    {
        public control control = new control();
        public strategy strategy = new strategy();
        public applicant1 applicant1 = new applicant1();
        public addresses addresses = new addresses();
        public additionalclient additionalclient = new additionalclient();
    }

    public class control
    {
        public string application_id;
        public string client_application_id = "CLNT000";
        public string request_type = "NEW";
    }

    public class strategy
    {
        public string product = "SAVINGS";        
    }

    public class applicant1
    {
        public name name;
        public current_address current_address;
        public contact_telephone_1 contact_telephone_1;
        public contact_email_1 contact_email_1;
        public bank bank;
    }

    public class Address1
    {
        public int AddressId = 1;
        public int AddressType = 1;
        public UKAddress UKAddress;       
    }

    public class addresses
    { 
        public Address1 Address1;
    }

    public class name
    {
        public string title;
        public string forename;
        public string surname;
        public string dob;
    }

    public class current_address
    {
        public int AddressId = 1;
        public string AddressDateFrom = "2010-01-01";
    }

    public class contact_telephone_1
    {
        public int type;
        public string number;
    }

    public class contact_email_1
    {
        public int type;
        public string email;
    }

    public class bank
    {
        public string account_number = "29250201";
        public string sort_code = "999998";
    }

    public class UKAddress
    {
        public string abodeno;
        public string house_name;
        public string house_number = "24";
        public string street1 = "ZOOFIELD GROVE";
        public string street2;
        public string district1;
        public string district2;
        public string posttown = "TEST TOWN";
        public string postcode = "X9 9AD";
    }

    public class additionalclient
    {
        public string  applicant_type  = "APP01";
        public string  val_3d_status  = "PASS";       
        public int  no_valid_docs  = 0;
        public string  sira_product  = "FIXEDSAV";
    }
}
