namespace Covid_19_Simulation
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.negativeTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addInfectedPeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSocialDistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_InfectedPercentage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // negativeTimer
            // 
            this.negativeTimer.Tick += new System.EventHandler(this.negativeTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1120, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPeopleToolStripMenuItem,
            this.addInfectedPeopleToolStripMenuItem,
            this.addSocialDistanceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addPeopleToolStripMenuItem
            // 
            this.addPeopleToolStripMenuItem.Name = "addPeopleToolStripMenuItem";
            this.addPeopleToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.addPeopleToolStripMenuItem.Text = "Add Population";
            this.addPeopleToolStripMenuItem.Click += new System.EventHandler(this.addPeopleToolStripMenuItem_Click);
            // 
            // addInfectedPeopleToolStripMenuItem
            // 
            this.addInfectedPeopleToolStripMenuItem.Name = "addInfectedPeopleToolStripMenuItem";
            this.addInfectedPeopleToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.addInfectedPeopleToolStripMenuItem.Text = "Add Infected People";
            this.addInfectedPeopleToolStripMenuItem.Click += new System.EventHandler(this.addInfectedPeopleToolStripMenuItem_Click);
            // 
            // addSocialDistanceToolStripMenuItem
            // 
            this.addSocialDistanceToolStripMenuItem.Name = "addSocialDistanceToolStripMenuItem";
            this.addSocialDistanceToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.addSocialDistanceToolStripMenuItem.Text = "Add Social Distance";
            this.addSocialDistanceToolStripMenuItem.Click += new System.EventHandler(this.addSocialDistanceToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 363);
            this.panel1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea4.AxisX.Title = "Time";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.Title = "Population";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 32);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series13.BorderWidth = 2;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Color = System.Drawing.Color.Gray;
            series13.Legend = "Legend1";
            series13.Name = "Normal";
            series13.YValuesPerPoint = 2;
            series14.BorderWidth = 2;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Color = System.Drawing.Color.Red;
            series14.Legend = "Legend1";
            series14.Name = "Infected";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Color = System.Drawing.Color.Orange;
            series15.Legend = "Legend1";
            series15.Name = "Recovered";
            series16.BorderWidth = 2;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Color = System.Drawing.Color.Black;
            series16.Legend = "Legend1";
            series16.Name = "Dead";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Series.Add(series16);
            this.chart1.Size = new System.Drawing.Size(1120, 392);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 10;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // lbl_InfectedPercentage
            // 
            this.lbl_InfectedPercentage.AutoSize = true;
            this.lbl_InfectedPercentage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InfectedPercentage.ForeColor = System.Drawing.Color.Red;
            this.lbl_InfectedPercentage.Location = new System.Drawing.Point(409, 438);
            this.lbl_InfectedPercentage.Name = "lbl_InfectedPercentage";
            this.lbl_InfectedPercentage.Size = new System.Drawing.Size(230, 26);
            this.lbl_InfectedPercentage.TabIndex = 9;
            this.lbl_InfectedPercentage.Text = "Infection percentage:";
            this.lbl_InfectedPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 902);
            this.Controls.Add(this.lbl_InfectedPercentage);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVID-19";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer negativeTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPeopleToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem addInfectedPeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSocialDistanceToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label lbl_InfectedPercentage;
    }
}

