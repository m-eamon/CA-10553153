using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class CommercialBuild : Building
    {
        public double Rates { get; set; }

        public IntendedPurposeEnum IntendedPurpose { get; set; }

        public CommercialBuild() { }

        public CommercialBuild(Address buildingAddress, double squareFootage, double rates, IntendedPurposeEnum intendedPurpose)
            : base(buildingAddress, squareFootage)
        {
            Rates = rates;
            IntendedPurpose = intendedPurpose;
        }

        public override string ToString()
        {
            return base.ToString() + $", \nRates: {Rates}, IntendedPurpose: {IntendedPurpose}";
        }

        public string ShowBuilding()
        {
            return $"Eircode: {BuildingAddress.Eircode}, SquareFootage: {SquareFootage}, IntendedPurpose: {IntendedPurpose}";
        }
    }
}
