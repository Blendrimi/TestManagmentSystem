
namespace AngebotenUndRechnungenApp
{
    partial class ProjectDetailsAndServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectDetailsAndServices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbControls = new System.Windows.Forms.TabControl();
            this.tbProjectDetails = new System.Windows.Forms.TabPage();
            this.lblClient = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtCellSelectedProjectDetails = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboChooseTypeReport = new System.Windows.Forms.ComboBox();
            this.btnClearProjectDetails = new System.Windows.Forms.Button();
            this.btnDeleteProjectDetails = new System.Windows.Forms.Button();
            this.btnUpdateProjectDetails = new System.Windows.Forms.Button();
            this.btnAddProjectDetails = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProjectDetails = new System.Windows.Forms.DataGridView();
            this.txtCleaningLocation = new System.Windows.Forms.TextBox();
            this.txtNoReferenceOrInvoice = new System.Windows.Forms.TextBox();
            this.txtBuilder = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.cboChooseClient = new System.Windows.Forms.ComboBox();
            this.tbServices = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.txtCellSelectedFromProjectDetails = new System.Windows.Forms.TextBox();
            this.txtCellSelectedServices = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboChooseService = new System.Windows.Forms.ComboBox();
            this.btnClearService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.tbControls.SuspendLayout();
            this.tbProjectDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).BeginInit();
            this.tbServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControls
            // 
            this.tbControls.Controls.Add(this.tbProjectDetails);
            this.tbControls.Controls.Add(this.tbServices);
            this.tbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControls.Location = new System.Drawing.Point(0, 0);
            this.tbControls.Name = "tbControls";
            this.tbControls.SelectedIndex = 0;
            this.tbControls.Size = new System.Drawing.Size(899, 522);
            this.tbControls.TabIndex = 0;
            this.tbControls.SelectedIndexChanged += new System.EventHandler(this.tbControls_SelectedIndexChanged);
            // 
            // tbProjectDetails
            // 
            this.tbProjectDetails.AutoScroll = true;
            this.tbProjectDetails.Controls.Add(this.lblClient);
            this.tbProjectDetails.Controls.Add(this.btnGenerateReport);
            this.tbProjectDetails.Controls.Add(this.btnContinue);
            this.tbProjectDetails.Controls.Add(this.txtCellSelectedProjectDetails);
            this.tbProjectDetails.Controls.Add(this.label6);
            this.tbProjectDetails.Controls.Add(this.cboChooseTypeReport);
            this.tbProjectDetails.Controls.Add(this.btnClearProjectDetails);
            this.tbProjectDetails.Controls.Add(this.btnDeleteProjectDetails);
            this.tbProjectDetails.Controls.Add(this.btnUpdateProjectDetails);
            this.tbProjectDetails.Controls.Add(this.btnAddProjectDetails);
            this.tbProjectDetails.Controls.Add(this.label5);
            this.tbProjectDetails.Controls.Add(this.label4);
            this.tbProjectDetails.Controls.Add(this.label3);
            this.tbProjectDetails.Controls.Add(this.label2);
            this.tbProjectDetails.Controls.Add(this.label1);
            this.tbProjectDetails.Controls.Add(this.dgvProjectDetails);
            this.tbProjectDetails.Controls.Add(this.txtCleaningLocation);
            this.tbProjectDetails.Controls.Add(this.txtNoReferenceOrInvoice);
            this.tbProjectDetails.Controls.Add(this.txtBuilder);
            this.tbProjectDetails.Controls.Add(this.txtProjectName);
            this.tbProjectDetails.Controls.Add(this.cboChooseClient);
            this.tbProjectDetails.Location = new System.Drawing.Point(4, 22);
            this.tbProjectDetails.Name = "tbProjectDetails";
            this.tbProjectDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbProjectDetails.Size = new System.Drawing.Size(891, 496);
            this.tbProjectDetails.TabIndex = 0;
            this.tbProjectDetails.Text = "Project Details";
            this.tbProjectDetails.UseVisualStyleBackColor = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.Red;
            this.lblClient.Location = new System.Drawing.Point(646, 12);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 24);
            this.lblClient.TabIndex = 27;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateReport.Image")));
            this.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.Location = new System.Drawing.Point(463, 440);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(179, 44);
            this.btnGenerateReport.TabIndex = 12;
            this.btnGenerateReport.Text = "&Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click_1);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Image = global::AngebotenUndRechnungenApp.Properties.Resources.right;
            this.btnContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinue.Location = new System.Drawing.Point(659, 440);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(215, 44);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "&Continue to add services";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtCellSelectedProjectDetails
            // 
            this.txtCellSelectedProjectDetails.Location = new System.Drawing.Point(501, 3);
            this.txtCellSelectedProjectDetails.Name = "txtCellSelectedProjectDetails";
            this.txtCellSelectedProjectDetails.ReadOnly = true;
            this.txtCellSelectedProjectDetails.Size = new System.Drawing.Size(100, 20);
            this.txtCellSelectedProjectDetails.TabIndex = 60;
            this.txtCellSelectedProjectDetails.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(323, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Choose type of report";
            // 
            // cboChooseTypeReport
            // 
            this.cboChooseTypeReport.FormattingEnabled = true;
            this.cboChooseTypeReport.Location = new System.Drawing.Point(326, 34);
            this.cboChooseTypeReport.Name = "cboChooseTypeReport";
            this.cboChooseTypeReport.Size = new System.Drawing.Size(294, 21);
            this.cboChooseTypeReport.TabIndex = 2;
            this.cboChooseTypeReport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboTypeReport_KeyPress);
            // 
            // btnClearProjectDetails
            // 
            this.btnClearProjectDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearProjectDetails.Image = global::AngebotenUndRechnungenApp.Properties.Resources.clear__1_;
            this.btnClearProjectDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearProjectDetails.Location = new System.Drawing.Point(744, 135);
            this.btnClearProjectDetails.Name = "btnClearProjectDetails";
            this.btnClearProjectDetails.Size = new System.Drawing.Size(130, 36);
            this.btnClearProjectDetails.TabIndex = 10;
            this.btnClearProjectDetails.Text = "&Clear";
            this.btnClearProjectDetails.UseVisualStyleBackColor = true;
            this.btnClearProjectDetails.Click += new System.EventHandler(this.btnClearProjectDetails_Click);
            // 
            // btnDeleteProjectDetails
            // 
            this.btnDeleteProjectDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProjectDetails.Image = global::AngebotenUndRechnungenApp.Properties.Resources.remove;
            this.btnDeleteProjectDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProjectDetails.Location = new System.Drawing.Point(744, 93);
            this.btnDeleteProjectDetails.Name = "btnDeleteProjectDetails";
            this.btnDeleteProjectDetails.Size = new System.Drawing.Size(130, 36);
            this.btnDeleteProjectDetails.TabIndex = 9;
            this.btnDeleteProjectDetails.Text = "&Delete";
            this.btnDeleteProjectDetails.UseVisualStyleBackColor = true;
            this.btnDeleteProjectDetails.Click += new System.EventHandler(this.btnDeleteProjectDetails_Click);
            // 
            // btnUpdateProjectDetails
            // 
            this.btnUpdateProjectDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProjectDetails.Image = global::AngebotenUndRechnungenApp.Properties.Resources.loop;
            this.btnUpdateProjectDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProjectDetails.Location = new System.Drawing.Point(744, 50);
            this.btnUpdateProjectDetails.Name = "btnUpdateProjectDetails";
            this.btnUpdateProjectDetails.Size = new System.Drawing.Size(130, 36);
            this.btnUpdateProjectDetails.TabIndex = 8;
            this.btnUpdateProjectDetails.Text = "&Update";
            this.btnUpdateProjectDetails.UseVisualStyleBackColor = true;
            this.btnUpdateProjectDetails.Click += new System.EventHandler(this.btnUpdateProjectDetails_Click);
            // 
            // btnAddProjectDetails
            // 
            this.btnAddProjectDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProjectDetails.Image = global::AngebotenUndRechnungenApp.Properties.Resources.plus__1_;
            this.btnAddProjectDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProjectDetails.Location = new System.Drawing.Point(744, 8);
            this.btnAddProjectDetails.Name = "btnAddProjectDetails";
            this.btnAddProjectDetails.Size = new System.Drawing.Size(130, 36);
            this.btnAddProjectDetails.TabIndex = 7;
            this.btnAddProjectDetails.Text = "&Add";
            this.btnAddProjectDetails.UseVisualStyleBackColor = true;
            this.btnAddProjectDetails.Click += new System.EventHandler(this.btnAddProjectDetails_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cleaning Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Builder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "No of Reference or Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose client";
            // 
            // dgvProjectDetails
            // 
            this.dgvProjectDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjectDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjectDetails.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProjectDetails.Location = new System.Drawing.Point(14, 208);
            this.dgvProjectDetails.MultiSelect = false;
            this.dgvProjectDetails.Name = "dgvProjectDetails";
            this.dgvProjectDetails.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProjectDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectDetails.Size = new System.Drawing.Size(860, 226);
            this.dgvProjectDetails.TabIndex = 11;
            this.dgvProjectDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjectDetails_CellClick);
            // 
            // txtCleaningLocation
            // 
            this.txtCleaningLocation.Location = new System.Drawing.Point(326, 164);
            this.txtCleaningLocation.Name = "txtCleaningLocation";
            this.txtCleaningLocation.Size = new System.Drawing.Size(294, 20);
            this.txtCleaningLocation.TabIndex = 6;
            // 
            // txtNoReferenceOrInvoice
            // 
            this.txtNoReferenceOrInvoice.Location = new System.Drawing.Point(14, 164);
            this.txtNoReferenceOrInvoice.Name = "txtNoReferenceOrInvoice";
            this.txtNoReferenceOrInvoice.Size = new System.Drawing.Size(294, 20);
            this.txtNoReferenceOrInvoice.TabIndex = 5;
            // 
            // txtBuilder
            // 
            this.txtBuilder.Location = new System.Drawing.Point(326, 97);
            this.txtBuilder.Name = "txtBuilder";
            this.txtBuilder.Size = new System.Drawing.Size(294, 20);
            this.txtBuilder.TabIndex = 4;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(14, 97);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(294, 20);
            this.txtProjectName.TabIndex = 3;
            // 
            // cboChooseClient
            // 
            this.cboChooseClient.FormattingEnabled = true;
            this.cboChooseClient.Location = new System.Drawing.Point(14, 34);
            this.cboChooseClient.Name = "cboChooseClient";
            this.cboChooseClient.Size = new System.Drawing.Size(294, 21);
            this.cboChooseClient.TabIndex = 1;
            this.cboChooseClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboChooseClient_KeyPress);
            // 
            // tbServices
            // 
            this.tbServices.AutoScroll = true;
            this.tbServices.Controls.Add(this.label7);
            this.tbServices.Controls.Add(this.txtServiceDescription);
            this.tbServices.Controls.Add(this.txtCellSelectedFromProjectDetails);
            this.tbServices.Controls.Add(this.txtCellSelectedServices);
            this.tbServices.Controls.Add(this.label9);
            this.tbServices.Controls.Add(this.label10);
            this.tbServices.Controls.Add(this.dgvServices);
            this.tbServices.Controls.Add(this.txtPrice);
            this.tbServices.Controls.Add(this.cboChooseService);
            this.tbServices.Controls.Add(this.btnClearService);
            this.tbServices.Controls.Add(this.btnDeleteService);
            this.tbServices.Controls.Add(this.btnUpdateService);
            this.tbServices.Controls.Add(this.btnAddService);
            this.tbServices.Location = new System.Drawing.Point(4, 22);
            this.tbServices.Name = "tbServices";
            this.tbServices.Padding = new System.Windows.Forms.Padding(3);
            this.tbServices.Size = new System.Drawing.Size(891, 496);
            this.tbServices.TabIndex = 1;
            this.tbServices.Text = "Services";
            this.tbServices.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Description of service";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(15, 85);
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.ReadOnly = true;
            this.txtServiceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServiceDescription.Size = new System.Drawing.Size(494, 53);
            this.txtServiceDescription.TabIndex = 16;
            // 
            // txtCellSelectedFromProjectDetails
            // 
            this.txtCellSelectedFromProjectDetails.Location = new System.Drawing.Point(558, 3);
            this.txtCellSelectedFromProjectDetails.Name = "txtCellSelectedFromProjectDetails";
            this.txtCellSelectedFromProjectDetails.ReadOnly = true;
            this.txtCellSelectedFromProjectDetails.Size = new System.Drawing.Size(100, 20);
            this.txtCellSelectedFromProjectDetails.TabIndex = 61;
            this.txtCellSelectedFromProjectDetails.Visible = false;
            // 
            // txtCellSelectedServices
            // 
            this.txtCellSelectedServices.Location = new System.Drawing.Point(694, 3);
            this.txtCellSelectedServices.Name = "txtCellSelectedServices";
            this.txtCellSelectedServices.ReadOnly = true;
            this.txtCellSelectedServices.Size = new System.Drawing.Size(100, 20);
            this.txtCellSelectedServices.TabIndex = 62;
            this.txtCellSelectedServices.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Choose service";
            // 
            // dgvServices
            // 
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvServices.Location = new System.Drawing.Point(14, 144);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(869, 327);
            this.dgvServices.TabIndex = 22;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(379, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(129, 20);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // cboChooseService
            // 
            this.cboChooseService.FormattingEnabled = true;
            this.cboChooseService.Location = new System.Drawing.Point(14, 34);
            this.cboChooseService.Name = "cboChooseService";
            this.cboChooseService.Size = new System.Drawing.Size(290, 21);
            this.cboChooseService.TabIndex = 15;
            this.cboChooseService.SelectionChangeCommitted += new System.EventHandler(this.cboChooseService_SelectionChangeCommitted);
            this.cboChooseService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboChooseService_KeyPress);
            // 
            // btnClearService
            // 
            this.btnClearService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.clear__1_;
            this.btnClearService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearService.Location = new System.Drawing.Point(753, 85);
            this.btnClearService.Name = "btnClearService";
            this.btnClearService.Size = new System.Drawing.Size(130, 36);
            this.btnClearService.TabIndex = 21;
            this.btnClearService.Text = "&Clear";
            this.btnClearService.UseVisualStyleBackColor = true;
            this.btnClearService.Click += new System.EventHandler(this.btnClearService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.remove;
            this.btnDeleteService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteService.Location = new System.Drawing.Point(753, 32);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(130, 36);
            this.btnDeleteService.TabIndex = 20;
            this.btnDeleteService.Text = "&Delete";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.loop;
            this.btnUpdateService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateService.Location = new System.Drawing.Point(617, 85);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(130, 36);
            this.btnUpdateService.TabIndex = 19;
            this.btnUpdateService.Text = "&Update";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddService.Image = global::AngebotenUndRechnungenApp.Properties.Resources.plus__1_;
            this.btnAddService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddService.Location = new System.Drawing.Point(617, 32);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(130, 36);
            this.btnAddService.TabIndex = 18;
            this.btnAddService.Text = "&Add";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // ProjectDetailsAndServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 522);
            this.Controls.Add(this.tbControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectDetailsAndServices";
            this.Text = "ProjectDetailsAndServices";
            this.Load += new System.EventHandler(this.ProjectDetailsAndServices_Load);
            this.tbControls.ResumeLayout(false);
            this.tbProjectDetails.ResumeLayout(false);
            this.tbProjectDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectDetails)).EndInit();
            this.tbServices.ResumeLayout(false);
            this.tbServices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControls;
        private System.Windows.Forms.TabPage tbProjectDetails;
        private System.Windows.Forms.TabPage tbServices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProjectDetails;
        private System.Windows.Forms.TextBox txtCleaningLocation;
        private System.Windows.Forms.TextBox txtNoReferenceOrInvoice;
        private System.Windows.Forms.TextBox txtBuilder;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.ComboBox cboChooseClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cboChooseService;
        private System.Windows.Forms.Button btnClearProjectDetails;
        private System.Windows.Forms.Button btnDeleteProjectDetails;
        private System.Windows.Forms.Button btnUpdateProjectDetails;
        private System.Windows.Forms.Button btnAddProjectDetails;
        private System.Windows.Forms.Button btnClearService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboChooseTypeReport;
        private System.Windows.Forms.TextBox txtCellSelectedProjectDetails;
        private System.Windows.Forms.TextBox txtCellSelectedServices;
        private System.Windows.Forms.TextBox txtCellSelectedFromProjectDetails;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label lblClient;
    }
}