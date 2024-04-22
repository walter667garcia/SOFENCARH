namespace Capa_Vista.Reporte
{
    partial class frmReporteProfesion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spReporteProfesionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosNuevos = new Capa_Vista.Reporte.dataVacaciones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ReporteProfesionesTableAdapter = new Capa_Vista.Reporte.dataVacacionesTableAdapters.sp_ReporteProfesionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteProfesionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosNuevos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spReporteProfesionesBindingSource
            // 
            this.spReporteProfesionesBindingSource.DataMember = "sp_ReporteProfesiones";
            this.spReporteProfesionesBindingSource.DataSource = this.datosNuevos;
            // 
            // datosNuevos
            // 
            this.datosNuevos.DataSetName = "datosNuevos";
            this.datosNuevos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 450);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Profesion";
            reportDataSource2.Value = this.spReporteProfesionesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reporte.ReporteProfesion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(917, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ReporteProfesionesTableAdapter
            // 
            this.sp_ReporteProfesionesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteProfesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReporteProfesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteProfesion";
            this.Load += new System.EventHandler(this.frmReporteProfesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReporteProfesionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosNuevos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dataVacaciones datosNuevos;
        private System.Windows.Forms.BindingSource spReporteProfesionesBindingSource;
        private dataVacacionesTableAdapters.sp_ReporteProfesionesTableAdapter sp_ReporteProfesionesTableAdapter;
    }
}