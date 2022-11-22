using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class ClientTreatment
    {
        public int ClientID { get; set; }
        public int TreatmentID { get; set; }


        public ClientTreatment() { }

        public ClientTreatment(int clientID, int treatmentID)
        {
            this.ClientID = clientID;
            this.TreatmentID = treatmentID;
        }
    }
}
