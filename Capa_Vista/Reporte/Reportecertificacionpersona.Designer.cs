namespace Capa_Vista.Reporte
{
    partial class Reportecertificacionpersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportecertificacionpersona));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.periodoEnca = new Capa_Vista.Reporte.periodoEnca();
            this.spcertificacionpersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_certificacionpersonaTableAdapter = new Capa_Vista.Reporte.periodoEncaTableAdapters.sp_certificacionpersonaTableAdapter();
            this.spcertificacionperidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_certificacionperidosTableAdapter = new Capa_Vista.Reporte.periodoEncaTableAdapters.sp_certificacionperidosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEnca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcertificacionpersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcertificacionperidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(704, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 700);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Persona";
            reportDataSource1.Value = this.spcertificacionpersonaBindingSource;
            reportDataSource2.Name = "Periodo";
            reportDataSource2.Value = this.spcertificacionperidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reporte.certificacionempleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(828, 700);
            this.reportViewer1.TabIndex = 0;
            // 
            // periodoEnca
            // 
            this.periodoEnca.DataSetName = "periodoEnca";
            this.periodoEnca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spcertificacionpersonaBindingSource
            // 
            this.spcertificacionpersonaBindingSource.DataMember = "sp_certificacionpersona";
            this.spcertificacionpersonaBindingSource.DataSource = this.periodoEnca;
            // 
            // sp_certificacionpersonaTableAdapter
            // 
            this.sp_certificacionpersonaTableAdapter.ClearBeforeFill = true;
            // 
            // spcertificacionperidosBindingSource
            // 
            this.spcertificacionperidosBindingSource.DataMember = "sp_certificacionperidos";
            this.spcertificacionperidosBindingSource.DataSource = this.periodoEnca;
            // 
            // sp_certificacionperidosTableAdapter
            // 
            this.sp_certificacionperidosTableAdapter.ClearBeforeFill = true;
            // 
            // Reportecertificacionpersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Reportecertificacionpersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportecertificacionpersona";
            this.Load += new System.EventHandler(this.Reportecertificacionpersona_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.periodoEnca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcertificacionpersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcertificacionperidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.BindingSource spcertificacionpersonaBindingSource;
        private periodoEnca periodoEnca;
        private System.Windows.Forms.BindingSource spcertificacionperidosBindingSource;
        private periodoEncaTableAdapters.sp_certificacionpersonaTableAdapter sp_certificacionpersonaTableAdapter;
        private periodoEncaTableAdapters.sp_certificacionperidosTableAdapter sp_certificacionperidosTableAdapter;
    }
}