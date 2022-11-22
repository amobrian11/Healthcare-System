using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class ProviderForClient
    {
        public int ProviderID { get; set; }
        public int ClientID { get; set; }


        public ProviderForClient() { }

        public ProviderForClient(int providerID, int clientID)
        {
            this.ProviderID = providerID;
            this.ClientID = clientID;
        }
    }
}
