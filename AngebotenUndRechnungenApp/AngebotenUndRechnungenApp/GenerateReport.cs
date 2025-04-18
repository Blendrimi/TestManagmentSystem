using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;
using Microsoft.Reporting.WinForms;
using Microsoft.Data.SqlClient;
using Connection.Not_Mapped;
using Microsoft.EntityFrameworkCore;


namespace AngebotenUndRechnungenApp
{
    public partial class GenerateReport : Form
    {
        public OfferandinvoicedbContext con = new OfferandinvoicedbContext();
        int projectDetailsId;
        public GenerateReport(int projectId)
        {
            InitializeComponent();
            this.projectDetailsId = projectId;

        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
          
            var param1 = new SqlParameter("@projectId", projectDetailsId);

            var headerList = con.Query<CustomerInfoVM>().FromSqlRaw("EXEC prc_GetCustomerInfo @projectId", param1).ToList();
            var projectDetailsList = con.Query<GetProjectDetailsVM>().FromSqlRaw("EXEC prc_GetProjectDetails @projectId", param1).ToList();
            var serviceAndDescriptionList = con.Query<GetServicesWithDescriptionVM>().FromSqlRaw("EXEC prc_GetServicesWithDescription @projectId", param1).ToList();
            var totalOfAllServices = con.Query<GetServicesWithDescriptionVM>().FromSqlRaw("EXEC prc_TotalOfAallServices @projectId", param1).ToList();
            var footerList = con.Query<GetServicesWithDescriptionVM>().FromSqlRaw("EXEC prc_GetFooterInfo @projectId", param1).ToList();



            var rps1 = new ReportDataSource("GetCustomerInfo", headerList);
            var rps2 = new ReportDataSource("GetProjectDetails", projectDetailsList);
            var rps3 = new ReportDataSource("GetServicesWithDescription", serviceAndDescriptionList);
            var rps4 = new ReportDataSource("TotalOfAallServices", totalOfAllServices);
            var rps5 = new ReportDataSource("GetFooterInfo", footerList);



            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rps1);
            reportViewer1.LocalReport.DataSources.Add(rps2);
            reportViewer1.LocalReport.DataSources.Add(rps3);
            reportViewer1.LocalReport.DataSources.Add(rps4);
            reportViewer1.LocalReport.DataSources.Add(rps5);


            this.reportViewer1.RefreshReport();

            try
            {
                int typeOfReportId = (int)con.ProjectDetails.Where(x => x.Id == projectDetailsId).Select(x => x.TypeOfReportId).SingleOrDefault();
                int customerId = (int)con.ProjectDetails.Where(x => x.Id == projectDetailsId).Select(x => x.ClientsId).SingleOrDefault();

                var typeOfReport = con.TypeOfReport.Where(x => x.Id == typeOfReportId).Select(x => x.Type).SingleOrDefault();
                var customerName = con.Customers.Where(x => x.Id == customerId).Select(x => x.CustomerName).SingleOrDefault();

                reportViewer1.LocalReport.DisplayName = typeOfReport + "_" + customerName;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
