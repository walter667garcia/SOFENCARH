namespace Capa_Vista
{
    partial class frmDatosAdicionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosAdicionales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Inicio = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgDatosAdicionales = new System.Windows.Forms.DataGridView();
            this.lbpersona = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtIdHome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtParentesco = new System.Windows.Forms.TextBox();
            this.txtEmergencia = new System.Windows.Forms.TextBox();
            this.btnGuardarHome = new System.Windows.Forms.Button();
            this.lbRelacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAdicional = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.Inicio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosAdicionales)).BeginInit();
            this.tabAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos adicionales.";
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.White;
            this.Inicio.Controls.Add(this.panel1);
            this.Inicio.Controls.Add(this.button1);
            this.Inicio.Controls.Add(this.label5);
            this.Inicio.Controls.Add(this.dtgDatosAdicionales);
            this.Inicio.Controls.Add(this.lbpersona);
            this.Inicio.Controls.Add(this.lblTotal);
            this.Inicio.Controls.Add(this.txtBuscar);
            this.Inicio.Controls.Add(this.txtIdHome);
            this.Inicio.Controls.Add(this.txtId);
            this.Inicio.Controls.Add(this.txtTelefono);
            this.Inicio.Controls.Add(this.txtParentesco);
            this.Inicio.Controls.Add(this.txtEmergencia);
            this.Inicio.Controls.Add(this.btnGuardarHome);
            this.Inicio.Controls.Add(this.lbRelacion);
            this.Inicio.Controls.Add(this.label4);
            this.Inicio.Controls.Add(this.label3);
            this.Inicio.Controls.Add(this.cmbPersona);
            this.Inicio.Controls.Add(this.label2);
            this.Inicio.Location = new System.Drawing.Point(4, 32);
            this.Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.Inicio.Name = "Inicio";
            this.Inicio.Padding = new System.Windows.Forms.Padding(2);
            this.Inicio.Size = new System.Drawing.Size(631, 511);
            this.Inicio.TabIndex = 1;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Location = new System.Drawing.Point(151, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 73);
            this.panel1.TabIndex = 59;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(24, 10);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 53);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(100, 9);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 51);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(271, 12);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 51);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(186, 11);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(52, 51);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(519, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "Crear Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(2, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "Busqueda por nombre de persona:";
            // 
            // dtgDatosAdicionales
            // 
            this.dtgDatosAdicionales.AllowUserToAddRows = false;
            this.dtgDatosAdicionales.AllowUserToDeleteRows = false;
            this.dtgDatosAdicionales.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgDatosAdicionales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDatosAdicionales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgDatosAdicionales.BackgroundColor = System.Drawing.Color.White;
            this.dtgDatosAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgDatosAdicionales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dtgDatosAdicionales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatosAdicionales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDatosAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosAdicionales.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgDatosAdicionales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgDatosAdicionales.GridColor = System.Drawing.SystemColors.GrayText;
            this.dtgDatosAdicionales.Location = new System.Drawing.Point(2, 298);
            this.dtgDatosAdicionales.Margin = new System.Windows.Forms.Padding(2);
            this.dtgDatosAdicionales.MultiSelect = false;
            this.dtgDatosAdicionales.Name = "dtgDatosAdicionales";
            this.dtgDatosAdicionales.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgDatosAdicionales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgDatosAdicionales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgDatosAdicionales.RowTemplate.Height = 24;
            this.dtgDatosAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatosAdicionales.Size = new System.Drawing.Size(627, 211);
            this.dtgDatosAdicionales.TabIndex = 57;
            this.dtgDatosAdicionales.DoubleClick += new System.EventHandler(this.dtgDatosAdicionales_DoubleClick);
            // 
            // lbpersona
            // 
            this.lbpersona.AutoSize = true;
            this.lbpersona.Enabled = false;
            this.lbpersona.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbpersona.Location = new System.Drawing.Point(32, 160);
            this.lbpersona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpersona.Name = "lbpersona";
            this.lbpersona.Size = new System.Drawing.Size(61, 23);
            this.lbpersona.TabIndex = 56;
            this.lbpersona.Text = "label5";
            this.lbpersona.Visible = false;
            this.lbpersona.Click += new System.EventHandler(this.lbpersona_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTotal.Location = new System.Drawing.Point(368, 251);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 23);
            this.lblTotal.TabIndex = 54;
            this.lblTotal.Text = "label1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(10, 251);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(345, 31);
            this.txtBuscar.TabIndex = 53;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtIdHome
            // 
            this.txtIdHome.Enabled = false;
            this.txtIdHome.Location = new System.Drawing.Point(58, 157);
            this.txtIdHome.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdHome.Name = "txtIdHome";
            this.txtIdHome.Size = new System.Drawing.Size(13, 31);
            this.txtIdHome.TabIndex = 51;
            this.txtIdHome.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(58, 160);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(18, 31);
            this.txtId.TabIndex = 50;
            this.txtId.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(346, 79);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(268, 28);
            this.txtTelefono.TabIndex = 49;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtParentesco
            // 
            this.txtParentesco.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParentesco.ForeColor = System.Drawing.Color.Black;
            this.txtParentesco.Location = new System.Drawing.Point(6, 79);
            this.txtParentesco.Margin = new System.Windows.Forms.Padding(2);
            this.txtParentesco.Multiline = true;
            this.txtParentesco.Name = "txtParentesco";
            this.txtParentesco.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParentesco.Size = new System.Drawing.Size(319, 46);
            this.txtParentesco.TabIndex = 47;
            this.txtParentesco.TextChanged += new System.EventHandler(this.txtParentesco_TextChanged);
            // 
            // txtEmergencia
            // 
            this.txtEmergencia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencia.ForeColor = System.Drawing.Color.Black;
            this.txtEmergencia.Location = new System.Drawing.Point(346, 26);
            this.txtEmergencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmergencia.Name = "txtEmergencia";
            this.txtEmergencia.Size = new System.Drawing.Size(268, 28);
            this.txtEmergencia.TabIndex = 45;
            this.txtEmergencia.TextChanged += new System.EventHandler(this.txtEmergencia_TextChanged);
            // 
            // btnGuardarHome
            // 
            this.btnGuardarHome.Enabled = false;
            this.btnGuardarHome.Location = new System.Drawing.Point(53, 158);
            this.btnGuardarHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarHome.Name = "btnGuardarHome";
            this.btnGuardarHome.Size = new System.Drawing.Size(31, 38);
            this.btnGuardarHome.TabIndex = 52;
            this.btnGuardarHome.TabStop = false;
            this.btnGuardarHome.Text = "button1";
            this.btnGuardarHome.UseVisualStyleBackColor = true;
            this.btnGuardarHome.Visible = false;
            this.btnGuardarHome.Click += new System.EventHandler(this.btnGuardarHome_Click);
            // 
            // lbRelacion
            // 
            this.lbRelacion.AutoSize = true;
            this.lbRelacion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbRelacion.Location = new System.Drawing.Point(342, 56);
            this.lbRelacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRelacion.Name = "lbRelacion";
            this.lbRelacion.Size = new System.Drawing.Size(73, 21);
            this.lbRelacion.TabIndex = 48;
            this.lbRelacion.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Parentesco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(342, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "En caso de emergencia avisar a:";
            // 
            // cmbPersona
            // 
            this.cmbPersona.Enabled = false;
            this.cmbPersona.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersona.ForeColor = System.Drawing.Color.Black;
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(6, 25);
            this.cmbPersona.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(319, 29);
            this.cmbPersona.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Persona:";
            // 
            // tabAdicional
            // 
            this.tabAdicional.Controls.Add(this.Inicio);
            this.tabAdicional.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdicional.Location = new System.Drawing.Point(4, 7);
            this.tabAdicional.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdicional.Name = "tabAdicional";
            this.tabAdicional.SelectedIndex = 0;
            this.tabAdicional.Size = new System.Drawing.Size(639, 547);
            this.tabAdicional.TabIndex = 0;
            // 
            // frmDatosAdicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(647, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabAdicional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDatosAdicionales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Adicionales.";
            this.Load += new System.EventHandler(this.frmDatosAdicionales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.Inicio.ResumeLayout(false);
            this.Inicio.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosAdicionales)).EndInit();
            this.tabAdicional.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabAdicional;
        private System.Windows.Forms.TabPage Inicio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtIdHome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtParentesco;
        private System.Windows.Forms.TextBox txtEmergencia;
        private System.Windows.Forms.Button btnGuardarHome;
        private System.Windows.Forms.Label lbRelacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbpersona;
        private System.Windows.Forms.DataGridView dtgDatosAdicionales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}