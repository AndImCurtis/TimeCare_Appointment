using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Resources
{
    public class grabCustomer
    {
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public string country{ get; set; }

        public string CustType { get; set; }


        public grabCustomer() { }


        public grabCustomer(int custID, string custName, string phone, string ad, string ad2, string pCode, string citY, string countrY, string custType)
        {
            customerId = custID;
            customerName = custName;
            phoneNumber = phone;
            address = ad;
            address2 = ad2;
            postalCode = pCode;
            city = citY;
            country = countrY;
            CustType= custType; 
        }
    }

}
