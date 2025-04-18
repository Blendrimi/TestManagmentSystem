using Connection;
using Connection.Not_Mapped;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngebotenUndRechnungenApp
{
    public partial class ProjectDetailsAndServices : Form
    {
        public OfferandinvoicedbContext con = new OfferandinvoicedbContext();
        public ProjectDetailsAndServices()
        {
            InitializeComponent();
        }

        private void ProjectDetailsAndServices_Load(object sender, EventArgs e)
        {
            dgvProjectDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen;
            dgvProjectDetails.EnableHeadersVisualStyles = false;
            dgvProjectDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProjectDetails.ColumnHeadersHeight = 40;

            dgvServices.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen;
            dgvServices.EnableHeadersVisualStyles = false;
            dgvServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvServices.ColumnHeadersHeight = 40;

            tbControls.SelectedTab = tbControls.TabPages[1];
            tbControls.SelectedTab = tbControls.TabPages[0];
            tbControls.TabPages[1].Enabled = false;
            LoadProjectDetils();
            //LoadServices();       
        }
        private void AdjustColumnInProjectDetails()
        {
            try
            {
                dgvProjectDetails.Columns["ID"].Visible = false;
                dgvProjectDetails.Columns["ClientsId"].Visible = false;
                dgvProjectDetails.Columns["TypeOfReportId"].Visible = false;
                dgvProjectDetails.Columns["CustomerName"].HeaderText = "Customer Name";
                dgvProjectDetails.Columns["ProjectName"].HeaderText = "Project Name";
                dgvProjectDetails.Columns["NoOfReferenceOrInvoice"].HeaderText = "No of Reference or Invoice";
                dgvProjectDetails.Columns["CleaningLocation"].HeaderText = "Cleaning Location";  
                dgvProjectDetails.Columns["InsertedDate"].HeaderText = "Inserted Date";
                dgvProjectDetails.Columns["InsertedDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdjustColumnInService() 
        {
            try
            {
                dgvServices.Columns["ID"].Visible = false;
                dgvServices.Columns["ServiceID"].Visible = false;
                dgvServices.Columns["ServiceName"].HeaderText = "Service Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbControls.SelectedTab == tbControls.TabPages[0])
            {
                FillReportType(); 
                FillCustomers();
                ClearFieldsProjectDetails();
                tbControls.TabPages[1].Enabled = false;
                dgvServices.DataSource = null;

            }
            if (tbControls.SelectedTab == tbControls.TabPages[1])
            {
                FillServices();
                txtCellSelectedFromProjectDetails.Text = txtCellSelectedProjectDetails.Text;
                ClearFieldsService();
            }
        }
        private void btnAddProjectDetails_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string cellId = txtCellSelectedProjectDetails.Text;
                if (cellId == "")
                {
                    if (cboChooseTypeReport.SelectedIndex == -1 || cboChooseClient.SelectedIndex == -1 )
                    {
                        MessageBox.Show(@"Please choose the report type or customer's name", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var obj = new ProjectDetails();
                        obj.TypeOfReportId = Convert.ToInt32(cboChooseTypeReport.SelectedValue);
                        obj.ClientsId = Convert.ToInt32(cboChooseClient.SelectedValue);            
                        obj.ProjectName = txtProjectName.Text;
                        obj.Builder = txtBuilder.Text;
                        obj.NoOfReferenceOrInvoice = txtNoReferenceOrInvoice.Text;
                        obj.CleaningLocation = txtCleaningLocation.Text;
                        obj.InsertedDate = DateTime.Today;
                        con.ProjectDetails.Add(obj);
                        con.SaveChanges();                        
                        MessageBox.Show("The data has been inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProjectDetils();
                    }
                }
                else
                {
                    MessageBox.Show(@"First clear and then save a new one", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFieldsProjectDetails();
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadProjectDetils()
        {
            try
            {
                List<ProjectDetailsVM> listaVm = new List<ProjectDetailsVM>();
                //var lista = con.ProjectDetails.ToList().OrderByDescending(x => x.Id);
                var lista = con.ProjectDetails.OrderByDescending(x => x.Id).ToList();


                foreach (var item in lista)
                {
                    var objVM = new ProjectDetailsVM();
                    objVM.ID = item.Id;
                    objVM.TypeOfReportId = Convert.ToInt32(item.TypeOfReportId);
                    objVM.ClientsID = Convert.ToInt32(item.ClientsId);
                    objVM.Type = item.TypeOfReport.Type;
                    objVM.CustomerName = item.Clients.CustomerName;
                    objVM.ProjectName = item.ProjectName;
                    objVM.Builder = item.Builder;
                    objVM.NoOfReferenceOrInvoice = item.NoOfReferenceOrInvoice;
                    objVM.CleaningLocation = item.CleaningLocation;
                    objVM.InsertedDate = item.InsertedDate;

                    listaVm.Add(objVM);
                }
                dgvProjectDetails.DataSource = listaVm;
                foreach (DataGridViewColumn col in dgvProjectDetails.Columns)
                {
                    col.DisplayIndex = col.Index;
                }
                AdjustColumnInProjectDetails();
                ClearFieldsProjectDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadServices(int projectDetailsId)
        {
            var param = new SqlParameter("@projectDetailsId", projectDetailsId);
            var services = con.Query<ServiceVM>().FromSqlRaw("EXEC prc_GetServicesForProjectId @projectDetailsId", param).ToList();
            dgvServices.DataSource = null;
            dgvServices.DataSource = services;
            AdjustColumnInService();
            ClearFieldsService();
        }
        public void ClearFieldsProjectDetails()
        {           
            txtProjectName.Text = "";
            txtBuilder.Text = "";
            txtNoReferenceOrInvoice.Text = "";
            txtCleaningLocation.Text = "";
            txtCellSelectedProjectDetails.Text = "";
            lblClient.Text = "";

            cboChooseClient.SelectedIndex = -1;
            if ((cboChooseClient.SelectedIndex = -1) != 0)
            {
                cboChooseClient.Text = @"Choose...";
            }

            cboChooseTypeReport.SelectedIndex = -1;
            if ((cboChooseTypeReport.SelectedIndex = -1) != 0)
            {
                cboChooseTypeReport.Text = @"Choose...";
            }
        }
        public void ClearFieldsService()
        {
            txtServiceDescription.Text = "";
            txtPrice.Text = "";
            txtCellSelectedServices.Text = "";

            cboChooseService.SelectedIndex = -1;
            if ((cboChooseService.SelectedIndex = -1) != 0)
            {
                cboChooseService.Text = @"Choose...";
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
        public void FillServices()
        {
            try
            {
                var lista = con.Services.ToList();
                cboChooseService.DataSource = lista;
                cboChooseService.DisplayMember = "ServiceName";
                cboChooseService.ValueMember = "ID";

                if ((cboChooseService.SelectedIndex = -1) != 0)
                {
                    cboChooseService.Text = @"Choose...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void cboChooseClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboChooseService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cboTypeReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dgvProjectDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    DataGridViewRow row = dgvProjectDetails.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtCellSelectedProjectDetails.Text = val;         
                    txtProjectName.Text = row.Cells[3].Value.ToString();
                    txtBuilder.Text = row.Cells[4].Value.ToString();
                    txtNoReferenceOrInvoice.Text = row.Cells[5].Value.ToString();
                    txtCleaningLocation.Text = row.Cells[6].Value.ToString();
                    //txtCleaningLocation.Text = row.Cells[7].Value.ToString();
                    cboChooseClient.SelectedValue = Convert.ToInt32(row.Cells[8].Value.ToString());
                    cboChooseTypeReport.SelectedValue = Convert.ToInt32(row.Cells[9].Value.ToString());
                    //lblClient.Text= Convert.ToInt32(cboChooseClient.SelectedValue);

                    // Extract the value from the cell
                    int selectedValue = Convert.ToInt32(row.Cells[8].Value.ToString());

                    // Assign the value to the ComboBox
                    cboChooseClient.SelectedValue = selectedValue;

                    // Find the item in the ComboBox items collection that matches the selected value
                    foreach (var item in cboChooseClient.Items)
                    {
                        var customer = item as Connection.Customers;
                        if (customer != null && customer.Id == selectedValue)
                        {
                            // Assign the corresponding text to the label
                            lblClient.Text = customer.CustomerName; // Replace "Name" with the actual property containing the text
                            break;
                        }
                    }





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       

        private void btnClearService_Click(object sender, EventArgs e)
        {
            ClearFieldsService();
        }

        private void btnClearProjectDetails_Click(object sender, EventArgs e)
        {
            ClearFieldsProjectDetails();
        }

        private void btnUpdateProjectDetails_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string cellId = txtCellSelectedProjectDetails.Text;
            if (cellId != "")
            {
                if (cboChooseTypeReport.SelectedIndex == -1 || cboChooseClient.SelectedIndex == -1)
                {
                    MessageBox.Show(@"Please choose the report type or customer's name", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int ConvetCellId = Convert.ToInt32(txtCellSelectedProjectDetails.Text);
                        var customer = con.ProjectDetails.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                        customer.TypeOfReportId = Convert.ToInt32(cboChooseTypeReport.SelectedValue);
                        customer.ClientsId = Convert.ToInt32(cboChooseClient.SelectedValue);
                        customer.ProjectName = txtProjectName.Text;
                        customer.Builder = txtBuilder.Text;
                        customer.NoOfReferenceOrInvoice = txtNoReferenceOrInvoice.Text;
                        customer.CleaningLocation = txtCleaningLocation.Text;
                        con.SaveChanges();
                        MessageBox.Show("The data has been changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProjectDetils();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please select the row you would like to change", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }

        private void btnDeleteProjectDetails_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string cellId = txtCellSelectedProjectDetails.Text;
            if (cellId != "")
            {
                int ConvetCellId = Convert.ToInt32(txtCellSelectedProjectDetails.Text);
                var checkInAddServices = con.AddServices.Where(x => x.ProjectDetailsId == ConvetCellId).Count();
                if (checkInAddServices != 0)
                {
                    MessageBox.Show(@"You cannot delete this project because there are added services about it!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFieldsProjectDetails();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            var customer = con.ProjectDetails.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                            con.ProjectDetails.Remove(customer);
                            con.SaveChanges();
                            MessageBox.Show("The client was successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            int countCustomer = con.Customers.Count();
                            if (countCustomer > 0)
                            {
                                LoadProjectDetils();
                            }
                            else
                            {
                                List<ProjectDetails> lista = new List<ProjectDetails>();
                                dgvProjectDetails.DataSource = lista;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }             
            }
            else
            {
                MessageBox.Show(@"Please select the row you would like to change", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, " ^ [0 - 9]"))
            {
                txtPrice.Text = "";
            }
        }

        private void cboChooseService_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var serviceId = Convert.ToInt32(cboChooseService.SelectedValue);
            var descriptionOfService = con.ServiceDescription.Where(x => x.ServiceId == serviceId).Select(x => x.Description).SingleOrDefault();
            txtServiceDescription.Text = descriptionOfService;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string cellId = txtCellSelectedServices.Text;
                if (cellId == "")
                {
                    if (cboChooseService.SelectedIndex == -1 || txtPrice.Text=="")
                    {
                        MessageBox.Show(@"Please choose the service and Price value!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var serviceId = Convert.ToInt32(cboChooseService.SelectedValue);
                        int descriptionId = con.ServiceDescription.Where(x => x.ServiceId == serviceId).Select(x => x.Id).SingleOrDefault();

                        var obj = new AddServices();
                        obj.ProjectDetailsId = Convert.ToInt32(txtCellSelectedFromProjectDetails.Text);
                        obj.ServiceDescriptionId = descriptionId;
                        obj.Price = Convert.ToDecimal(txtPrice.Text);                     
                        con.AddServices.Add(obj);
                        con.SaveChanges();                     
                        MessageBox.Show("The data has been inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServices((int)obj.ProjectDetailsId);
                    }
                }
                else
                {
                    MessageBox.Show(@"First clear and then save a new one", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFieldsService();
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string cellId = txtCellSelectedServices.Text;
            if (cellId != "")
            {
                if (cboChooseService.SelectedIndex == -1)
                {
                    MessageBox.Show(@"Please choose the service!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int ConvetCellId = Convert.ToInt32(txtCellSelectedServices.Text);
                        var serviceId = Convert.ToInt32(cboChooseService.SelectedValue);
                        int descriptionId = con.ServiceDescription.Where(x => x.ServiceId == serviceId).Select(x => x.Id).SingleOrDefault();
                        var customer = con.AddServices.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                        customer.ProjectDetailsId = Convert.ToInt32(txtCellSelectedFromProjectDetails.Text);
                        customer.ServiceDescriptionId = descriptionId;
                        customer.Price = Convert.ToDecimal(txtPrice.Text);
                        con.SaveChanges();
                        MessageBox.Show("The data has been changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServices((int)customer.ProjectDetailsId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please select the row you would like to change", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }
        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string cellId = txtCellSelectedServices.Text;
            if (cellId != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Question", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        int ConvetCellId = Convert.ToInt32(txtCellSelectedServices.Text);
                        var customer = con.AddServices.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                        con.AddServices.Remove(customer);
                        con.SaveChanges();
                        MessageBox.Show("The service was successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int countCustomer = con.AddServices.Count();
                        if (countCustomer > 0)
                        {
                            int projetcDetailsId = Convert.ToInt32(txtCellSelectedFromProjectDetails.Text);
                            LoadServices(projetcDetailsId);
                        }
                        else
                        {
                            List<AddServices> lista = new List<AddServices>();
                            dgvServices.DataSource = lista;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please select the row you would like to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }
        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    DataGridViewRow row = dgvServices.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtCellSelectedServices.Text = val;
                    cboChooseService.SelectedValue = Convert.ToInt32(row.Cells[1].Value.ToString());
                    txtServiceDescription.Text = row.Cells[3].Value.ToString();
                    txtPrice.Text = row.Cells[4].Value.ToString();
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (txtCellSelectedProjectDetails.Text == "")
            {
                MessageBox.Show(@"Please select the client first to add or to show service!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tbControls.TabPages[1].Enabled = true;
                tbControls.SelectedIndex = 1;

                var projectDetailsId = Convert.ToInt32(txtCellSelectedProjectDetails.Text);
                LoadServices(projectDetailsId);         

            }
        }


        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                if (txtCellSelectedProjectDetails.Text == "")
                {
                    MessageBox.Show(@"Please select the client that you want to generate report", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var projectId = Convert.ToInt32(txtCellSelectedProjectDetails.Text);
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
    }
}
