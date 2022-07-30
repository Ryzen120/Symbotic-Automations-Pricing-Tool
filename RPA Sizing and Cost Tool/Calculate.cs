using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPA_Sizing_and_Cost_Tool
{
    class Calculate
    {
        private int gLicenseCount;
        private int gProcessCount;
        private double gHoursSaved;
        private double gHourlyWage;
        private double gTotalSavings;

        // Make some constants for license cost, tax rate, etc

        public Calculate(int licenseCount, int processCount, double hoursSaved, double hourlyWage)
        {

            gLicenseCount = licenseCount;
            gProcessCount = processCount;
            gHoursSaved = hoursSaved;
            gHourlyWage = hourlyWage;


            CalculateTotalSavings();
        }

        public double CalculateTotalSavings()
        {
            // Calcualte total savings from hours worked by employee and their corresponding wage
            return gTotalSavings = gHoursSaved * gHourlyWage;
        }

        public double CalculateTotalBusinessProfit()
        {
            return 0;
        }

        public double CalculateMyProfit()
        {
            return 0;
        }

        public double CalculateMyNetProfit()
        {
            return 0;
        }

    }
}
