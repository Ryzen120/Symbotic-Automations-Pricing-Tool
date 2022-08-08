using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA_Sizing_and_Cost_Tool
{
    class Calculate
    {

        private double? gSmallSavings;
        private double? gMediumSavings;
        private double? gLargeSavings;


        public Calculate()
        {

            CalculateTotalSavings();

            CalculateTotalBusinessProfit();

            CalculateMyProfit();

            CalculateMyNetProfit();

            CalculateMyTotalCost();

        }

        public void CalculateSmallSavings()
        {
            gSmallSavings = ((Globals.gHoursSavedSmall * Globals.gHourlyWageSmall) * 4) * Convert.ToInt32(Globals.gProcessCountSmall);
        }

        public void CalculateMediumSavings()
        {
            gMediumSavings = ((Globals.gHoursSavedMedium * Globals.gHourlyWageMedium) * 4) * Convert.ToInt32(Globals.gProcessCountMedium);
        }

        public void CalculateLargeSavings()
        {
            gLargeSavings = ((Globals.gHoursSavedLarge * Globals.gHourlyWageLarge) * 4) * Convert.ToInt32(Globals.gProcessCountLarge);
        }

        public double? CalculateTotalSavings()
        {
            // Calculate all size savings
            CalculateSmallSavings();
            CalculateMediumSavings();
            CalculateLargeSavings();

            // Calcualte total savings from hours worked by employee and their corresponding wage
            return Globals.gTotalSavings = gLargeSavings + gMediumSavings + gSmallSavings;
        }

        public double? CalculateTotalBusinessProfit()
        {
            //Globals.gTotalBusinessProfit = Globals.gTotalSavings - (Globals.LICENSE_COST + Globals.DEV_FEE_LICENSE_PROFIT + (Globals.DEV_FEE_MEDIUM * Convert.ToInt32(Globals.gProcessCount)));
            return Globals.gTotalBusinessProfit;
        }

        public double? CalculateMyProfit()
        {
            //Globals.gMyProfit = Globals.LICENSE_COST + Globals.DEV_FEE_LICENSE_PROFIT + (Globals.DEV_FEE_MEDIUM * Convert.ToInt32(Globals.gProcessCount));
            return Globals.gMyProfit;
        }

        public double? CalculateTaxDeducted()
        {
            return Globals.gMyProfit * Globals.MO_TAX_RATE_2021;
        }

        public double? CalculateMyNetProfit()
        {
            Globals.gMyNetProfit = (Globals.gMyProfit - CalculateMyTotalCost());
            return Globals.gMyNetProfit;
        }

        public double? CalculateMyTotalCost()
        {
            Globals.gMyTotalCost = Globals.DEV_LICENSE + Globals.LICENSE_COST + CalculateTaxDeducted();
            return Globals.gMyTotalCost;
        }

    }
}
