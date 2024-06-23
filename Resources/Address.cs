using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Resources
{
    public class Address
    {
        public int addressId {  get; set; }
        public string address {  get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        public string phone {  get; set; }
        public string createdBy { get; set; }
    }

    public class City
    {
        public int cityId { get; set; }
        public string city { get; set; }
        public int countryId { get; set; }
        public string createdBy { get; set; }
    }

    public class Country
    {
        public int countryId { get; set; }
        public string country { get; set; }
        public string createdBy { get; set; }
    }
}