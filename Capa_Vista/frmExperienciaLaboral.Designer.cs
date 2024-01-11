namespace Capa_Vista
{
    partial class frmExperienciaLaboral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExperienciaLaboral));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgExperienciaLaboral = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtmFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJefe = new System.Windows.Forms.TextBox();
            this.lbjefe = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExperienciaLaboral)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1479, 773);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgExperienciaLaboral);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1471, 744);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgExperienciaLaboral
            // 
            this.dtgExperienciaLaboral.BackgroundColor = System.Drawing.Color.White;
            this.dtgExperienciaLaboral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExperienciaLaboral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgExperienciaLaboral.Location = new System.Drawing.Point(3, 80);
            this.dtgExperienciaLaboral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgExperienciaLaboral.Name = "dtgExperienciaLaboral";
            this.dtgExperienciaLaboral.RowHeadersWidth = 51;
            this.dtgExperienciaLaboral.RowTemplate.Height = 24;
            this.dtgExperienciaLaboral.Size = new System.Drawing.Size(1465, 661);
            this.dtgExperienciaLaboral.TabIndex = 2;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(665, 30);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 16);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "label1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(310, 22);
            this.txtBuscar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtMotivo);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtmFechaRetiro);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtmFechaIngreso);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtSalario);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtPuesto);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtJefe);
            this.tabPage2.Controls.Add(this.lbjefe);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEmpresa);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbPersona);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1471, 744);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(767, 36);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 53;
            this.txtId.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(432, 379);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(218, 22);
            this.txtDescripcion.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "DESCRIPCION";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(439, 297);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(211, 22);
            this.txtMotivo.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "MOTIVO DE RETIRO";
            // 
            // dtmFechaRetiro
            // 
            this.dtmFechaRetiro.Location = new System.Drawing.Point(439, 230);
            this.dtmFechaRetiro.Name = "dtmFechaRetiro";
            this.dtmFechaRetiro.Size = new System.Drawing.Size(200, 22);
            this.dtmFechaRetiro.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "FECHA / RETIRO";
            // 
            // dtmFechaIngreso
            // 
            this.dtmFechaIngreso.Location = new System.Drawing.Point(439, 162);
            this.dtmFechaIngreso.Name = "dtmFechaIngreso";
            this.dtmFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtmFechaIngreso.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "FECHA / INGRESO";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(439, 72);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(211, 22);
            this.txtSalario.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "SALARIO";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(81, 379);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(211, 22);
            this.txtPuesto.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "PUESTO";
            // 
            // txtJefe
            // 
            this.txtJefe.Location = new System.Drawing.Point(84, 307);
            this.txtJefe.Name = "txtJefe";
            this.txtJefe.Size = new System.Drawing.Size(211, 22);
            this.txtJefe.TabIndex = 40;
            // 
            // lbjefe
            // 
            this.lbjefe.AutoSize = true;
            this.lbjefe.Location = new System.Drawing.Point(84, 278);
            this.lbjefe.Name = "lbjefe";
            this.lbjefe.Size = new System.Drawing.Size(40, 16);
            this.lbjefe.TabIndex = 39;
            this.lbjefe.Text = "JEFE";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(84, 230);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(211, 22);
            this.txtTelefono.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "TELEFONO";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(87, 162);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(211, 22);
            this.txtEmpresa.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "EMPRESA";
            // 
            // cmbPersona
            // 
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(87, 78);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(211, 24);
            this.cmbPersona.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "PERSONA";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(525, 482);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 63);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(385, 482);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 63);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(129, 482);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 63);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(253, 482);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 63);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmExperienciaLaboral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 810);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmExperienciaLaboral";
            this.Text = "frmExperienciaLaboral";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExperienciaLaboral)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgExperienciaLaboral;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJefe;
        private System.Windows.Forms.Label lbjefe;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtmFechaRetiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmFechaIngreso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
    }
}