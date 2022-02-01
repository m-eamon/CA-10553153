using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class SalesS
    {
        public List<Sales> salesS = new List<Sales>();

        public bool AddBuilding(Sales building)
        {
            if (!AlreadyAdded(building))
            {
                salesS.Add(building);
                return true;
            }
            return false;
        }


        public bool AlreadyAdded(Sales building)
        {
            bool found = false;
            foreach (var s in salesS)
            {
                if (s.BuildingAddress.Eircode == building.BuildingAddress.Eircode)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public IEnumerator<Sales> GetEnumerator()
        {
            return salesS.GetEnumerator();
        }
    }
}
