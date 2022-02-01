using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    abstract class Building
    {
        public Address BuildingAddress { get; set; }
        public double SquareFootage { get; set; }

        public Building() { }

        public Building(Address buildingAddress, double squareFootage)
        {
            BuildingAddress = buildingAddress;
            SquareFootage = squareFootage;
            
        }

        public override string ToString()
        {
            return $"Address: {BuildingAddress}, \nSquareFootage: {SquareFootage}";
        }
    }
}
