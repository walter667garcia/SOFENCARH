namespace Capa_Vista.Reportes
{
    partial class frmReporteActas
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDataSet = new Capa_Vista.ReporteDataSet();
            this.spReporteActasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ReporteActasTableAdapter = new Capa_Vista.ReporteDataSetTableAdapters.sp_ReporteActasTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteActasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 494);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 76);
            this.panel1.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReporteActasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1155, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteDataSet
            // 
            this.reporteDataSet.DataSetName = "ReporteDataSet";
            this.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spReporteActasBindingSource
            // 
            this.spReporteActasBindingSource.DataMember = "sp_ReporteActas";
            this.spReporteActasBindingSource.DataSource = this.reporteDataSet;
            // 
            // sp_ReporteActasTableAdapter
            // 
            this.sp_ReporteActasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteActas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReporteActas";
            this.Text = "frmReporteActas";
            this.Load += new System.EventHandler(this.frmReporteActas_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteActasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteActasBindingSource;
        private ReporteDataSet reporteDataSet;
        private ReporteDataSetTableAdapters.sp_ReporteActasTableAdapter sp_ReporteActasTableAdapter;
    }
}