
namespace AngebotenUndRechnungenApp
{
    partial class GenerateReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReport));
            this.prc_GetCustomerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfferAndInvoiceDBDataSet = new AngebotenUndRechnungenApp.OfferAndInvoiceDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.prc_GetCustomerInfoTableAdapter = new AngebotenUndRechnungenApp.OfferAndInvoiceDBDataSetTableAdapters.prc_GetCustomerInfoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prc_GetCustomerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfferAndInvoiceDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // prc_GetCustomerInfoBindingSource
            // 
            this.prc_GetCustomerInfoBindingSource.DataMember = "prc_GetCustomerInfo";
            this.prc_GetCustomerInfoBindingSource.DataSource = this.OfferAndInvoiceDBDataSet;
            // 
            // OfferAndInvoiceDBDataSet
            // 
            this.OfferAndInvoiceDBDataSet.DataSetName = "OfferAndInvoiceDBDataSet";
            this.OfferAndInvoiceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "GetCustomerInfo";
            reportDataSource1.Value = this.prc_GetCustomerInfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AngebotenUndRechnungenApp.Reports.OfferteReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1017, 706);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.ZoomPercent = 150;
            // 
            // prc_GetCustomerInfoTableAdapter
            // 
            this.prc_GetCustomerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(440, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report";
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1017, 754);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateReport";
            this.Load += new System.EventHandler(this.GenerateReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prc_GetCustomerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfferAndInvoiceDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource prc_GetCustomerInfoBindingSource;
        private OfferAndInvoiceDBDataSet OfferAndInvoiceDBDataSet;
        private OfferAndInvoiceDBDataSetTableAdapters.prc_GetCustomerInfoTableAdapter prc_GetCustomerInfoTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}