using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class TreatmentProvider
    {
        public int ProviderID { get; set; }
        public int TreatmentID { get; set; }


        public TreatmentProvider() { }

        public TreatmentProvider(int providerID, int treatmentID)
        {
            this.ProviderID = providerID;
            this.TreatmentID = treatmentID;
        }
    }
}
