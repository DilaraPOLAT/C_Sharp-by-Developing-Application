
namespace Tapu_Yonetim_Sistemi.app
{
    partial class frmReportEv
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TapuVeriTabaniDataSet21 = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet21();
            this.EvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EvTableAdapter = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet21TableAdapters.EvTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TapuVeriTabaniDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EvBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tapu_Yonetim_Sistemi.app.ReportEv.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TapuVeriTabaniDataSet21
            // 
            this.TapuVeriTabaniDataSet21.DataSetName = "TapuVeriTabaniDataSet21";
            this.TapuVeriTabaniDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EvBindingSource
            // 
            this.EvBindingSource.DataMember = "Ev";
            this.EvBindingSource.DataSource = this.TapuVeriTabaniDataSet21;
            // 
            // EvTableAdapter
            // 
            this.EvTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportEv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportEv";
            this.Text = "frmReportEv";
            this.Load += new System.EventHandler(this.frmReportEv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TapuVeriTabaniDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EvBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EvBindingSource;
        private TapuVeriTabaniDataSet21 TapuVeriTabaniDataSet21;
        private TapuVeriTabaniDataSet21TableAdapters.EvTableAdapter EvTableAdapter;
    }
}