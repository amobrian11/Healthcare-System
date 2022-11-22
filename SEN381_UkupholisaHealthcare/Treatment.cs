using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class Treatment
    {
        public int TreatmentID { get; set; }
        public string TreatmentName { get; set; }
       

        public Treatment() { }

        public Treatment(int treatmentID, string treatmentName)
        {
            this.TreatmentID = treatmentID;
            this.TreatmentName = treatmentName;
           
        }
    }
}
