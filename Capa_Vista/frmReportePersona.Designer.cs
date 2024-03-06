namespace Capa_Vista
{
    partial class frmReportePersona
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteDataSet = new Capa_Vista.ReporteDataSet();
            this.spListarPersonaReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListarPersonaReporteTableAdapter = new Capa_Vista.ReporteDataSetTableAdapters.sp_ListarPersonaReporteTableAdapter();
            this.splistarHomeEducacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_listarHomeEducacionTableAdapter = new Capa_Vista.ReporteDataSetTableAdapters.sp_listarHomeEducacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarPersonaReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarHomeEducacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListarPersonaReporteBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.splistarHomeEducacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reportes.ReportePersona.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteDataSet
            // 
            this.reporteDataSet.DataSetName = "ReporteDataSet";
            this.reporteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListarPersonaReporteBindingSource
            // 
            this.spListarPersonaReporteBindingSource.DataMember = "sp_ListarPersonaReporte";
            this.spListarPersonaReporteBindingSource.DataSource = this.reporteDataSet;
            // 
            // sp_ListarPersonaReporteTableAdapter
            // 
            this.sp_ListarPersonaReporteTableAdapter.ClearBeforeFill = true;
            // 
            // splistarHomeEducacionBindingSource
            // 
            this.splistarHomeEducacionBindingSource.DataMember = "sp_listarHomeEducacion";
            this.splistarHomeEducacionBindingSource.DataSource = this.reporteDataSet;
            // 
            // sp_listarHomeEducacionTableAdapter
            // 
            this.sp_listarHomeEducacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportePersona";
            this.Text = "frmReportePersona";
            this.Load += new System.EventHandler(this.frmReportePersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarPersonaReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistarHomeEducacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spListarPersonaReporteBindingSource;
        private ReporteDataSet reporteDataSet;
        private System.Windows.Forms.BindingSource splistarHomeEducacionBindingSource;
        private ReporteDataSetTableAdapters.sp_ListarPersonaReporteTableAdapter sp_ListarPersonaReporteTableAdapter;
        private ReporteDataSetTableAdapters.sp_listarHomeEducacionTableAdapter sp_listarHomeEducacionTableAdapter;
    }
}