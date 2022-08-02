using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA_Sizing_and_Cost_Tool
{
    class Calculate
    {
        private int? gLicenseCount;
        private int? gProcessCount;
        private double? gHoursSaved;
        private double? gHourlyWage;
        private double? gTotalSavings;
        private double? gTotalBusinessProfit;
        private double? gMyProfit;
        private double? gMyNetProfit;
        private double? gMyTotalCost;


        public Calculate(int? licenseCount, int? processCount, double? hoursSaved, double? hourlyWage)
        {

            gLicenseCount = licenseCount;
            gProcessCount = processCount;
            gHoursSaved = hoursSaved;
            gHourlyWage = hourlyWage;


            CalculateTotalSavings();

            CalculateTotalBusinessProfit();

            CalculateMyProfit();

            CalculateMyNetProfit();

            CalculateMyTotalCost();

        }

        public double? CalculateTotalSavings()
        {
            // Calcualte total savings from hours worked by employee and their corresponding wage
            return gTotalSavings = ((gHoursSaved * gHourlyWage) *4) * gProcessCount;
        }

        public double? CalculateTotalBusinessProfit()
        {
            gTotalBusinessProfit = gTotalSavings - (Globals.LICENSE_COST + Globals.DEV_FEE_LICENSE_PROFIT + (Globals.DEV_FEE_MEDIUM * gProcessCount));
            return gTotalBusinessProfit;
        }

        public double? CalculateMyProfit()
        {
            gMyProfit = Globals.LICENSE_COST + Globals.DEV_FEE_LICENSE_PROFIT + (Globals.DEV_FEE_MEDIUM * gProcessCount);
            return gMyProfit;
        }

        public double? CalculateTaxDeducted()
        {
            return gMyProfit * Globals.MO_TAX_RATE_2021;
        }

        public double? CalculateMyNetProfit()
        {
            gMyNetProfit = (gMyProfit - CalculateMyTotalCost());
            return gMyNetProfit;
        }

        public double? CalculateMyTotalCost()
        {
            gMyTotalCost = Globals.DEV_LICENSE + Globals.LICENSE_COST + CalculateTaxDeducted();
            return gMyTotalCost;
        }

    }
}
