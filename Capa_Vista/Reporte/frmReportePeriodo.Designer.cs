namespace Capa_Vista.Reporte
{
    partial class frmReportePeriodo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spSeleccionarPeriodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataset = new Capa_Vista.Reporte.dataVacaciones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_SeleccionarPeriodosTableAdapter = new Capa_Vista.Reporte.dataVacacionesTableAdapters.sp_SeleccionarPeriodosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spSeleccionarPeriodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataset)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spSeleccionarPeriodosBindingSource
            // 
            this.spSeleccionarPeriodosBindingSource.DataMember = "sp_SeleccionarPeriodos";
            this.spSeleccionarPeriodosBindingSource.DataSource = this.usuariosDataset;
            // 
            // usuariosDataset
            // 
            this.usuariosDataset.DataSetName = "UsuariosDataset";
            this.usuariosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 690);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "Periodos";
            reportDataSource3.Value = this.spSeleccionarPeriodosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reporte.ReportePeriodos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 690);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_SeleccionarPeriodosTableAdapter
            // 
            this.sp_SeleccionarPeriodosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportePeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 776);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReportePeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportePeriodo";
            this.Load += new System.EventHandler(this.frmReportePeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spSeleccionarPeriodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataset)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spSeleccionarPeriodosBindingSource;
        private dataVacaciones usuariosDataset;
        private dataVacacionesTableAdapters.sp_SeleccionarPeriodosTableAdapter sp_SeleccionarPeriodosTableAdapter;
    }
}