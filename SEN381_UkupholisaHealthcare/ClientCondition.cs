using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class ClientCondition
    {
        public int ClientID { get; set; }
        public int ConditionID { get; set; }


        public ClientCondition() { }

        public ClientCondition(int clientID, int conditionID)
        {
            this.ClientID = clientID;
            this.ConditionID = conditionID;
        }
    }
}
