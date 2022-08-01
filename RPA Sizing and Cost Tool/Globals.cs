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
        public static double DEV_FEE_SMALL = 275.00;
        public static double DEV_FEE_MEDIUM = 375.00;
        public static double DEV_FEE_LARGE = 550.00;

        // Profit gained on each license sold
        public static double DEV_FEE_PERCENTAGE = 0.6;
        public static double DEV_FEE_LICENSE_PROFIT = LICENSE_COST * DEV_FEE_PERCENTAGE;

        // Tax rate for state of operation
        public static double MO_TAX_RATE_2021 = 0.27;

        // Overhead fees for business
        public static double QUICKBOOKS_FEE = 65.00;
        public static double DOMAIN_FEE = 23.00;

    }
}
