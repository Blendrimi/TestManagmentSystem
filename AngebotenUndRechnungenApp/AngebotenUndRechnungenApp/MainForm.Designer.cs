
namespace AngebotenUndRechnungenApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnAddNewService = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnProjectDetails = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMainForm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 85);
            this.panel1.TabIndex = 0;
            // 
            // btnMainForm
            // 
            this.btnMainForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainForm.BackgroundImage")));
            this.btnMainForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainForm.FlatAppearance.BorderSize = 0;
            this.btnMainForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainForm.Location = new System.Drawing.Point(1, 0);
            this.btnMainForm.Name = "btnMainForm";
            this.btnMainForm.Size = new System.Drawing.Size(188, 85);
            this.btnMainForm.TabIndex = 80;
            this.btnMainForm.UseVisualStyleBackColor = true;
            this.btnMainForm.Click += new System.EventHandler(this.btnMainForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(421, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "System for generating offers and invoices";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnAddNewService);
            this.panel2.Controls.Add(this.btnReports);
            this.panel2.Controls.Add(this.btnProjectDetails);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 796);
            this.panel2.TabIndex = 1;
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Image = global::AngebotenUndRechnungenApp.Properties.Resources.icons8_users_48;
            this.btnCustomers.Location = new System.Drawing.Point(3, 19);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(183, 85);
            this.btnCustomers.TabIndex = 81;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnAddNewService
            // 
            this.btnAddNewService.FlatAppearance.BorderSize = 0;
            this.btnAddNewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewService.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewService.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewService.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewService.Image")));
            this.btnAddNewService.Location = new System.Drawing.Point(3, 119);
            this.btnAddNewService.Name = "btnAddNewService";
            this.btnAddNewService.Size = new System.Drawing.Size(183, 96);
            this.btnAddNewService.TabIndex = 82;
            this.btnAddNewService.Text = "Add New Service";
            this.btnAddNewService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddNewService.UseVisualStyleBackColor = true;
            this.btnAddNewService.Click += new System.EventHandler(this.btnAddNewService_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Location = new System.Drawing.Point(1, 382);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(185, 114);
            this.btnReports.TabIndex = 84;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnProjectDetails
            // 
            this.btnProjectDetails.FlatAppearance.BorderSize = 0;
            this.btnProjectDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectDetails.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectDetails.Image")));
            this.btnProjectDetails.Location = new System.Drawing.Point(1, 236);
            this.btnProjectDetails.Name = "btnProjectDetails";
            this.btnProjectDetails.Size = new System.Drawing.Size(185, 121);
            this.btnProjectDetails.TabIndex = 83;
            this.btnProjectDetails.Text = "Project Details";
            this.btnProjectDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProjectDetails.UseVisualStyleBackColor = true;
            this.btnProjectDetails.Click += new System.EventHandler(this.btnProjectDetails_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dateTimePicker3);
            this.panel4.Controls.Add(this.chart3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Controls.Add(this.dateTimePicker2);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Location = new System.Drawing.Point(189, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1148, 796);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(530, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(531, 37);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker3.TabIndex = 86;
            this.dateTimePicker3.CloseUp += new System.EventHandler(this.dateTimePicker3_CloseUp);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.dateTimePicker3.DropDown += new System.EventHandler(this.dateTimePicker3_DropDown);
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(532, 63);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(371, 235);
            this.chart3.TabIndex = 11;
            this.chart3.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisX.LineColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.AxisX.MajorGrid.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Mistral", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.CornflowerBlue;
            chartArea2.AxisX2.IsLabelAutoFit = false;
            chartArea2.AxisX2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisX2.LineColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisX2.LineWidth = 2;
            chartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisX2.MajorGrid.LineWidth = 2;
            chartArea2.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisX2.ScaleBreakStyle.LineColor = System.Drawing.Color.Orange;
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.CornflowerBlue;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisY.LineColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightSteelBlue;
            chartArea2.AxisY.MajorGrid.LineWidth = 2;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Orange;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.CornflowerBlue;
            chartArea2.AxisY2.IsLabelAutoFit = false;
            chartArea2.AxisY2.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisY2.LineColor = System.Drawing.Color.RoyalBlue;
            chartArea2.AxisY2.LineWidth = 2;
            chartArea2.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY2.MajorGrid.LineWidth = 2;
            chartArea2.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Blue;
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.CornflowerBlue;
            chartArea2.BorderColor = System.Drawing.Color.Orange;
            chartArea2.CursorX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            chartArea2.CursorX.LineWidth = 2;
            chartArea2.CursorY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            chartArea2.CursorY.LineWidth = 2;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Orange;
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(27, 375);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(228)))), ((int)(((byte)(160)))));
            series2.Name = "Series2";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1097, 370);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(27, 349);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker2.TabIndex = 87;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.DropDown += new System.EventHandler(this.dateTimePicker2_DropDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 63);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(371, 229);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1338, 881);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnProjectDetails;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddNewService;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnMainForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}

