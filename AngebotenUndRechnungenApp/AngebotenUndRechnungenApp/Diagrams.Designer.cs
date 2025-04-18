
namespace AngebotenUndRechnungenApp
{
    partial class Diagrams
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagrams));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker1.TabIndex = 85;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(27, 68);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(371, 229);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(27, 354);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker2.TabIndex = 87;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.DropDown += new System.EventHandler(this.dateTimePicker2_DropDown);
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
            this.chart2.Location = new System.Drawing.Point(27, 391);
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
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date";
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(561, 68);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(371, 229);
            this.chart3.TabIndex = 8;
            this.chart3.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(561, 36);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker3.TabIndex = 86;
            this.dateTimePicker3.CloseUp += new System.EventHandler(this.dateTimePicker3_CloseUp);
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.dateTimePicker3.DropDown += new System.EventHandler(this.dateTimePicker3_DropDown);
            // 
            // Diagrams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 773);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diagrams";
            this.Text = "Diagrams";
            this.Load += new System.EventHandler(this.Diagrams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
    }
}