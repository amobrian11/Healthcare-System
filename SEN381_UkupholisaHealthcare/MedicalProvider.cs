using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class MedicalProvider
    {
        public int ProviderID { get; set; }
        public string ProviderName { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public string StreetNumberAndName { get; set; }
        public string PostalCode { get; set; }

        public MedicalProvider() { }

        public MedicalProvider(int providerID, string providerName, string Status, string city, string streetNumberAndName, string postalCode)
        {
            this.ProviderID = providerID;
            this.ProviderName = providerName;
            this.Status = Status;
            this.City = city;
            this.StreetNumberAndName = streetNumberAndName;
            this.PostalCode = postalCode;
        }
    }
}
