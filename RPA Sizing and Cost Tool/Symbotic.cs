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
    public partial class Symbotic : Form
    {
        private Point gStartLocation;

        private bool gDragging;

        private int[] gStartPoint;


        public Symbotic()
        {
            // Init
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
                    Globals.gLicenseCount = Int32.Parse(m_TextBoxLicenseCount.Text);
                }
                else
                {
                    m_TextBoxLicenseCount.Text = "0";
                    Globals.gLicenseCount = 0;
                }
            }
        }

        // SMALL FIELDS
        private void m_TextBoxHoursSavedSmall_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHoursSavedSmall.Text, " ^ [0-9]"))
            {
                m_TextBoxHoursSavedSmall.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHoursSavedSmall.Text))
                {
                    Globals.gHoursSavedSmall = Double.Parse(m_TextBoxHoursSavedSmall.Text);
                }
                else
                {
                    m_TextBoxHoursSavedSmall.Text = "0";
                    Globals.gHoursSavedSmall = 0;
                }
            }
        }

        private void m_TextBoxHourlyWageSmall_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHourlyWageSmall.Text, " ^ [0-9]"))
            {
                m_TextBoxHourlyWageSmall.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHourlyWageSmall.Text))
                {
                    Globals.gHourlyWageSmall = Double.Parse(m_TextBoxHourlyWageSmall.Text);
                }
                else
                {
                    m_TextBoxHourlyWageSmall.Text = "0";
                    Globals.gHourlyWageSmall = 0;
                }
            }
        }

        // MEDIUM FIELDS
        private void m_TextBoxHoursSavedMedium_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHoursSavedMedium.Text, " ^ [0-9]"))
            {
                m_TextBoxHoursSavedMedium.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHoursSavedMedium.Text))
                {
                    Globals.gHoursSavedMedium = Double.Parse(m_TextBoxHoursSavedMedium.Text);
                }
                else
                {
                    m_TextBoxHoursSavedMedium.Text = "0";
                    Globals.gHoursSavedMedium = 0;
                }
            }
        }

        private void m_TextBoxHourlyWageMedium_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHourlyWageMedium.Text, " ^ [0-9]"))
            {
                m_TextBoxHourlyWageMedium.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHourlyWageMedium.Text))
                {
                    Globals.gHourlyWageMedium = Double.Parse(m_TextBoxHourlyWageMedium.Text);
                }
                else
                {
                    m_TextBoxHourlyWageMedium.Text = "0";
                    Globals.gHourlyWageMedium = 0;
                }
            }
        }

        // LARGE FIELDS
        private void m_TextBoxHoursSavedLarge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHoursSavedLarge.Text, " ^ [0-9]"))
            {
                m_TextBoxHoursSavedLarge.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHoursSavedLarge.Text))
                {
                    Globals.gHoursSavedLarge = Double.Parse(m_TextBoxHoursSavedLarge.Text);
                }
                else
                {
                    m_TextBoxHoursSavedLarge.Text = "0";
                    Globals.gHoursSavedLarge = 0;
                }
            }
        }

        private void m_TextBoxHourlyWageLarge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(m_TextBoxHourlyWageLarge.Text, " ^ [0-9]"))
            {
                m_TextBoxHourlyWageLarge.Text = "";
            }
            else
            {
                if (!String.IsNullOrEmpty(m_TextBoxHourlyWageLarge.Text))
                {
                    Globals.gHourlyWageLarge = Double.Parse(m_TextBoxHourlyWageLarge.Text);
                }
                else
                {
                    m_TextBoxHourlyWageLarge.Text = "0";
                    Globals.gHourlyWageLarge = 0;
                }
            }
        }

        // OUTPUT FIELDS
        private void m_RichTextBoxTotalBusinessSavings_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessSavings.Text = Globals.gTotalSavings.ToString();
        }

        private void m_RichTextBoxTotalBusinessProfit_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessProfit.Text = Globals.gTotalBusinessProfit.ToString();
        }

        private void m_RichTextBoxMyTotalProfit_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxMyTotalProfit.Text = Globals.gMyProfit.ToString();
        }

        private void m_RichTextBoxMyNetProfit_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxMyNetProfit.Text = Globals.gMyNetProfit.ToString();
        }

        private void m_RichTextBoxMyTotalCost_TextChanged(object sender, EventArgs e)
        {
            m_RichTextBoxMyTotalCost.Text = Globals.gMyTotalCost.ToString();
        }

        private void m_ButtonStart_Click(object sender, EventArgs e)
        {
            m_RichTextBoxTotalBusinessSavings.Text = "0";
            m_RichTextBoxTotalBusinessProfit.Text = "0";
            m_RichTextBoxMyTotalProfit.Text = "0";
            m_RichTextBoxMyNetProfit.Text = "0";

            Calculate calc = new Calculate();

            // If either hours saved or hourly wage is null, we cant calculate total savings, so throw error.
            if(!(Convert.ToInt32(Globals.gProcessCountSmall) == 0 && Convert.ToInt32(Globals.gProcessCountMedium) == 0 && Convert.ToInt32(Globals.gProcessCountLarge) == 0))
            {
                m_RichTextBoxTotalBusinessSavings.Text = Globals.gTotalSavings.ToString();
            }
            else
            {
                MessageBox.Show("Hours saved or Hourly wage was left empty, cannot calculate total savings.", "Error: Cant calculate field");
            }
            
            // If we dont have total savings calculated, we cant calculate the busiess profit
            if(!(Globals.gTotalSavings == null))
            {
                m_RichTextBoxTotalBusinessProfit.Text = Globals.gTotalBusinessProfit.ToString();
            }
            else
            {
                MessageBox.Show("Total savings could not be calculated, cannot calculate total business profit.", "Error: Cant calculate field");
            }

           
            m_RichTextBoxMyTotalProfit.Text = Globals.gMyProfit.ToString();

            m_RichTextBoxMyNetProfit.Text = Globals.gMyNetProfit.ToString();
            
            m_RichTextBoxMyTotalCost.Text = Globals.gMyTotalCost.ToString();
 
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
            if(m_CheckBoxSmall.Checked)
            {
                m_NumericUpDownSmall.Enabled = true;
                m_TextBoxHourlyWageSmall.Enabled = true;
                m_TextBoxHoursSavedSmall.Enabled = true;
            }
            else
            {
                m_NumericUpDownSmall.Value = 0;
                m_NumericUpDownSmall.Enabled = false;

                m_TextBoxHourlyWageSmall.Enabled = false;
                m_TextBoxHoursSavedSmall.Enabled = false;
            }
        }

        private void m_CheckBoxMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxMedium.Checked)
            {
                m_NumericUpDownMedium.Enabled = true;

                m_TextBoxHourlyWageMedium.Enabled = true;
                m_TextBoxHoursSavedMedium.Enabled = true;
            }
            else
            {
                m_NumericUpDownMedium.Value = 0;
                m_NumericUpDownMedium.Enabled = false;

                m_TextBoxHourlyWageMedium.Enabled = false;
                m_TextBoxHoursSavedMedium.Enabled = false;
            }
        }

        private void m_CheckBoxLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxLarge.Checked)
            {
                m_NumericUpDownLarge.Enabled = true;

                m_TextBoxHourlyWageLarge.Enabled = true;
                m_TextBoxHoursSavedLarge.Enabled = true;
            }
            else
            {
                m_NumericUpDownLarge.Value = 0;
                m_NumericUpDownLarge.Enabled = false;

                m_TextBoxHourlyWageLarge.Enabled = false;
                m_TextBoxHoursSavedLarge.Enabled = false;
            }
        }

        private void m_NumericUpDownSmall_ValueChanged(object sender, EventArgs e)
        {
            Globals.gProcessCountSmall = m_NumericUpDownSmall.Value;
        }

        private void m_NumericUpDownMedium_ValueChanged(object sender, EventArgs e)
        {
            Globals.gProcessCountMedium = m_NumericUpDownMedium.Value;
        }

        private void m_NumericUpDownLarge_ValueChanged(object sender, EventArgs e)
        {
            Globals.gProcessCountLarge = m_NumericUpDownLarge.Value;
        }

        private void m_ButtonRPA_Click(object sender, EventArgs e)
        {

        }

        private void m_ButtonScript_Click(object sender, EventArgs e)
        {
                
        }

        private void m_ButtonTool_Click(object sender, EventArgs e)
        {

        }

        private void m_ButtonLogs_Click(object sender, EventArgs e)
        {

        }
    }
}
