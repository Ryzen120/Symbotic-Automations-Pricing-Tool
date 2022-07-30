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

        private Point gStartLocation;

        private bool gDragging;

        private int[] gStartPoint;

        private int gLicenseCount;
        private int gProcessCount;
        private double gHoursSaved;
        private double gHourlyWage;
        private double gTotalSavings;


        public Frequency()
        {
            InitializeComponent();

            gStartPoint = new int[2];
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
    }
}
