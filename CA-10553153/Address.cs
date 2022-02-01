using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class Address
    {
        public string BuildingNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Town { get; set; }
        public CountyEnum County { get; set; }
        public string Eircode { get; set; }

        public Address() { }
        public Address(string buildingNumber, string addressLine1, string addressLine2, string town, CountyEnum county, string eircode)
        {
            BuildingNumber = buildingNumber;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Town = town;
            County = county;
            Eircode = eircode;
        }

        public override string ToString()
        {
            return $"BuildingNumber: {BuildingNumber}, AddressLine1: {AddressLine1}, AddressLine2: {AddressLine2}, \nTown: {Town}, " +
                $"County: {County}, Eircode: {Eircode}";
        }
    }
}
