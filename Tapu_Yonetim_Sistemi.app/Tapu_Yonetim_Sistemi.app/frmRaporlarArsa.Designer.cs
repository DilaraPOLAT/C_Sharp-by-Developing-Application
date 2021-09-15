
namespace Tapu_Yonetim_Sistemi.app
{
    partial class frmRaporlarArsa
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
            this.TapuVeriTabaniDataSet9 = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet9();
            this.ArsaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArsaTableAdapter = new Tapu_Yonetim_Sistemi.app.TapuVeriTabaniDataSet9TableAdapters.ArsaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TapuVeriTabaniDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArsaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ArsaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tapu_Yonetim_Sistemi.app.ReportArsa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(941, 595);
            this.reportViewer1.TabIndex = 0;
            // 
            // TapuVeriTabaniDataSet9
            // 
            this.TapuVeriTabaniDataSet9.DataSetName = "TapuVeriTabaniDataSet9";
            this.TapuVeriTabaniDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArsaBindingSource
            // 
            this.ArsaBindingSource.DataMember = "Arsa";
            this.ArsaBindingSource.DataSource = this.TapuVeriTabaniDataSet9;
            // 
            // ArsaTableAdapter
            // 
            this.ArsaTableAdapter.ClearBeforeFill = true;
            // 
            // frmRaporlarArsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 595);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRaporlarArsa";
            this.Text = "frmRaporlarArsa";
            this.Load += new System.EventHandler(this.frmRaporlarArsa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TapuVeriTabaniDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArsaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArsaBindingSource;
        private TapuVeriTabaniDataSet9 TapuVeriTabaniDataSet9;
        private TapuVeriTabaniDataSet9TableAdapters.ArsaTableAdapter ArsaTableAdapter;
    }
}