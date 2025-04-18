using Connection;
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
    public partial class AddCustomer : Form
    {
        public OfferandinvoicedbContext con=new OfferandinvoicedbContext();
        public AddCustomer()
        {
            InitializeComponent();
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {           
            LoadCustomer();
            AdjustColumn();
        }
        private void AdjustColumn()
        {
            try
            {
                dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
                dgvCustomers.EnableHeadersVisualStyles = false;
                dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgvCustomers.ColumnHeadersHeight = 40;
                dgvCustomers.Columns["ID"].Visible = false;
                dgvCustomers.Columns["ProjectDetails"].Visible = false;
                dgvCustomers.Columns["CustomerName"].HeaderText = "Customer Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                string cellId = txtCellSelected.Text;
                if (cellId == "")
                {
                    if (txtNameOfCustomer.Text == "")
                    {
                        MessageBox.Show(@"Please enter the customer's name", @"Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        var obj = new Customers();
                        obj.CustomerName = txtNameOfCustomer.Text;
                        obj.Address1 = txtAddress1.Text;
                        obj.Address2 = txtAddress2.Text;
                        obj.Address3 = txtAddress3.Text;
                        obj.Email = txtEmail.Text;
                        obj.Phone = txtPhone.Text;
                        con.Customers.Add(obj);
                        con.SaveChanges();
                        MessageBox.Show("The data has been inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadCustomer();
                    }
                }
                else
                {
                    MessageBox.Show(@"First clear and then save a new one", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ClearFields();

                Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {            
            Cursor = Cursors.WaitCursor;
            string cellId = txtCellSelected.Text;
            if (cellId !="")
            {
                if (txtNameOfCustomer.Text == "")
                {
                    MessageBox.Show(@"Please enter the customer's name", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        int ConvetCellId = Convert.ToInt32(txtCellSelected.Text);
                        var customer = con.Customers.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                        customer.CustomerName = txtNameOfCustomer.Text;
                        customer.Email = txtEmail.Text;
                        customer.Phone = txtPhone.Text;
                        customer.Address1 = txtAddress1.Text;
                        customer.Address2 = txtAddress2.Text;
                        customer.Address3 = txtAddress3.Text;
                        con.SaveChanges();
                        MessageBox.Show("The data has been changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadCustomer();
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
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
           
            string cellId=txtCellSelected.Text;
            if (cellId !="")
            {
                int ConvetCellId = Convert.ToInt32(txtCellSelected.Text);
                var checkInProjectDetails = con.ProjectDetails.Where(x => x.ClientsId == ConvetCellId).Count();
                if (checkInProjectDetails != 0)
                {
                    MessageBox.Show(@"You cannot delete this customer because there is an invoice or offer for him", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {


                            var customer = con.Customers.Where(x => x.Id == ConvetCellId).SingleOrDefault();
                            con.Customers.Remove(customer);
                            con.SaveChanges();
                            MessageBox.Show("The client was successfully deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            int countCustomer = con.Customers.Count();
                            if (countCustomer > 0)
                            {
                                LoadCustomer();
                            }
                            else
                            {
                                List<Customers> lista = new List<Customers>();
                                dgvCustomers.DataSource = lista;
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
                MessageBox.Show(@"Please select the row you would like to delete", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          

            Cursor = Cursors.Default;
        }
        public void ClearFields()
        {
            txtNameOfCustomer.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtCellSelected.Text = "";
        }

        public void LoadCustomer()
        {
            //var customerList = con.Customers.ToList();
            var customerList = con.Customers.OrderByDescending(x => x.Id).ToList();
            dgvCustomers.DataSource = customerList;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                try
                {
                    DataGridViewRow row = dgvCustomers.Rows[e.RowIndex];
                    string val = row.Cells[0].Value.ToString();
                    txtCellSelected.Text = val;
                    txtNameOfCustomer.Text = row.Cells[1].Value.ToString();
                    txtEmail.Text = row.Cells[5].Value.ToString();
                    txtPhone.Text = row.Cells[6].Value.ToString();
                    txtAddress1.Text = row.Cells[2].Value.ToString();
                    txtAddress2.Text = row.Cells[3].Value.ToString();
                    txtAddress3.Text = row.Cells[4].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ClearFields();
            Cursor = Cursors.Default;
        }
    }
}
