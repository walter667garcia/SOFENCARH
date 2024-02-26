namespace SOFENCARH
{
    partial class frmReporteEducacion
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
            this.splistarHomeEducacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrincipal = new SOFENCARH.dsPrincipal();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_listarHomeEducacionTableAdapter = new SOFENCARH.dsPrincipalTableAdapters.sp_listarHomeEducacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splistarHomeEducacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // splistarHomeEducacionBindingSource
            // 
            this.splistarHomeEducacionBindingSource.DataMember = "sp_listarHomeEducacion";
            this.splistarHomeEducacionBindingSource.DataSource = this.dsPrincipal;
            // 
            // dsPrincipal
            // 
            this.dsPrincipal.DataSetName = "dsPrincipal";
            this.dsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.splistarHomeEducacionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SOFENCARH.Reportes.rptEducacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_listarHomeEducacionTableAdapter
            // 
            this.sp_listarHomeEducacionTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEducacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteEducacion";
            this.Text = "frmReporteEducacion";
            this.Load += new System.EventHandler(this.frmReporteEducacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splistarHomeEducacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource splistarHomeEducacionBindingSource;
        private dsPrincipal dsPrincipal;
        private dsPrincipalTableAdapters.sp_listarHomeEducacionTableAdapter sp_listarHomeEducacionTableAdapter;
    }
}