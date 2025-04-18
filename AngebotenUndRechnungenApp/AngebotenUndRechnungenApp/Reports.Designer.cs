
namespace AngebotenUndRechnungenApp
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.cboChooseTypeReport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChooseClient = new System.Windows.Forms.ComboBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnGenerateButton = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCellSelected = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Choose type of report";
            // 
            // cboChooseTypeReport
            // 
            this.cboChooseTypeReport.FormattingEnabled = true;
            this.cboChooseTypeReport.Location = new System.Drawing.Point(12, 37);
            this.cboChooseTypeReport.Name = "cboChooseTypeReport";
            this.cboChooseTypeReport.Size = new System.Drawing.Size(275, 21);
            this.cboChooseTypeReport.TabIndex = 1;
            this.cboChooseTypeReport.SelectionChangeCommitted += new System.EventHandler(this.cboChooseTypeReport_SelectionChangeCommitted);
            this.cboChooseTypeReport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboChooseTypeReport_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Choose client";
            // 
            // cboChooseClient
            // 
            this.cboChooseClient.FormattingEnabled = true;
            this.cboChooseClient.Location = new System.Drawing.Point(335, 37);
            this.cboChooseClient.Name = "cboChooseClient";
            this.cboChooseClient.Size = new System.Drawing.Size(275, 21);
            this.cboChooseClient.TabIndex = 2;
            this.cboChooseClient.SelectionChangeCommitted += new System.EventHandler(this.cboChooseClient_SelectionChangeCommitted);
            this.cboChooseClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboChooseClient_KeyPress);
            // 
            // dgvReports
            // 
            this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReports.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReports.Location = new System.Drawing.Point(12, 79);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(877, 457);
            this.dgvReports.TabIndex = 5;
            this.dgvReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReports_CellClick);
            // 
            // btnGenerateButton
            // 
            this.btnGenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateButton.Image = global::AngebotenUndRechnungenApp.Properties.Resources.business_report;
            this.btnGenerateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateButton.Location = new System.Drawing.Point(726, 542);
            this.btnGenerateButton.Name = "btnGenerateButton";
            this.btnGenerateButton.Size = new System.Drawing.Size(163, 36);
            this.btnGenerateButton.TabIndex = 4;
            this.btnGenerateButton.Text = "&Generate report";
            this.btnGenerateButton.UseVisualStyleBackColor = true;
            this.btnGenerateButton.Click += new System.EventHandler(this.btnGenerateButton_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = global::AngebotenUndRechnungenApp.Properties.Resources.clear__1_;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(759, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 36);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCellSelected
            // 
            this.txtCellSelected.Location = new System.Drawing.Point(510, 2);
            this.txtCellSelected.Name = "txtCellSelected";
            this.txtCellSelected.ReadOnly = true;
            this.txtCellSelected.Size = new System.Drawing.Size(100, 20);
            this.txtCellSelected.TabIndex = 70;
            this.txtCellSelected.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 585);
            this.Controls.Add(this.txtCellSelected);
            this.Controls.Add(this.btnGenerateButton);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboChooseTypeReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboChooseClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboChooseTypeReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChooseClient;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerateButton;
        private System.Windows.Forms.TextBox txtCellSelected;
    }
}