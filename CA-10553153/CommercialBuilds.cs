using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_10553153
{
    class CommercialBuilds 
    {
        public List<CommercialBuild> commercialBuilds = new List<CommercialBuild>();
        
        public bool AddBuilding(CommercialBuild building)
        {
            if(!AlreadyAdded(building))
            {
                commercialBuilds.Add(building);
                return true;
            }
            return false;
        }
    
       
        public bool AlreadyAdded(CommercialBuild building)
        {
            bool found = false;
            foreach (var cb in commercialBuilds)
            {
                if(cb.BuildingAddress.Eircode == building.BuildingAddress.Eircode)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        public bool RemoveByEircode(string eircode)
        {
            CommercialBuild cb = GetCommercialBuild(eircode);
            bool removed = false;

            if (cb != null)
            {
                commercialBuilds.Remove(cb);
                removed = true;
            }
            return removed;
        }

        public CommercialBuild GetCommercialBuild(string eircode)
        {
            CommercialBuild building = null;
            foreach (CommercialBuild cb in commercialBuilds)
            {
                if (cb.BuildingAddress.Eircode.Equals(eircode))
                {
                    building = cb;
                    break;
                }
            }
            return building;
        }

        public IEnumerator<CommercialBuild> GetEnumerator()
        {
            return commercialBuilds.GetEnumerator();
        }
    }
}
