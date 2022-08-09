using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA_Sizing_and_Cost_Tool
{
    static class Globals
    {
        // Cost per month for dev software
        public static double DEV_LICENSE = 420.00;

        // Cost per month per license deployed
        public static double LICENSE_COST = 980.00;

        // Charging scheme for each size of process
        public static double DEV_FEE_SMALL = 375.00;
        public static double DEV_FEE_MEDIUM = 550.00;
        public static double DEV_FEE_LARGE = 750.00;

        // Profit gained on each license sold
        public static double DEV_FEE_PERCENTAGE = 0.85;
        public static double DEV_FEE_LICENSE_PROFIT = LICENSE_COST * DEV_FEE_PERCENTAGE;

        // Tax rate for state of operation
        public static double MO_TAX_RATE_2021 = 0.27;
        public static double? gMyTaxDeducted;

        // Overhead fees for business
        public static double QUICKBOOKS_FEE = 65.00;
        public static double DOMAIN_FEE = 23.00;
        public static double MICROSOFT_FEE = 12.50;

        // Values from user
        public static int? gLicenseCount;

        public static double? gHoursSavedSmall;
        public static double? gHourlyWageSmall;

        public static double? gHoursSavedMedium;
        public static double? gHourlyWageMedium;

        public static double? gHoursSavedLarge;
        public static double? gHourlyWageLarge;

        public static double? gTotalSavings;
        public static double? gTotalBusinessProfit;
        public static double? gMyProfit;
        public static double? gMyNetProfit;
        public static double? gMyTotalCost;

        public static decimal? gProcessCountSmall;
        public static decimal? gProcessCountMedium;
        public static decimal? gProcessCountLarge;


    }
}
