using Connection.Not_Mapped;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Connection;
using Microsoft.EntityFrameworkCore;

namespace AngebotenUndRechnungenApp
{
    public partial class Diagrams : Form
    {
        public OfferandinvoicedbContext con = new OfferandinvoicedbContext();
        public Diagrams()
        {
            InitializeComponent();
        }
 

        private void Diagrams_Load(object sender, EventArgs e)
        {
            Chart1Method();
            Chart2Method();
            Chart3Method();
        }
        public void Chart1Method()
        {
            try
            {
                //DateTime dateOfInserted = Convert.ToDateTime( dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                var dateOfInserted = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                var param = new SqlParameter("@insertedDate", dateOfInserted);
                var results = con.Query<GetAllInvoicesPricesVM>().FromSqlRaw("EXEC prc_GetAllInvoicesPricesForMonth @insertedDate", param).ToList();

                chart1.Series["Series1"].Points.Clear();
                chart1.Titles.Clear();

                if (results.Count() == 0)
                {
                    chart1.Series["Series1"].Points.AddXY("Rechnung", 0);
                    chart1.Series["Series1"].Points.AddXY("Price", 0);

                }
                else
                {
                    chart1.Series["Series1"].Points.AddXY("Rechnung", results.First().NumberOfItem.ToString());
                    chart1.Series["Series1"].Points.AddXY("Price", results.Last().Price.ToString());
                }
                chart1.ChartAreas[0].AxisX.Interval = 1;


                Title title = new Title();
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                title.Text = "  Total price of invoices for relevant date";
                title.ForeColor = Color.Black;
                chart1.Titles.Add(title);

                chart1.BackColor = Color.Transparent;
                chart1.ChartAreas[0].BackColor = Color.Transparent;

                // Example custom palette with pastel colors
                chart1.Series["Series1"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
                // Set colors for individual data points
                chart1.Series["Series1"].Points[0].Color = Color.CornflowerBlue;         //CornflowerBlue
                chart1.Series["Series1"].Points[1].Color = Color.FromArgb(168, 228, 160);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Chart1Method();
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged -= dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1_ValueChanged(sender, e);
        }

        public void Chart2Method()
        {
            try
            {
                chart2.Series.Clear();
                chart2.Titles.Clear();
                chart2.Series.Add("Series2");
                var year = dateTimePicker2.Value.ToString("yyyy");
                int convertedYear = Convert.ToInt32(year);
      
                var param4 = new SqlParameter("@year", convertedYear);

                var list = con.Query<GetChart2DataVM>().FromSqlRaw("EXEC prc_GetAllInvoicesTotalPricesForYear @year", param4).ToList();

                int janValue = (int)list.Where(x => x.MonthName == 1).Sum(x => x.Price);
                int febValue = (int)list.Where(x => x.MonthName == 2).Sum(x => x.Price);
                int marValue = (int)list.Where(x => x.MonthName == 3).Sum(x => x.Price);
                int aprValue = (int)list.Where(x => x.MonthName == 4).Sum(x => x.Price);
                int mayValue = (int)list.Where(x => x.MonthName == 5).Sum(x => x.Price);
                int junValue = (int)list.Where(x => x.MonthName == 6).Sum(x => x.Price);
                int julValue = (int)list.Where(x => x.MonthName == 7).Sum(x => x.Price);
                int augValue = (int)list.Where(x => x.MonthName == 8).Sum(x => x.Price);
                int sepValue = (int)list.Where(x => x.MonthName == 9).Sum(x => x.Price);
                int octValue = (int)list.Where(x => x.MonthName == 10).Sum(x => x.Price);
                int novValue = (int)list.Where(x => x.MonthName == 11).Sum(x => x.Price);
                int decValue = (int)list.Where(x => x.MonthName == 12).Sum(x => x.Price);

                Series series = chart2.Series.Add("Total");
                series.ChartType = SeriesChartType.Spline;
                series.Points.AddXY("January", janValue);
                series.Points.AddXY("February", febValue);
                series.Points.AddXY("March", marValue);
                series.Points.AddXY("April", aprValue);
                series.Points.AddXY("May", mayValue);
                series.Points.AddXY("June", junValue);
                series.Points.AddXY("July", julValue);
                series.Points.AddXY("August", augValue);
                series.Points.AddXY("September", sepValue);
                series.Points.AddXY("October", octValue);
                series.Points.AddXY("November", novValue);
                series.Points.AddXY("December", decValue);


                Title title = new Title();
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                title.Text = "Total price of invoices for relevant year and month";
                title.ForeColor = Color.Black;
                chart2.Titles.Add(title);

                chart2.BackColor = Color.Transparent;
                chart2.ChartAreas[0].BackColor = Color.Transparent;
                series.BorderWidth = 3;
                chart2.ChartAreas[0].AxisX.Interval = 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Chart3Method()
        {
            try
            {
                //DateTime dateOfInserted = Convert.ToDateTime( dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                var dateOfInserted = dateTimePicker3.Value.ToString("yyyy-MM-dd");

                var param = new SqlParameter("@insertedDate", dateOfInserted);
                var results = con.Query<GetAllInvoicesPricesVM>().FromSqlRaw("EXEC prc_GetAllOffersPricesForMonth @insertedDate", param).ToList();

                chart3.Series["Series1"].Points.Clear();
                chart3.Titles.Clear();

                if (results.Count() == 0)
                {
                    chart3.Series["Series1"].Points.AddXY("Offers", 0);
                    chart3.Series["Series1"].Points.AddXY("Price", 0);
                }
                else
                {
                    chart3.Series["Series1"].Points.AddXY("Offers", results.First().NumberOfItem.ToString());
                    chart3.Series["Series1"].Points.AddXY("Price", results.Last().Price.ToString());
                }
                chart3.ChartAreas[0].AxisX.Interval = 1;

                Title title = new Title();
                title.Font = new Font("Arial", 14, FontStyle.Bold);
                title.Text = "  Total price of offers for relevant date";
                title.ForeColor = Color.Black;
                chart3.Titles.Add(title);

                chart3.BackColor = Color.Transparent;
                chart3.ChartAreas[0].BackColor = Color.Transparent;
                // Example custom palette with pastel colors
                chart3.Series["Series1"].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
                // Set colors for individual data points
                chart3.Series["Series1"].Points[0].Color = Color.CornflowerBlue;         //CornflowerBlue
                chart3.Series["Series1"].Points[1].Color = Color.FromArgb(168, 228, 160);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Chart2Method();
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            dateTimePicker2_ValueChanged(sender, e);
        }

        private void dateTimePicker2_DropDown(object sender, EventArgs e)
        {
            dateTimePicker2.ValueChanged -= dateTimePicker2_ValueChanged;
        }

        private void dateTimePicker3_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            dateTimePicker3_ValueChanged(sender, e);
        }

        private void dateTimePicker3_DropDown(object sender, EventArgs e)
        {
            dateTimePicker3.ValueChanged -= dateTimePicker3_ValueChanged;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            Chart3Method();
        }
    }
}
