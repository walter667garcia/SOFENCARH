namespace Capa_Vista.Usuario
{
    partial class frmUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbNuevo = new System.Windows.Forms.PictureBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgPersona = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNuevo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersona)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 553);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1182, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgUsuarios);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 443);
            this.panel3.TabIndex = 1;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgUsuarios.GridColor = System.Drawing.SystemColors.GrayText;
            this.dtgUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dtgUsuarios.MultiSelect = false;
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(1168, 443);
            this.dtgUsuarios.TabIndex = 16;
            this.dtgUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgUsuarios_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pcbNuevo);
            this.panel1.Controls.Add(this.btnlimpiar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBuscarUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 69);
            this.panel1.TabIndex = 0;
            // 
            // pcbNuevo
            // 
            this.pcbNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("pcbNuevo.Image")));
            this.pcbNuevo.Location = new System.Drawing.Point(988, 5);
            this.pcbNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbNuevo.Name = "pcbNuevo";
            this.pcbNuevo.Size = new System.Drawing.Size(65, 57);
            this.pcbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNuevo.TabIndex = 16;
            this.pcbNuevo.TabStop = false;
            this.pcbNuevo.Click += new System.EventHandler(this.pcbNuevo_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.BackgroundImage")));
            this.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnlimpiar.Location = new System.Drawing.Point(598, 9);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(58, 49);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.CausesValidation = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1094, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 52);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(539, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 47);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Buscar Usuario:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BackColor = System.Drawing.Color.White;
            this.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarUsuario.Location = new System.Drawing.Point(145, 17);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(363, 34);
            this.txtBuscarUsuario.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgPersona);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1174, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgPersona
            // 
            this.dtgPersona.AllowUserToAddRows = false;
            this.dtgPersona.AllowUserToDeleteRows = false;
            this.dtgPersona.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dtgPersona.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgPersona.BackgroundColor = System.Drawing.Color.White;
            this.dtgPersona.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgPersona.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgPersona.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPersona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersona.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPersona.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPersona.GridColor = System.Drawing.SystemColors.GrayText;
            this.dtgPersona.Location = new System.Drawing.Point(3, 63);
            this.dtgPersona.Margin = new System.Windows.Forms.Padding(4);
            this.dtgPersona.MultiSelect = false;
            this.dtgPersona.Name = "dtgPersona";
            this.dtgPersona.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPersona.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgPersona.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgPersona.RowTemplate.Height = 24;
            this.dtgPersona.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPersona.Size = new System.Drawing.Size(1168, 452);
            this.dtgPersona.TabIndex = 18;
            this.dtgPersona.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgPersona_MouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtBuscarPersona);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 60);
            this.panel4.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Location = new System.Drawing.Point(732, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 44);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.CausesValidation = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1094, 1);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 52);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(673, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 47);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Persona:";
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.BackColor = System.Drawing.Color.White;
            this.txtBuscarPersona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarPersona.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscarPersona.Location = new System.Drawing.Point(191, 13);
            this.txtBuscarPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(475, 34);
            this.txtBuscarPersona.TabIndex = 11;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNuevo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersona)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgPersona;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pcbNuevo;
    }
}