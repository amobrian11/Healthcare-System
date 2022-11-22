using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class Address
    {
        public int AddressID { get; set; }
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public Address() { }

        public Address(int addressID, string streetNum, string streetName, string city, string postalCode)
        {
            this.AddressID = addressID;
            this.StreetNum = streetNum;
            this.StreetName = streetName;
            this.City = city;
            this.PostalCode = postalCode;
        }
    }
}
