using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class Client
    {
        public int ClientID { get; set; }
        public string NationalID{ get; set; }
        public string MemberSatus{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string DOB{ get; set; }
        public string StreetNumberAndName{ get; set; }
        public string CityName{ get; set; }
        public string PostalCode{ get; set; }
        public string CellNumber{ get; set; }
        public string Email{ get; set; }
        public int PolicyID{ get; set; }
       
        
        public Client() { }
        public Client(int clientID, string nationalID, string memberSatus, string firstName, string lastName, string dob, string streetNumberAndName, string cityName, string postalCode, string cellNumber, string email, int policyID)
        {
            this.ClientID = clientID;
            this.NationalID = nationalID;
            this.MemberSatus = memberSatus;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DOB = dob;
            this.StreetNumberAndName = streetNumberAndName;
            this.CityName = cityName;
            this.PostalCode = postalCode;
            this.CellNumber = cellNumber;
            this.Email = email;
            this.PolicyID = policyID;
        }

        
    }
}
