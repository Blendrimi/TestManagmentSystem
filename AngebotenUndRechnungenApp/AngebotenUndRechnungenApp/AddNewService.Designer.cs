
namespace AngebotenUndRechnungenApp
{
    partial class AddNewService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            this.dgvServicesInDatabase = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCellSelected = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesInDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description of service";
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(15, 28);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(295, 20);
            this.txtService.TabIndex = 9;
            // 
            // dgvServicesInDatabase
            // 
            this.dgvServicesInDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicesInDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicesInDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicesInDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicesInDatabase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicesInDatabase.Location = new System.Drawing.Point(15, 146);
            this.dgvServicesInDatabase.MultiSelect = false;
            this.dgvServicesInDatabase.Name = "dgvServicesInDatabase";
            this.dgvServicesInDatabase.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicesInDatabase.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvServicesInDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicesInDatabase.Size = new System.Drawing.Size(815, 295);
            this.dgvServicesInDatabase.TabIndex = 15;
            this.dgvServicesInDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicesInDatabase_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = global::AngebotenUndRechnungenApp.Properties.Resources.clear__1_;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(700, 89);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 36);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.remove;
            this.btnDeleteService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteService.Location = new System.Drawing.Point(700, 25);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(130, 36);
            this.btnDeleteService.TabIndex = 13;
            this.btnDeleteService.Text = "&Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.loop;
            this.btnUpdateService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateService.Location = new System.Drawing.Point(555, 89);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(130, 36);
            this.btnUpdateService.TabIndex = 12;
            this.btnUpdateService.Text = "&Update";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.plus__1_;
            this.btnAddService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.Location = new System.Drawing.Point(555, 25);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(130, 36);
            this.btnAddService.TabIndex = 11;
            this.btnAddService.Text = "&Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(15, 75);
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServiceDescription.Size = new System.Drawing.Size(534, 50);
            this.txtServiceDescription.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Add service";
            // 
            // txtCellSelected
            // 
            this.txtCellSelected.Location = new System.Drawing.Point(409, 5);
            this.txtCellSelected.Name = "txtCellSelected";
            this.txtCellSelected.ReadOnly = true;
            this.txtCellSelected.Size = new System.Drawing.Size(100, 20);
            this.txtCellSelected.TabIndex = 31;
            this.txtCellSelected.Visible = false;
            // 
            // AddNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 453);
            this.Controls.Add(this.txtCellSelected);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.dgvServicesInDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewService";
            this.Text = "AddNewService";
            this.Load += new System.EventHandler(this.AddNewService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicesInDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.DataGridView dgvServicesInDatabase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCellSelected;
    }
}