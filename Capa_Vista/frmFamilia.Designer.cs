namespace Capa_Vista
{
    partial class frmFamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFamilia));
            this.tabMantenimiento = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgTFamilia = new System.Windows.Forms.DataGridView();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdFAmilia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.txtTelTrabajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDTrabajo = new System.Windows.Forms.TextBox();
            this.txtLTrabajo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbTFamilia = new System.Windows.Forms.ComboBox();
            this.cmbIdPersona = new System.Windows.Forms.ComboBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabMantenimiento.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTFamilia)).BeginInit();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.tabPage1);
            this.tabMantenimiento.Controls.Add(this.tab1);
            this.tabMantenimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMantenimiento.Location = new System.Drawing.Point(12, 42);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.SelectedIndex = 0;
            this.tabMantenimiento.Size = new System.Drawing.Size(1522, 589);
            this.tabMantenimiento.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.dtgTFamilia);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1514, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(530, 59);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 28);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "label10";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.Location = new System.Drawing.Point(30, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(385, 34);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtgTFamilia
            // 
            this.dtgTFamilia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTFamilia.BackgroundColor = System.Drawing.Color.White;
            this.dtgTFamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTFamilia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgTFamilia.Location = new System.Drawing.Point(3, 123);
            this.dtgTFamilia.Name = "dtgTFamilia";
            this.dtgTFamilia.RowHeadersWidth = 51;
            this.dtgTFamilia.RowTemplate.Height = 24;
            this.dtgTFamilia.Size = new System.Drawing.Size(1508, 422);
            this.dtgTFamilia.TabIndex = 0;
            this.dtgTFamilia.DoubleClick += new System.EventHandler(this.dtgTFamilia_DoubleClick);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.dtmFecha);
            this.tab1.Controls.Add(this.btnCancelar);
            this.tab1.Controls.Add(this.btnEditar);
            this.tab1.Controls.Add(this.btnNuevo);
            this.tab1.Controls.Add(this.btnGuardar);
            this.tab1.Controls.Add(this.txtIdFAmilia);
            this.tab1.Controls.Add(this.label9);
            this.tab1.Controls.Add(this.label8);
            this.tab1.Controls.Add(this.label7);
            this.tab1.Controls.Add(this.label6);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.txtOcupacion);
            this.tab1.Controls.Add(this.txtTelTrabajo);
            this.tab1.Controls.Add(this.txtNombre);
            this.tab1.Controls.Add(this.txtDTrabajo);
            this.tab1.Controls.Add(this.txtLTrabajo);
            this.tab1.Controls.Add(this.txtTelefono);
            this.tab1.Controls.Add(this.cmbTFamilia);
            this.tab1.Controls.Add(this.cmbIdPersona);
            this.tab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab1.Location = new System.Drawing.Point(4, 37);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(1514, 548);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Mantenimiento";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // dtmFecha
            // 
            this.dtmFecha.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtmFecha.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dtmFecha.CalendarTitleBackColor = System.Drawing.Color.IndianRed;
            this.dtmFecha.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtmFecha.CalendarTrailingForeColor = System.Drawing.Color.PapayaWhip;
            this.dtmFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtmFecha.CustomFormat = "dddd, MMMM dd, yyyy";
            this.dtmFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmFecha.Location = new System.Drawing.Point(1145, 73);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(343, 34);
            this.dtmFecha.TabIndex = 47;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(885, 366);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 63);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(745, 366);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 63);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(489, 366);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 63);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(613, 366);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 63);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdFAmilia
            // 
            this.txtIdFAmilia.Enabled = false;
            this.txtIdFAmilia.Location = new System.Drawing.Point(1329, 6);
            this.txtIdFAmilia.Name = "txtIdFAmilia";
            this.txtIdFAmilia.Size = new System.Drawing.Size(112, 34);
            this.txtIdFAmilia.TabIndex = 24;
            this.txtIdFAmilia.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1140, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "TELEFONO TRABAJO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "DIRECCION DE TRABAJO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "LUGAR DE TRABAJO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1140, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "OCUPACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1117, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "FECHA NACIMIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "TIPO FAMILIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "PERSONA";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.BackColor = System.Drawing.Color.White;
            this.txtOcupacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOcupacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOcupacion.Location = new System.Drawing.Point(572, 73);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(436, 34);
            this.txtOcupacion.TabIndex = 8;
            // 
            // txtTelTrabajo
            // 
            this.txtTelTrabajo.BackColor = System.Drawing.Color.White;
            this.txtTelTrabajo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelTrabajo.Location = new System.Drawing.Point(1145, 275);
            this.txtTelTrabajo.Name = "txtTelTrabajo";
            this.txtTelTrabajo.Size = new System.Drawing.Size(283, 34);
            this.txtTelTrabajo.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(46, 275);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtNombre.Size = new System.Drawing.Size(436, 34);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDTrabajo
            // 
            this.txtDTrabajo.BackColor = System.Drawing.Color.White;
            this.txtDTrabajo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDTrabajo.Location = new System.Drawing.Point(572, 275);
            this.txtDTrabajo.Name = "txtDTrabajo";
            this.txtDTrabajo.Size = new System.Drawing.Size(488, 34);
            this.txtDTrabajo.TabIndex = 4;
            // 
            // txtLTrabajo
            // 
            this.txtLTrabajo.BackColor = System.Drawing.Color.White;
            this.txtLTrabajo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLTrabajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLTrabajo.Location = new System.Drawing.Point(572, 182);
            this.txtLTrabajo.Name = "txtLTrabajo";
            this.txtLTrabajo.Size = new System.Drawing.Size(488, 34);
            this.txtLTrabajo.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.Location = new System.Drawing.Point(1145, 184);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(283, 34);
            this.txtTelefono.TabIndex = 2;
            // 
            // cmbTFamilia
            // 
            this.cmbTFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTFamilia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTFamilia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTFamilia.FormattingEnabled = true;
            this.cmbTFamilia.Location = new System.Drawing.Point(46, 182);
            this.cmbTFamilia.Name = "cmbTFamilia";
            this.cmbTFamilia.Size = new System.Drawing.Size(436, 36);
            this.cmbTFamilia.TabIndex = 1;
            // 
            // cmbIdPersona
            // 
            this.cmbIdPersona.BackColor = System.Drawing.Color.White;
            this.cmbIdPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdPersona.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbIdPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbIdPersona.FormattingEnabled = true;
            this.errorIcono.SetIconAlignment(this.cmbIdPersona, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.cmbIdPersona.Location = new System.Drawing.Point(46, 84);
            this.cmbIdPersona.Name = "cmbIdPersona";
            this.cmbIdPersona.Size = new System.Drawing.Size(436, 36);
            this.cmbIdPersona.TabIndex = 0;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 773);
            this.Controls.Add(this.tabMantenimiento);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFamilia";
            this.Text = "RHFAMILIA";
            this.Load += new System.EventHandler(this.frmFamilia_Load);
            this.tabMantenimiento.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTFamilia)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMantenimiento;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgTFamilia;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.TextBox txtTelTrabajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDTrabajo;
        private System.Windows.Forms.TextBox txtLTrabajo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbTFamilia;
        private System.Windows.Forms.ComboBox cmbIdPersona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtIdFAmilia;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtmFecha;
    }
}