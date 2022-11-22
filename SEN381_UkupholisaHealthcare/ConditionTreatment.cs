using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class ConditionTreatment
    {
        public int TreatmentID { get; set; }
        public int ConditionID { get; set; }


        public ConditionTreatment() { }

        public ConditionTreatment(int treatmentID, int conditionID)
        {
            this.TreatmentID = treatmentID;
            this.ConditionID = conditionID;
        }
    }
}
