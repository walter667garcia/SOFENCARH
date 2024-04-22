namespace Capa_Vista.Reporte
{
    partial class periodosenca
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
            this.spPeriodoTotalEncaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoEnca = new Capa_Vista.Reporte.periodoEnca();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_PeriodoTotalEncaTableAdapter = new Capa_Vista.Reporte.periodoEncaTableAdapters.sp_PeriodoTotalEncaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalEncaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEnca)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spPeriodoTotalEncaBindingSource
            // 
            this.spPeriodoTotalEncaBindingSource.DataMember = "sp_PeriodoTotalEnca";
            this.spPeriodoTotalEncaBindingSource.DataSource = this.periodoEnca;
            // 
            // periodoEnca
            // 
            this.periodoEnca.DataSetName = "periodoEnca";
            this.periodoEnca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 93);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(826, 626);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PeriodosEnca";
            reportDataSource1.Value = this.spPeriodoTotalEncaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reporte.Reporteperiodosenca.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 626);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_PeriodoTotalEncaTableAdapter
            // 
            this.sp_PeriodoTotalEncaTableAdapter.ClearBeforeFill = true;
            // 
            // periodosenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "periodosenca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmperiodocoordinacion";
            this.Load += new System.EventHandler(this.frmperiodocoordinacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalEncaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEnca)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private periodoEnca periodoEnca;
        private System.Windows.Forms.BindingSource spPeriodoTotalEncaBindingSource;
        private periodoEncaTableAdapters.sp_PeriodoTotalEncaTableAdapter sp_PeriodoTotalEncaTableAdapter;
    }
}