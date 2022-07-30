using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPA_Sizing_and_Cost_Tool
{
    public partial class Frequency : Form
    {
        /*
        private string gLicenseCount;
        private string gProcessCount;
        private string gHoursSaved;
        private string gHourlyWage;
        */

        private int gLicenseCount;
        private int gProcessCount;
        private double gHoursSaved;
        private double gHourlyWage;
        private double gTotalSavings;

        public Frequency()
        {
            InitializeComponent();
        }

        private void m_TextBoxLicenseCount_TextChanged(object sender, EventArgs e)
        {
            gLicenseCount = Int32.Parse(m_TextBoxLicenseCount.Text);
        }

        private void m_TextBoxProcessCount_TextChanged(object sender, EventArgs e)
        {
            gProcessCount = Int32.Parse(m_TextBoxProcessCount.Text);
        }

        private void m_TextBoxHoursSaved_TextChanged(object sender, EventArgs e)
        {
            gHoursSaved = Double.Parse(m_TextBoxHoursSaved.Text);
        }

        private void m_TextBoxHourlyWage_TextChanged(object sender, EventArgs e)
        {
            gHourlyWage = Double.Parse(m_TextBoxHourlyWage.Text);
        }

        private void m_RichTextBoxTotalBusinessSavings_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessSavings.Text = gTotalSavings.ToString();
        }

        private void m_RichTextBoxTotalBusinessProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_RichTextBoxMyTotalProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_RichTextBoxMyNetProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_ButtonStart_Click(object sender, EventArgs e)
        {
            Calculate calc = new Calculate(gLicenseCount, gProcessCount, gHoursSaved, gHourlyWage);

            gTotalSavings = calc.CalculateTotalSavings();

            m_RichTextBoxTotalBusinessSavings.Text = gTotalSavings.ToString();
           
        }
    }
}
