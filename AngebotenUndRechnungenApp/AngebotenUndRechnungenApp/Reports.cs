using Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Connection.Not_Mapped;

namespace AngebotenUndRechnungenApp
{
    public partial class Reports : Form
    {
        public OfferandinvoicedbContext con = new OfferandinvoicedbContext();
        public Reports()
        {
            InitializeComponent();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
            FillReportType();
            FillCustomers();
            dgvReports.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen;
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReports.ColumnHeadersHeight = 40;
            //GetAllDataForCustomers();
            SearchWithFilter();
        }

        public void FillReportType()
        {
            try
            {
                var lista = con.TypeOfReport.ToList();
                cboChooseTypeReport.DataSource = lista;
                cboChooseTypeReport.DisplayMember = "Type";
                cboChooseTypeReport.ValueMember = "ID";

                if ((cboChooseTypeReport.SelectedIndex = -1) != 0)
                {
                    cboChooseTypeReport.Text = @"Choose...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillCustomers()
        {
            try
            {
                var lista = con.Customers.ToList();
                cboChooseClient.DataSource = lista;
                cboChooseClient.DisplayMember = "CustomerName";
                cboChooseClient.ValueMember = "ID";

                if ((cboChooseClient.SelectedIndex = -1) != 0)
                {
                    cboChooseClient.Text = @"Choose...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetAllDataForCustomers()
        {
            var list = con.Query<GenerateReportForCustomerVM>().FromSqlRaw("EXEC prc_GetAllDataForCustomers").ToList();

            dgvReports.DataSource = null;
            dgvReports.DataSource = list;
        }
       public void SearchWithFilter()
        {
            try
            {
                var typeOfReport = cboChooseTypeReport.GetItemText(this.cboChooseTypeReport.SelectedItem);
                var customer = cboChooseClient.GetItemText(this.cboChooseClient.SelectedItem);

                if (typeOfReport == null || typeOfReport == "")
                {
                    typeOfReport = "_";
                }
                if (customer == null || customer == "")
                {
                    customer = "_";
                }
                var param1 = new SqlParameter("@typeOfReport", typeOfReport);
                var param2 = new SqlParameter("@customer", customer);

                var list = con.Query<GenerateReportForCustomerVM>().FromSqlRaw("EXEC prc_FilterDataByReportAndCustomer @typeOfReport, @customer", param1, param2).ToList();

                dgvReports.DataSource = null;
                dgvReports.DataSource = list;
                dgvReports.Columns["ID"].Visible = false;
                dgvReports.Columns["CustomerName"].HeaderText = "Customer Name";
                dgvReports.Columns["ProjectName"].HeaderText = "Project Name";
                dgvReports.Columns["CleaningLocation"].HeaderText = "Cleaning Location";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboChooseTypeReport_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SearchWithFilter();
        }

        private void cboChooseClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SearchWithFilter();
        }

        private void cboChooseTypeReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboChooseClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            cboChooseTypeReport.SelectedIndex = -1;
            if ((cboChooseTypeReport.SelectedIndex = -1) != 0)
            {
                cboChooseTypeReport.Text = @"Choose...";
            }
            cboChooseClient.SelectedIndex = -1;
            if ((cboChooseClient.SelectedIndex = -1) != 0)
            {
                cboChooseClient.Text = @"Choose...";
            }
            txtCellSelected.Text = "";
            SearchWithFilter();

            Cursor = Cursors.Default;
        }

        private void btnGenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (txtCellSelected.Text == "")
                {
                    MessageBox.Show(@"Please select the client that you want to generate report", @"Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var projectId = Convert.ToInt32(txtCellSelected.Text);
                    GenerateReport obj = new GenerateReport(projectId);
                    obj.Show();
                }

                Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    DataGridViewRow row = dgvReports.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtCellSelected.Text = val;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
