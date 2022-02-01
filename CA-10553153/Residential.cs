using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    abstract class Residential : Building
    {
        public double Valuation { get; set; }
        public string OwnerName { get; set; }
        public string OwnerEmail { get; set; }

        public Residential() { }
        public Residential(Address buildingAddress, double squareFootage, double valuation, string ownerName, string ownerEmail)
            : base(buildingAddress, squareFootage)
        {
            Valuation = valuation;
            OwnerName = ownerName;
            OwnerEmail = ownerEmail;
        }

        public override string ToString()
        {
            return base.ToString() + $", \nValuation: {Valuation}, OwnerName: {OwnerName}, OwnerEmail: {OwnerEmail}";
        }

    }
}
