using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class Rentals
    {
        public List<Rental> rentals = new List<Rental>();

        public bool AddBuilding(Rental building)
        {
            if (!AlreadyAdded(building))
            {
                rentals.Add(building);
                return true;
            }
            return false;
        }


        public bool AlreadyAdded(Rental building)
        {
            bool found = false;
            foreach (var r in rentals)
            {
                if (r.BuildingAddress.Eircode == building.BuildingAddress.Eircode)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public IEnumerator<Rental> GetEnumerator()
        {
            return rentals.GetEnumerator();
        }
    }
}
