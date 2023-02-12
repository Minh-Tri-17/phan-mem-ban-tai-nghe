
namespace DACS2
{
    partial class FormInNhapHang
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
            this.DACS2DataSet1 = new DACS2.DACS2DataSet1();
            this.INNHAPHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INNHAPHANGTableAdapter = new DACS2.DACS2DataSet1TableAdapters.INNHAPHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DACS2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INNHAPHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.INNHAPHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DACS2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(591, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DACS2DataSet1
            // 
            this.DACS2DataSet1.DataSetName = "DACS2DataSet1";
            this.DACS2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // INNHAPHANGBindingSource
            // 
            this.INNHAPHANGBindingSource.DataMember = "INNHAPHANG";
            this.INNHAPHANGBindingSource.DataSource = this.DACS2DataSet1;
            // 
            // INNHAPHANGTableAdapter
            // 
            this.INNHAPHANGTableAdapter.ClearBeforeFill = true;
            // 
            // FormInNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormInNhapHang";
            this.Text = "FormInNhapHang";
            this.Load += new System.EventHandler(this.FormInNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DACS2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INNHAPHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource INNHAPHANGBindingSource;
        private DACS2DataSet1 DACS2DataSet1;
        private DACS2DataSet1TableAdapters.INNHAPHANGTableAdapter INNHAPHANGTableAdapter;
    }
}