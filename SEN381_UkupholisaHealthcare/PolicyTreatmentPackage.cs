using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class PolicyTreatmentPackage
    {
        public int PolicyID { get; set; }
        public int TreatmentID { get; set; }


        public PolicyTreatmentPackage() { }

        public PolicyTreatmentPackage(int policyID, int treatmentID)
        {
            this.PolicyID = policyID;
            this.TreatmentID = treatmentID;
        }
    }
}
