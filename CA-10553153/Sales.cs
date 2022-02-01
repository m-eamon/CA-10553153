using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class Sales : Residential
    {
        public StatusEnum Status { get; set; }
        public double AskingPrice { get; set; }
        public DateTime DateEntered { get; set; }

        public Sales() { }

        public Sales(Address buildingAddress, double squareFootage, double valuation, string ownerName, string ownerEmail, StatusEnum status, double askingPrice, DateTime dateEntered)
            : base(buildingAddress, squareFootage, valuation, ownerName, ownerEmail)
        {
            Status = status;
            AskingPrice = askingPrice;
            DateEntered = dateEntered;
        }

        public override string ToString()
        {
            return base.ToString() + $", Status: {Status}, AskingPrice: {AskingPrice}, DateEntered: {DateEntered}";
        }

        public string ShowBuilding()
        {
            return $"Eircode: {BuildingAddress.Eircode}, Status: {Status.ToString()}, Entered: {DateEntered.ToString()}";
        }
    }
}
