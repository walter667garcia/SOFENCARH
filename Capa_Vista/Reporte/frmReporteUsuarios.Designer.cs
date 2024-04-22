namespace Capa_Vista.Reporte
{
    partial class frmReporteUsuarios
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
            this.spListarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosDataset = new Capa_Vista.Reporte.dataVacaciones();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ListarUsuariosTableAdapter = new Capa_Vista.Reporte.dataVacacionesTableAdapters.sp_ListarUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataset)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spListarUsuariosBindingSource
            // 
            this.spListarUsuariosBindingSource.DataMember = "sp_ListarUsuarios";
            this.spListarUsuariosBindingSource.DataSource = this.usuariosDataset;
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
            this.panel1.Size = new System.Drawing.Size(873, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 622);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Usuarios";
            reportDataSource2.Value = this.spListarUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reporte.ReporteUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(873, 622);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ListarUsuariosTableAdapter
            // 
            this.sp_ListarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 722);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReporteUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReporteUsuarios";
            this.Load += new System.EventHandler(this.frmReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataset)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dataVacaciones usuariosDataset;
        private System.Windows.Forms.BindingSource spListarUsuariosBindingSource;
        private dataVacacionesTableAdapters.sp_ListarUsuariosTableAdapter sp_ListarUsuariosTableAdapter;
    }
}