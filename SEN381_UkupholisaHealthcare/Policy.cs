using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ukupholisa_Healthcare
{
    class Policy
    {
        public int PolicyID { get; set; }
        public string PackageTear { get; set; }
        public string Packagetype { get; set; }
        public string PackageStatus { get; set; }
        public double Price { get; set; }

        public Policy() { }
        public Policy(int policyID, string packageTear, string packagetype, string packageStatus, double price)
        {
            this.PolicyID = policyID;
            this.PackageTear = packageTear;
            this.Packagetype = packagetype;
            this.PackageStatus = packageStatus;
            this.Price = price;
        }
    }
}
