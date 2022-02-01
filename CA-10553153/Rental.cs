using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class Rental : Residential
    {
        public double Rent { get; set; }

        public Rental() { }

        public Rental(Address buildingAddress, double squareFootage, double valuation, string ownerName, string ownerEmail, double rent)
            : base(buildingAddress, squareFootage, valuation, ownerName, ownerEmail)
        {
            Rent = rent;
        }

        public override string ToString()
        {
            return base.ToString() + $", Rent: {Rent}";
        }

    }


}
