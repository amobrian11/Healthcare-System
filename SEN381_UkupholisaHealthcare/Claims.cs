using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace Ukupholisa_Healthcare
{
    class Claims
    {
        public int ClaimID { get; set; }
        public string Condition{ get; set; }
        public string Treatment{ get; set; }
        public string Provider{ get; set; }
        
        public int ClientID{ get; set; }
        public string Date { get; set; }

        public Claims() { }

        public Claims(int claimID, string condition, string treatment, string provider, int clientID, string date)
        {
            this.ClaimID = claimID;
            this.Condition = condition;
            this.Treatment = treatment;
            this.Provider = provider;
            this.ClientID = clientID;
            this.Date = date;
            
        }

    }
}
