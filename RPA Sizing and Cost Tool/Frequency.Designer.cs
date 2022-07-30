namespace RPA_Sizing_and_Cost_Tool
{
    partial class Frequency
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frequency));
            this.m_TextBoxProcessCount = new System.Windows.Forms.TextBox();
            this.m_TextBoxLicenseCount = new System.Windows.Forms.TextBox();
            this.m_TextBoxHoursSaved = new System.Windows.Forms.TextBox();
            this.m_LabelLicenseCount = new System.Windows.Forms.Label();
            this.m_LabelProcessCount = new System.Windows.Forms.Label();
            this.m_LabelHourSaved = new System.Windows.Forms.Label();
            this.m_TextBoxHourlyWage = new System.Windows.Forms.TextBox();
            this.m_LabelHourlyWage = new System.Windows.Forms.Label();
            this.m_ButtonStart = new System.Windows.Forms.Button();
            this.m_RichTextBoxTotalBusinessSavings = new System.Windows.Forms.TextBox();
            this.m_RichTextBoxTotalBusinessProfit = new System.Windows.Forms.TextBox();
            this.m_RichTextBoxMyTotalProfit = new System.Windows.Forms.TextBox();
            this.m_RichTextBoxMyNetProfit = new System.Windows.Forms.TextBox();
            this.m_LabelTotalBusinessSavings = new System.Windows.Forms.Label();
            this.m_LabelTotalBusinessProfit = new System.Windows.Forms.Label();
            this.m_LabelMyTotalProfit = new System.Windows.Forms.Label();
            this.m_LabelMyTotalNetProfit = new System.Windows.Forms.Label();
            this.m_PanelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_PanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_TextBoxProcessCount
            // 
            this.m_TextBoxProcessCount.Location = new System.Drawing.Point(109, 104);
            this.m_TextBoxProcessCount.Name = "m_TextBoxProcessCount";
            this.m_TextBoxProcessCount.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxProcessCount.TabIndex = 0;
            this.m_TextBoxProcessCount.TextChanged += new System.EventHandler(this.m_TextBoxProcessCount_TextChanged);
            // 
            // m_TextBoxLicenseCount
            // 
            this.m_TextBoxLicenseCount.Location = new System.Drawing.Point(109, 78);
            this.m_TextBoxLicenseCount.Name = "m_TextBoxLicenseCount";
            this.m_TextBoxLicenseCount.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxLicenseCount.TabIndex = 1;
            this.m_TextBoxLicenseCount.TextChanged += new System.EventHandler(this.m_TextBoxLicenseCount_TextChanged);
            // 
            // m_TextBoxHoursSaved
            // 
            this.m_TextBoxHoursSaved.Location = new System.Drawing.Point(109, 130);
            this.m_TextBoxHoursSaved.Name = "m_TextBoxHoursSaved";
            this.m_TextBoxHoursSaved.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxHoursSaved.TabIndex = 4;
            this.m_TextBoxHoursSaved.TextChanged += new System.EventHandler(this.m_TextBoxHoursSaved_TextChanged);
            // 
            // m_LabelLicenseCount
            // 
            this.m_LabelLicenseCount.AutoSize = true;
            this.m_LabelLicenseCount.Location = new System.Drawing.Point(28, 81);
            this.m_LabelLicenseCount.Name = "m_LabelLicenseCount";
            this.m_LabelLicenseCount.Size = new System.Drawing.Size(75, 13);
            this.m_LabelLicenseCount.TabIndex = 5;
            this.m_LabelLicenseCount.Text = "License Count";
            // 
            // m_LabelProcessCount
            // 
            this.m_LabelProcessCount.AutoSize = true;
            this.m_LabelProcessCount.Location = new System.Drawing.Point(27, 107);
            this.m_LabelProcessCount.Name = "m_LabelProcessCount";
            this.m_LabelProcessCount.Size = new System.Drawing.Size(76, 13);
            this.m_LabelProcessCount.TabIndex = 6;
            this.m_LabelProcessCount.Text = "Process Count";
            // 
            // m_LabelHourSaved
            // 
            this.m_LabelHourSaved.AutoSize = true;
            this.m_LabelHourSaved.Location = new System.Drawing.Point(39, 133);
            this.m_LabelHourSaved.Name = "m_LabelHourSaved";
            this.m_LabelHourSaved.Size = new System.Drawing.Size(64, 13);
            this.m_LabelHourSaved.TabIndex = 7;
            this.m_LabelHourSaved.Text = "Hour Saved";
            // 
            // m_TextBoxHourlyWage
            // 
            this.m_TextBoxHourlyWage.Location = new System.Drawing.Point(109, 156);
            this.m_TextBoxHourlyWage.Name = "m_TextBoxHourlyWage";
            this.m_TextBoxHourlyWage.Size = new System.Drawing.Size(100, 20);
            this.m_TextBoxHourlyWage.TabIndex = 8;
            this.m_TextBoxHourlyWage.TextChanged += new System.EventHandler(this.m_TextBoxHourlyWage_TextChanged);
            // 
            // m_LabelHourlyWage
            // 
            this.m_LabelHourlyWage.AutoSize = true;
            this.m_LabelHourlyWage.Location = new System.Drawing.Point(34, 159);
            this.m_LabelHourlyWage.Name = "m_LabelHourlyWage";
            this.m_LabelHourlyWage.Size = new System.Drawing.Size(69, 13);
            this.m_LabelHourlyWage.TabIndex = 9;
            this.m_LabelHourlyWage.Text = "Hourly Wage";
            // 
            // m_ButtonStart
            // 
            this.m_ButtonStart.Location = new System.Drawing.Point(362, 415);
            this.m_ButtonStart.Name = "m_ButtonStart";
            this.m_ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.m_ButtonStart.TabIndex = 11;
            this.m_ButtonStart.Text = "Process";
            this.m_ButtonStart.UseVisualStyleBackColor = true;
            this.m_ButtonStart.Click += new System.EventHandler(this.m_ButtonStart_Click);
            // 
            // m_RichTextBoxTotalBusinessSavings
            // 
            this.m_RichTextBoxTotalBusinessSavings.Location = new System.Drawing.Point(564, 78);
            this.m_RichTextBoxTotalBusinessSavings.Name = "m_RichTextBoxTotalBusinessSavings";
            this.m_RichTextBoxTotalBusinessSavings.Size = new System.Drawing.Size(100, 20);
            this.m_RichTextBoxTotalBusinessSavings.TabIndex = 12;
            this.m_RichTextBoxTotalBusinessSavings.TextChanged += new System.EventHandler(this.m_RichTextBoxTotalBusinessSavings_TextChanged);
            // 
            // m_RichTextBoxTotalBusinessProfit
            // 
            this.m_RichTextBoxTotalBusinessProfit.Location = new System.Drawing.Point(564, 104);
            this.m_RichTextBoxTotalBusinessProfit.Name = "m_RichTextBoxTotalBusinessProfit";
            this.m_RichTextBoxTotalBusinessProfit.Size = new System.Drawing.Size(100, 20);
            this.m_RichTextBoxTotalBusinessProfit.TabIndex = 13;
            this.m_RichTextBoxTotalBusinessProfit.TextChanged += new System.EventHandler(this.m_RichTextBoxTotalBusinessProfit_TextChanged);
            // 
            // m_RichTextBoxMyTotalProfit
            // 
            this.m_RichTextBoxMyTotalProfit.Location = new System.Drawing.Point(564, 130);
            this.m_RichTextBoxMyTotalProfit.Name = "m_RichTextBoxMyTotalProfit";
            this.m_RichTextBoxMyTotalProfit.Size = new System.Drawing.Size(100, 20);
            this.m_RichTextBoxMyTotalProfit.TabIndex = 14;
            this.m_RichTextBoxMyTotalProfit.TextChanged += new System.EventHandler(this.m_RichTextBoxMyTotalProfit_TextChanged);
            // 
            // m_RichTextBoxMyNetProfit
            // 
            this.m_RichTextBoxMyNetProfit.Location = new System.Drawing.Point(564, 156);
            this.m_RichTextBoxMyNetProfit.Name = "m_RichTextBoxMyNetProfit";
            this.m_RichTextBoxMyNetProfit.Size = new System.Drawing.Size(100, 20);
            this.m_RichTextBoxMyNetProfit.TabIndex = 15;
            this.m_RichTextBoxMyNetProfit.TextChanged += new System.EventHandler(this.m_RichTextBoxMyNetProfit_TextChanged);
            // 
            // m_LabelTotalBusinessSavings
            // 
            this.m_LabelTotalBusinessSavings.AutoSize = true;
            this.m_LabelTotalBusinessSavings.Location = new System.Drawing.Point(441, 81);
            this.m_LabelTotalBusinessSavings.Name = "m_LabelTotalBusinessSavings";
            this.m_LabelTotalBusinessSavings.Size = new System.Drawing.Size(117, 13);
            this.m_LabelTotalBusinessSavings.TabIndex = 16;
            this.m_LabelTotalBusinessSavings.Text = "Total Business Savings";
            // 
            // m_LabelTotalBusinessProfit
            // 
            this.m_LabelTotalBusinessProfit.AutoSize = true;
            this.m_LabelTotalBusinessProfit.Location = new System.Drawing.Point(455, 107);
            this.m_LabelTotalBusinessProfit.Name = "m_LabelTotalBusinessProfit";
            this.m_LabelTotalBusinessProfit.Size = new System.Drawing.Size(103, 13);
            this.m_LabelTotalBusinessProfit.TabIndex = 17;
            this.m_LabelTotalBusinessProfit.Text = "Total Business Profit";
            // 
            // m_LabelMyTotalProfit
            // 
            this.m_LabelMyTotalProfit.AutoSize = true;
            this.m_LabelMyTotalProfit.Location = new System.Drawing.Point(483, 133);
            this.m_LabelMyTotalProfit.Name = "m_LabelMyTotalProfit";
            this.m_LabelMyTotalProfit.Size = new System.Drawing.Size(75, 13);
            this.m_LabelMyTotalProfit.TabIndex = 18;
            this.m_LabelMyTotalProfit.Text = "My Total Profit";
            // 
            // m_LabelMyTotalNetProfit
            // 
            this.m_LabelMyTotalNetProfit.AutoSize = true;
            this.m_LabelMyTotalNetProfit.Location = new System.Drawing.Point(463, 159);
            this.m_LabelMyTotalNetProfit.Name = "m_LabelMyTotalNetProfit";
            this.m_LabelMyTotalNetProfit.Size = new System.Drawing.Size(95, 13);
            this.m_LabelMyTotalNetProfit.TabIndex = 19;
            this.m_LabelMyTotalNetProfit.Text = "My Total Net Profit";
            // 
            // m_PanelTitleBar
            // 
            this.m_PanelTitleBar.BackColor = System.Drawing.Color.Black;
            this.m_PanelTitleBar.Controls.Add(this.label1);
            this.m_PanelTitleBar.Controls.Add(this.pictureBox1);
            this.m_PanelTitleBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_PanelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.m_PanelTitleBar.Name = "m_PanelTitleBar";
            this.m_PanelTitleBar.Size = new System.Drawing.Size(800, 45);
            this.m_PanelTitleBar.TabIndex = 20;
            this.m_PanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseDown);
            this.m_PanelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseMove);
            this.m_PanelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m_PanelTitleBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Frequency Tool";
            // 
            // Frequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_PanelTitleBar);
            this.Controls.Add(this.m_LabelMyTotalNetProfit);
            this.Controls.Add(this.m_LabelMyTotalProfit);
            this.Controls.Add(this.m_LabelTotalBusinessProfit);
            this.Controls.Add(this.m_LabelTotalBusinessSavings);
            this.Controls.Add(this.m_RichTextBoxMyNetProfit);
            this.Controls.Add(this.m_RichTextBoxMyTotalProfit);
            this.Controls.Add(this.m_RichTextBoxTotalBusinessProfit);
            this.Controls.Add(this.m_RichTextBoxTotalBusinessSavings);
            this.Controls.Add(this.m_ButtonStart);
            this.Controls.Add(this.m_LabelHourlyWage);
            this.Controls.Add(this.m_TextBoxHourlyWage);
            this.Controls.Add(this.m_LabelHourSaved);
            this.Controls.Add(this.m_LabelProcessCount);
            this.Controls.Add(this.m_LabelLicenseCount);
            this.Controls.Add(this.m_TextBoxHoursSaved);
            this.Controls.Add(this.m_TextBoxLicenseCount);
            this.Controls.Add(this.m_TextBoxProcessCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frequency";
            this.Text = "Frequency";
            this.m_PanelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_TextBoxProcessCount;
        private System.Windows.Forms.TextBox m_TextBoxLicenseCount;
        private System.Windows.Forms.TextBox m_TextBoxHoursSaved;
        private System.Windows.Forms.Label m_LabelLicenseCount;
        private System.Windows.Forms.Label m_LabelProcessCount;
        private System.Windows.Forms.Label m_LabelHourSaved;
        private System.Windows.Forms.TextBox m_TextBoxHourlyWage;
        private System.Windows.Forms.Label m_LabelHourlyWage;
        private System.Windows.Forms.Button m_ButtonStart;
        private System.Windows.Forms.TextBox m_RichTextBoxTotalBusinessSavings;
        private System.Windows.Forms.TextBox m_RichTextBoxTotalBusinessProfit;
        private System.Windows.Forms.TextBox m_RichTextBoxMyTotalProfit;
        private System.Windows.Forms.TextBox m_RichTextBoxMyNetProfit;
        private System.Windows.Forms.Label m_LabelTotalBusinessSavings;
        private System.Windows.Forms.Label m_LabelTotalBusinessProfit;
        private System.Windows.Forms.Label m_LabelMyTotalProfit;
        private System.Windows.Forms.Label m_LabelMyTotalNetProfit;
        private System.Windows.Forms.Panel m_PanelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

