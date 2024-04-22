namespace Capa_Vista.Reporte
{
    partial class periodosPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(periodosPersona));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spPeriodoTotalPersonaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.periodoEnca = new Capa_Vista.Reporte.periodoEnca();
            this.spPeriodoTotalPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_PeriodoTotalPersonaTableAdapter = new Capa_Vista.Reporte.periodoEncaTableAdapters.sp_PeriodoTotalPersonaTableAdapter();
            this.spPeriodoTotalPersonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PeriodoTotalPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.periodoEncaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalPersonaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEnca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalPersonaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalPersonaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PeriodoTotalPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEncaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spPeriodoTotalPersonaBindingSource2
            // 
            this.spPeriodoTotalPersonaBindingSource2.DataMember = "sp_PeriodoTotalPersona";
            this.spPeriodoTotalPersonaBindingSource2.DataSource = this.periodoEnca;
            // 
            // periodoEnca
            // 
            this.periodoEnca.DataSetName = "periodoEnca";
            this.periodoEnca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spPeriodoTotalPersonaBindingSource
            // 
            this.spPeriodoTotalPersonaBindingSource.DataMember = "sp_PeriodoTotalPersona";
            this.spPeriodoTotalPersonaBindingSource.DataSource = this.periodoEnca;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(693, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 659);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spPeriodoTotalPersonaBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Vista.Reporte.Reporteperidospersona.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 659);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_PeriodoTotalPersonaTableAdapter
            // 
            this.sp_PeriodoTotalPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // spPeriodoTotalPersonaBindingSource1
            // 
            this.spPeriodoTotalPersonaBindingSource1.DataMember = "sp_PeriodoTotalPersona";
            this.spPeriodoTotalPersonaBindingSource1.DataSource = this.periodoEnca;
            // 
            // sp_PeriodoTotalPersonaBindingSource
            // 
            this.sp_PeriodoTotalPersonaBindingSource.DataMember = "sp_PeriodoTotalPersona";
            this.sp_PeriodoTotalPersonaBindingSource.DataSource = this.periodoEnca;
            // 
            // periodoEncaBindingSource
            // 
            this.periodoEncaBindingSource.DataSource = this.periodoEnca;
            this.periodoEncaBindingSource.Position = 0;
            // 
            // periodosPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 725);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "periodosPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "periodosPersona";
            this.Load += new System.EventHandler(this.periodosPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalPersonaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEnca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalPersonaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spPeriodoTotalPersonaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PeriodoTotalPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoEncaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource spPeriodoTotalPersonaBindingSource;
        private periodoEnca periodoEnca;
        private periodoEncaTableAdapters.sp_PeriodoTotalPersonaTableAdapter sp_PeriodoTotalPersonaTableAdapter;
        private System.Windows.Forms.BindingSource spPeriodoTotalPersonaBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_PeriodoTotalPersonaBindingSource;
        private System.Windows.Forms.BindingSource spPeriodoTotalPersonaBindingSource2;
        private System.Windows.Forms.BindingSource periodoEncaBindingSource;
    }
}