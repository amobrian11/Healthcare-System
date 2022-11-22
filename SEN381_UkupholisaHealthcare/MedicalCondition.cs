using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class MedicalCondition
    {
        public int ConditionID { get; set; }
        public string ConditionName { get; set; }
       

        public MedicalCondition() { }

        public MedicalCondition(int conditionID, string conditionName)
        {
            this.ConditionID = conditionID;
            this.ConditionName = conditionName;
          
        }
    }
}
