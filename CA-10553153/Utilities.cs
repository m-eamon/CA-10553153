using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Return Enum types from string equivalent.  
 * For drop-down lists.
 */
namespace CA_10553153
{
    public static class Utilities
    {
        public static CountyEnum GetCounty(string county)
        {
            CountyEnum countyEnum;

            switch (county)
            {
                case "Antrim":
                    countyEnum = CountyEnum.Antrim;
                    break;
                case "Armagh":
                    countyEnum = CountyEnum.Armagh;
                    break;
                case "Carlow":
                    countyEnum = CountyEnum.Carlow;
                    break;
                case "Cavan":
                    countyEnum = CountyEnum.Cavan;
                    break;
                case "Cork":
                    countyEnum = CountyEnum.Cork;
                    break;
                case "Derry":
                    countyEnum = CountyEnum.Derry;
                    break;
                case "Donegal":
                    countyEnum = CountyEnum.Donegal;
                    break;
                case "Down":
                    countyEnum = CountyEnum.Antrim;
                    break;
                case "Dublin":
                    countyEnum = CountyEnum.Dublin;
                    break;
                case "Fermanagh":
                    countyEnum = CountyEnum.Fermanagh;
                    break;
                case "Galway":
                    countyEnum = CountyEnum.Galway;
                    break;
                case "Kerry":
                    countyEnum = CountyEnum.Kerry;
                    break;
                case "Kildare":
                    countyEnum = CountyEnum.Kildare;
                    break;
                case "Kilkenny":
                    countyEnum = CountyEnum.Kilkenny;
                    break;
                case "Laois":
                    countyEnum = CountyEnum.Laois;
                    break;
                case "Limerick":
                    countyEnum = CountyEnum.Limerick;
                    break;
                case "Leitrim":
                    countyEnum = CountyEnum.Leitrim;
                    break;
                case "Longford":
                    countyEnum = CountyEnum.Longford;
                    break;
                case "Louth":
                    countyEnum = CountyEnum.Louth;
                    break;
                case "Mayo":
                    countyEnum = CountyEnum.Mayo;
                    break;
                case "Meath":
                    countyEnum = CountyEnum.Meath;
                    break;
                case "Monaghan":
                    countyEnum = CountyEnum.Monaghan;
                    break;
                case "Offaly":
                    countyEnum = CountyEnum.Offaly;
                    break;
                case "Roscommon":
                    countyEnum = CountyEnum.Roscommon;
                    break;
                case "Sligo":
                    countyEnum = CountyEnum.Sligo;
                    break;
                case "Tipperary":
                    countyEnum = CountyEnum.Tipperary;
                    break;
                case "Tyrone":
                    countyEnum = CountyEnum.Tyrone;
                    break;
                case "Waterford":
                    countyEnum = CountyEnum.Waterford;
                    break;
                case "Westmeath":
                    countyEnum = CountyEnum.Westmeath;
                    break;
                case "Wexford":
                    countyEnum = CountyEnum.Wexford;
                    break;
                case "Wicklow":
                    countyEnum = CountyEnum.Wicklow;
                    break;
                default:
                    countyEnum = CountyEnum.NoCounty;
                    break;
            }
            return countyEnum;
        }

        public static IntendedPurposeEnum GetIntendedPurpose(string intendedPurpose)
        {
            IntendedPurposeEnum intendedPurposeEnum;

            switch (intendedPurpose)
            {
                case "Office":
                    intendedPurposeEnum = IntendedPurposeEnum.Office;
                    break;
                case "Industrial":
                    intendedPurposeEnum = IntendedPurposeEnum.Industrial;
                    break;
                case "Retail":
                    intendedPurposeEnum = IntendedPurposeEnum.Retail;
                    break;
                default:
                    intendedPurposeEnum = IntendedPurposeEnum.Office;
                    break;
            }
            return intendedPurposeEnum;
        }

        public static StatusEnum GetStatus(string status)
        {
            StatusEnum statusEnum;

            switch (status)
            {
                case "For Sale":
                    statusEnum = StatusEnum.ForSale;
                    break;
                case "Sale Agreed":
                    statusEnum = StatusEnum.SaleAgreed;
                    break;
                case "Sold":
                    statusEnum = StatusEnum.Sold;
                    break;
                default:
                    statusEnum = StatusEnum.ForSale;
                    break;
            }

            return statusEnum;
        }
    }

}
