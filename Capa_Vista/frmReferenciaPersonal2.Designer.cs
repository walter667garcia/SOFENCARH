namespace Capa_Vista
{
    partial class frmReferenciaPersonal2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReferenciaPersonal2));
            this.tabReferenciaPersonal = new System.Windows.Forms.TabControl();
            this.tabDatosLista = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgReferenciaPersonal = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tabFormulario = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRelacion = new System.Windows.Forms.TextBox();
            this.lbRelacion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPersona = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbTitulo = new System.Windows.Forms.PictureBox();
            this.tabReferenciaPersonal.SuspendLayout();
            this.tabDatosLista.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReferenciaPersonal)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReferenciaPersonal
            // 
            this.tabReferenciaPersonal.Controls.Add(this.tabDatosLista);
            this.tabReferenciaPersonal.Controls.Add(this.tabFormulario);
            this.tabReferenciaPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReferenciaPersonal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabReferenciaPersonal.Location = new System.Drawing.Point(0, 0);
            this.tabReferenciaPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabReferenciaPersonal.Name = "tabReferenciaPersonal";
            this.tabReferenciaPersonal.SelectedIndex = 0;
            this.tabReferenciaPersonal.Size = new System.Drawing.Size(638, 583);
            this.tabReferenciaPersonal.TabIndex = 1;
            // 
            // tabDatosLista
            // 
            this.tabDatosLista.Controls.Add(this.panel2);
            this.tabDatosLista.Controls.Add(this.panel1);
            this.tabDatosLista.Location = new System.Drawing.Point(4, 34);
            this.tabDatosLista.Name = "tabDatosLista";
            this.tabDatosLista.Size = new System.Drawing.Size(630, 545);
            this.tabDatosLista.TabIndex = 2;
            this.tabDatosLista.Text = "DatosLIsta";
            this.tabDatosLista.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgReferenciaPersonal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 487);
            this.panel2.TabIndex = 1;
            // 
            // dtgReferenciaPersonal
            // 
            this.dtgReferenciaPersonal.AllowUserToAddRows = false;
            this.dtgReferenciaPersonal.AllowUserToDeleteRows = false;
            this.dtgReferenciaPersonal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtgReferenciaPersonal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgReferenciaPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgReferenciaPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dtgReferenciaPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgReferenciaPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgReferenciaPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReferenciaPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgReferenciaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReferenciaPersonal.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReferenciaPersonal.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgReferenciaPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgReferenciaPersonal.GridColor = System.Drawing.SystemColors.GrayText;
            this.dtgReferenciaPersonal.Location = new System.Drawing.Point(0, 0);
            this.dtgReferenciaPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgReferenciaPersonal.MultiSelect = false;
            this.dtgReferenciaPersonal.Name = "dtgReferenciaPersonal";
            this.dtgReferenciaPersonal.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReferenciaPersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgReferenciaPersonal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgReferenciaPersonal.RowTemplate.Height = 24;
            this.dtgReferenciaPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReferenciaPersonal.Size = new System.Drawing.Size(630, 487);
            this.dtgReferenciaPersonal.TabIndex = 54;
            this.dtgReferenciaPersonal.DoubleClick += new System.EventHandler(this.dtgReferenciaPersonal_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPersona);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 58);
            this.panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(494, 21);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 25);
            this.lblTotal.TabIndex = 53;
            this.lblTotal.Text = "label1";
            // 
            // tabFormulario
            // 
            this.tabFormulario.Controls.Add(this.btnCancelar);
            this.tabFormulario.Controls.Add(this.btnEditar);
            this.tabFormulario.Controls.Add(this.btnGuardar);
            this.tabFormulario.Controls.Add(this.btnNuevo);
            this.tabFormulario.Controls.Add(this.button1);
            this.tabFormulario.Controls.Add(this.txtId);
            this.tabFormulario.Controls.Add(this.txtRelacion);
            this.tabFormulario.Controls.Add(this.lbRelacion);
            this.tabFormulario.Controls.Add(this.txtTelefono);
            this.tabFormulario.Controls.Add(this.label4);
            this.tabFormulario.Controls.Add(this.txtNombre);
            this.tabFormulario.Controls.Add(this.label3);
            this.tabFormulario.Location = new System.Drawing.Point(4, 34);
            this.tabFormulario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormulario.Name = "tabFormulario";
            this.tabFormulario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFormulario.Size = new System.Drawing.Size(630, 545);
            this.tabFormulario.TabIndex = 1;
            this.tabFormulario.Text = "Formulario";
            this.tabFormulario.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(427, 371);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 70);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(209, 371);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(63, 70);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(312, 371);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(63, 70);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(111, 371);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 70);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(82, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Crear Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(494, 13);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(41, 33);
            this.txtId.TabIndex = 50;
            this.txtId.Visible = false;
            // 
            // txtRelacion
            // 
            this.txtRelacion.ForeColor = System.Drawing.Color.Black;
            this.txtRelacion.Location = new System.Drawing.Point(111, 272);
            this.txtRelacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRelacion.Name = "txtRelacion";
            this.txtRelacion.Size = new System.Drawing.Size(412, 33);
            this.txtRelacion.TabIndex = 49;
            this.txtRelacion.TextChanged += new System.EventHandler(this.txtRelacion_TextChanged);
            // 
            // lbRelacion
            // 
            this.lbRelacion.AutoSize = true;
            this.lbRelacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbRelacion.Location = new System.Drawing.Point(112, 244);
            this.lbRelacion.Name = "lbRelacion";
            this.lbRelacion.Size = new System.Drawing.Size(242, 25);
            this.lbRelacion.TabIndex = 48;
            this.lbRelacion.Text = "Relación con esta persona:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(117, 167);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(406, 33);
            this.txtTelefono.TabIndex = 47;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(112, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(117, 77);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(406, 33);
            this.txtNombre.TabIndex = 45;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(112, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nombre de persona que da referencia:";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.pcbTitulo);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 67);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabReferenciaPersonal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 583);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = ".: REFERENCIA PERSONAL :.";
            // 
            // lbPersona
            // 
            this.lbPersona.AutoSize = true;
            this.lbPersona.Location = new System.Drawing.Point(8, 21);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(98, 25);
            this.lbPersona.TabIndex = 54;
            this.lbPersona.Text = "lbPersona";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(576, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbTitulo
            // 
            this.pcbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pcbTitulo.Image")));
            this.pcbTitulo.Location = new System.Drawing.Point(3, 3);
            this.pcbTitulo.Name = "pcbTitulo";
            this.pcbTitulo.Size = new System.Drawing.Size(58, 51);
            this.pcbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTitulo.TabIndex = 19;
            this.pcbTitulo.TabStop = false;
            // 
            // frmReferenciaPersonal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 650);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReferenciaPersonal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Referencia Personal.";
            this.Load += new System.EventHandler(this.frmReferenciaPersonal_Load);
            this.tabReferenciaPersonal.ResumeLayout(false);
            this.tabDatosLista.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReferenciaPersonal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFormulario.ResumeLayout(false);
            this.tabFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReferenciaPersonal;
        private System.Windows.Forms.TabPage tabFormulario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtRelacion;
        private System.Windows.Forms.Label lbRelacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabDatosLista;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgReferenciaPersonal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPersona;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbTitulo;
    }
}