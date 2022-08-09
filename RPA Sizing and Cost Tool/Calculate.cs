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

            CalculateMyProfit();

            CalculateTotalBusinessProfit();

            CalculateTaxDeducted();

            CalculateMyTotalCost();

            CalculateMyNetProfit();
        }

        public void CalculateSmallSavings()
        {
            gSmallSavings = ((Globals.gHoursSavedSmall * Globals.gHourlyWageSmall) * 4) * Convert.ToInt32(Globals.gProcessCountSmall);

            if(gSmallSavings == null)
            {
                gSmallSavings = 0.0;
            }
        }

        public void CalculateMediumSavings()
        {
            gMediumSavings = ((Globals.gHoursSavedMedium * Globals.gHourlyWageMedium) * 4) * Convert.ToInt32(Globals.gProcessCountMedium);

            if (gMediumSavings == null)
            {
                gMediumSavings = 0.0;
            }
        }

        public void CalculateLargeSavings()
        {
            gLargeSavings = ((Globals.gHoursSavedLarge * Globals.gHourlyWageLarge) * 4) * Convert.ToInt32(Globals.gProcessCountLarge);

            if (gLargeSavings == null)
            {
                gLargeSavings = 0.0;
            }
        }

        public void CalculateTotalSavings()
        {
            // Calculate all size savings
            CalculateSmallSavings();
            CalculateMediumSavings();
            CalculateLargeSavings();

            // Calcualte total savings from hours worked by employee and their corresponding wage
            Globals.gTotalSavings = gLargeSavings + gMediumSavings + gSmallSavings;
        }

        public void CalculateTotalBusinessProfit()
        {
            Globals.gTotalBusinessProfit = Globals.gTotalSavings - Globals.gMyProfit;
        }

        public void CalculateMyProfit()
        {
            Globals.gMyProfit = (Globals.LICENSE_COST * Globals.gLicenseCount) + (Globals.DEV_FEE_LICENSE_PROFIT * Globals.gLicenseCount) + (Globals.DEV_FEE_SMALL * Convert.ToInt32(Globals.gProcessCountSmall)) + (Globals.DEV_FEE_MEDIUM * Convert.ToInt32(Globals.gProcessCountMedium)) + (Globals.DEV_FEE_LARGE * Convert.ToInt32(Globals.gProcessCountLarge));
        }

        public void CalculateTaxDeducted()
        {
            Globals.gMyTaxDeducted = Globals.gMyProfit * Globals.MO_TAX_RATE_2021;
        }

        public void CalculateMyNetProfit()
        {
            Globals.gMyNetProfit = (Globals.gMyProfit - Globals.gMyTotalCost);
        }

        public void CalculateMyTotalCost()
        {
            Globals.gMyTotalCost = Globals.DEV_LICENSE + (Globals.LICENSE_COST * Globals.gLicenseCount) + Globals.gMyTaxDeducted + Globals.QUICKBOOKS_FEE + Globals.MICROSOFT_FEE + Globals.DOMAIN_FEE;
        }
    }
}
