using Connection;
using Connection.Not_Mapped;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngebotenUndRechnungenApp
{
    public partial class AddNewService : Form
    {
        public OfferandinvoicedbContext con = new OfferandinvoicedbContext();
        public AddNewService()
        {
            InitializeComponent();
        }
        private void AddNewService_Load(object sender, EventArgs e)
        {
            LoadServices();
        }
        public void ClearFields()
        {
            txtService.Text = "";
            txtServiceDescription.Text = "";
            txtCellSelected.Text = "";
        }
        private void AdjustColumn()
        {
            try
            {
                dgvServicesInDatabase.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSeaGreen;
                dgvServicesInDatabase.EnableHeadersVisualStyles = false;
                dgvServicesInDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvServicesInDatabase.ColumnHeadersHeight = 40;

                dgvServicesInDatabase.Columns["ID"].Visible = false;
                dgvServicesInDatabase.Columns["ServiceName"].HeaderText = "Service Name";          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadServices()
        {
            var services = con.Query<GetServicesFromDbVM>().FromSqlRaw("EXEC prc_GetAllServicesFromDb").ToList();
            dgvServicesInDatabase.DataSource = null;
            dgvServicesInDatabase.DataSource = services;
            AdjustColumn();
            ClearFields();
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string cellId = txtCellSelected.Text;
                if (cellId == "")
                {
                    if (txtService.Text == "" || txtServiceDescription.Text == "")
                    {
                        MessageBox.Show(@"Please enter the service or the description of service", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var obj = new Services();
                        obj.ServiceName = txtService.Text;
                        con.Services.Add(obj);
                        con.SaveChanges();
                        var obj2 = new ServiceDescription();
                        var serviceId = con.Services.Where(x => x.ServiceName == obj.ServiceName).Select(x => x.Id).SingleOrDefault();
                        obj2.ServiceId = serviceId;
                        obj2.Description = txtServiceDescription.Text;
                        con.ServiceDescription.Add(obj2);
                        con.SaveChanges();

                        MessageBox.Show("The data has been inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServices();
                    }
                }
                else
                {
                    MessageBox.Show(@"First clear and then save a new one", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields();
                }

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearFields();
            Cursor = Cursors.Default;
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string cellId = txtCellSelected.Text;
            if (cellId != "")
            {
                if (txtService.Text == "" || txtServiceDescription.Text == "")
                {
                    MessageBox.Show(@"Please enter the service or the description of service", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int ConvetCellId = Convert.ToInt32(txtCellSelected.Text);
                        var obj = con.Services.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                        obj.ServiceName = txtService.Text;
                        var obj2 = con.ServiceDescription.Where(x => x.ServiceId == ConvetCellId).SingleOrDefault();
                        obj2.ServiceId = ConvetCellId;
                        obj2.Description = txtServiceDescription.Text;
                        con.SaveChanges();
                        MessageBox.Show("The data has been changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServices();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Please select the row that you would like to change", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            string cellId = txtCellSelected.Text;
            if (cellId != "")
            {
                int ConvetCellId = Convert.ToInt32(txtCellSelected.Text);
                var serviceDescId = con.ServiceDescription.Where(x => x.ServiceId == ConvetCellId).Select(x => x.Id).SingleOrDefault();
                var checkInAddServices = con.AddServices.Where(x => x.ServiceDescriptionId == serviceDescId).Count();
                if (checkInAddServices != 0)
                {
                    MessageBox.Show(@"You cannot delete this service because there is an invoice or offer for him", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearFields();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            var service = con.Services.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                            con.Services.Remove(service);
                            var serviceDescription = con.ServiceDescription.Where(x => x.ServiceId == ConvetCellId).SingleOrDefault();
                            con.ServiceDescription.Remove(serviceDescription);
                            con.SaveChanges();
                            MessageBox.Show("The client was successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            int countServices = con.Services.Count();

                            if (countServices > 0)
                            {
                                LoadServices();
                            }
                            else
                            {
                                List<GetServicesFromDbVM> lista = new List<GetServicesFromDbVM>();
                                dgvServicesInDatabase.DataSource = lista;
                            }
                            ClearFields();
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
                MessageBox.Show(@"Please select the row that you would like to change", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Cursor = Cursors.Default;
        }
        private void dgvServicesInDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                try
                {
                    DataGridViewRow row = dgvServicesInDatabase.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtCellSelected.Text = val;
                    txtService.Text = row.Cells[1].Value.ToString();
                    txtServiceDescription.Text = row.Cells[2].Value.ToString();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

   
    }
}
