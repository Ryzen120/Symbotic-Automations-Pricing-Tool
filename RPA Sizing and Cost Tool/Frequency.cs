using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;



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

        private Point gStartLocation;

        private bool gDragging;

        private int[] gStartPoint;

        private int? gLicenseCount;
        private int? gProcessCount;
        private double? gHoursSaved;
        private double? gHourlyWage;
        private double? gTotalSavings;
        private double? gTotalBusinessProfit;
        private double? gMyProfit;
        private double? gMyNetProfit;
        private double? gMyTotalCost;


        public Frequency()
        {
            InitializeComponent();

            gStartPoint = new int[2];
        }

        private void m_TextBoxLicenseCount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxLicenseCount.Text, " ^ [0-9]"))
            {
                m_TextBoxLicenseCount.Text = "";
            }
            else
            {
                if(!String.IsNullOrEmpty(m_TextBoxLicenseCount.Text))
                {
                    gLicenseCount = Int32.Parse(m_TextBoxLicenseCount.Text);
                }
                else
                {
                    m_TextBoxLicenseCount.Text = "0";
                    gLicenseCount = 0;
                }
            }
        }

        private void m_TextBoxProcessCount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxProcessCount.Text, " ^ [0-9]"))
            {
                m_TextBoxProcessCount.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxProcessCount.Text))
                {
                    gProcessCount = Int32.Parse(m_TextBoxProcessCount.Text);
                }
                else
                {
                    m_TextBoxProcessCount.Text = "0";
                    gProcessCount = 0;
                }
            }
        }
        
        private void m_TextBoxHoursSaved_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHoursSaved.Text, " ^ [0-9]"))
            {
                m_TextBoxHoursSaved.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHoursSaved.Text))
                {
                    gHoursSaved = Double.Parse(m_TextBoxHoursSaved.Text);
                }
                else
                {
                    m_TextBoxHoursSaved.Text = "0";
                    gHoursSaved = 0;
                }
            }
        }

        private void m_TextBoxHourlyWage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHourlyWage.Text, " ^ [0-9]"))
            {
                m_TextBoxHourlyWage.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHourlyWage.Text))
                {
                    gHourlyWage = Double.Parse(m_TextBoxHourlyWage.Text);
                }
                else
                {
                    m_TextBoxHourlyWage.Text = "0";
                    gHourlyWage = 0;
                }
            }
        }

        private void m_RichTextBoxTotalBusinessSavings_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessSavings.Text = gTotalSavings.ToString();
        }

        private void m_RichTextBoxTotalBusinessProfit_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessProfit.Text = gTotalBusinessProfit.ToString();
        }

        private void m_RichTextBoxMyTotalProfit_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxMyTotalProfit.Text = gMyProfit.ToString();
        }

        private void m_RichTextBoxMyNetProfit_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxMyNetProfit.Text = gMyNetProfit.ToString();
        }

        private void m_RichTextBoxMyTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_ButtonStart_Click(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessSavings.Text = "0";
            m_RichTextBoxTotalBusinessProfit.Text = "0";
            m_RichTextBoxMyTotalProfit.Text = "0";
            m_RichTextBoxMyNetProfit.Text = "0";

            Calculate calc = new Calculate(gLicenseCount, gProcessCount, gHoursSaved, gHourlyWage);

            // If either hours saved or hourly wage is null, we cant calculate total savings, so throw error.
            if(!(gHoursSaved == null) || !(gHourlyWage == null))
            {
                gTotalSavings = calc.CalculateTotalSavings();

                m_RichTextBoxTotalBusinessSavings.Text = gTotalSavings.ToString();
            }
            else
            {
                MessageBox.Show("Hours saved or Hourly wage was left empty, cannot calculate total savings.", "Error: Cant calculate field");
            }
            
            // If we dont have total savings calculated, we cant calculate the busiess profit
            if(!(gTotalSavings == null))
            {
                gTotalBusinessProfit = calc.CalculateTotalBusinessProfit();

                m_RichTextBoxTotalBusinessProfit.Text = gTotalBusinessProfit.ToString();
            }
            else
            {
                MessageBox.Show("Total savings could not be calculated, cannot calculate total business profit.", "Error: Cant calculate field");
            }

            // My profit is based on globals values, so cant be null.
            gMyProfit = calc.CalculateMyProfit();
            m_RichTextBoxMyTotalProfit.Text = gMyProfit.ToString();

            // My profit is based on globals values, so cant be null.
            gMyNetProfit = calc.CalculateMyNetProfit();
            m_RichTextBoxMyNetProfit.Text = gMyNetProfit.ToString();

            gMyTotalCost = calc.CalculateMyTotalCost();
            m_RichTextBoxMyTotalCost.Text = gMyTotalCost.ToString();



        }

        private void m_PanelTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(gDragging)
            {
                Point p = PointToScreen(new Point(m_PanelTitleBar.Location.X + e.Location.X, m_PanelTitleBar.Location.Y + e.Location.Y));

                Location = new Point(gStartPoint[0] + p.X - gStartLocation.X, gStartPoint[1] + p.Y - gStartLocation.Y);
            }
        }

        private void m_PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                float ratio = (float)(e.Location.X) / (float)(m_PanelTitleBar.Width);
                this.WindowState = FormWindowState.Normal;
                Point p = PointToScreen(new Point(m_PanelTitleBar.Location.X + e.Location.X,
                                                    m_PanelTitleBar.Location.Y + e.Location.Y));

                gStartLocation = p;
                gStartPoint[0] = Location.X;
                gStartPoint[1] = Location.Y;

            }
            else
            {
                gStartLocation = PointToScreen(new Point(m_PanelTitleBar.Location.X + e.Location.X,
                                                            m_PanelTitleBar.Location.Y + e.Location.Y));

                gStartPoint[0] = Location.X;
                gStartPoint[1] = Location.Y;
            }
            gDragging = true;
        }

        private void m_PanelTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            gDragging = false;

            Point p = PointToScreen(e.Location);
            if(p.Y < 2)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void m_TextBoxLicenseCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void m_TextBoxProcessCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void m_TextBoxHoursSaved_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void m_TextBoxHourlyWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void m_ButtonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void m_ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void m_CheckBoxSmall_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m_CheckBoxMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m_CheckBoxLarge_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
