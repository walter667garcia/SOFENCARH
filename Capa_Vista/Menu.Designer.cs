namespace SOFENCARH
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.mostrarFamiliasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbMantenimiento = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMenuVacaciones = new System.Windows.Forms.Panel();
            this.pcbMenuVacaciones = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMenuActas = new System.Windows.Forms.Panel();
            this.pcbMenuActas = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMenuUsuarios = new System.Windows.Forms.Panel();
            this.pcbMenuUsuarios = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnMenuEmpleado = new System.Windows.Forms.Panel();
            this.pcbMenuEmpleados = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnClose = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarFamiliasBindingSource)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMantenimiento)).BeginInit();
            this.pnlMenuVacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuVacaciones)).BeginInit();
            this.pnlMenuActas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuActas)).BeginInit();
            this.pnlMenuUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuUsuarios)).BeginInit();
            this.pnMenuEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuEmpleados)).BeginInit();
            this.pnClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlTitulo.Controls.Add(this.label7);
            this.pnlTitulo.Controls.Add(this.button2);
            this.pnlTitulo.Controls.Add(this.label2);
            this.pnlTitulo.Controls.Add(this.pictureBox3);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1239, 81);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseDown);
            this.pnlTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseMove);
            this.pnlTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitulo_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "ENCA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 72);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.DarkGray;
            this.pnlmenu.Controls.Add(this.panel1);
            this.pnlmenu.Controls.Add(this.pnlMenuVacaciones);
            this.pnlmenu.Controls.Add(this.pnlMenuActas);
            this.pnlmenu.Controls.Add(this.pnlMenuUsuarios);
            this.pnlmenu.Controls.Add(this.pnMenuEmpleado);
            this.pnlmenu.Controls.Add(this.pnClose);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 81);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(322, 750);
            this.pnlmenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pcbMantenimiento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 57);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // pcbMantenimiento
            // 
            this.pcbMantenimiento.BackColor = System.Drawing.Color.White;
            this.pcbMantenimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("pcbMantenimiento.Image")));
            this.pcbMantenimiento.Location = new System.Drawing.Point(16, 3);
            this.pcbMantenimiento.Name = "pcbMantenimiento";
            this.pcbMantenimiento.Size = new System.Drawing.Size(70, 46);
            this.pcbMantenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMantenimiento.TabIndex = 0;
            this.pcbMantenimiento.TabStop = false;
            this.pcbMantenimiento.Click += new System.EventHandler(this.pcbMantenimiento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(94, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mantenimiento";
            // 
            // pnlMenuVacaciones
            // 
            this.pnlMenuVacaciones.Controls.Add(this.pcbMenuVacaciones);
            this.pnlMenuVacaciones.Controls.Add(this.label5);
            this.pnlMenuVacaciones.Location = new System.Drawing.Point(3, 305);
            this.pnlMenuVacaciones.Name = "pnlMenuVacaciones";
            this.pnlMenuVacaciones.Size = new System.Drawing.Size(316, 57);
            this.pnlMenuVacaciones.TabIndex = 5;
            // 
            // pcbMenuVacaciones
            // 
            this.pcbMenuVacaciones.BackColor = System.Drawing.Color.White;
            this.pcbMenuVacaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMenuVacaciones.Image = ((System.Drawing.Image)(resources.GetObject("pcbMenuVacaciones.Image")));
            this.pcbMenuVacaciones.Location = new System.Drawing.Point(16, 8);
            this.pcbMenuVacaciones.Name = "pcbMenuVacaciones";
            this.pcbMenuVacaciones.Size = new System.Drawing.Size(70, 46);
            this.pcbMenuVacaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMenuVacaciones.TabIndex = 0;
            this.pcbMenuVacaciones.TabStop = false;
            this.pcbMenuVacaciones.Click += new System.EventHandler(this.pcbMenuVacaciones_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(94, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vacaciones";
            // 
            // pnlMenuActas
            // 
            this.pnlMenuActas.Controls.Add(this.pcbMenuActas);
            this.pnlMenuActas.Controls.Add(this.label4);
            this.pnlMenuActas.Location = new System.Drawing.Point(3, 245);
            this.pnlMenuActas.Name = "pnlMenuActas";
            this.pnlMenuActas.Size = new System.Drawing.Size(316, 57);
            this.pnlMenuActas.TabIndex = 4;
            // 
            // pcbMenuActas
            // 
            this.pcbMenuActas.BackColor = System.Drawing.Color.White;
            this.pcbMenuActas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMenuActas.Image = ((System.Drawing.Image)(resources.GetObject("pcbMenuActas.Image")));
            this.pcbMenuActas.Location = new System.Drawing.Point(16, 8);
            this.pcbMenuActas.Name = "pcbMenuActas";
            this.pcbMenuActas.Size = new System.Drawing.Size(70, 46);
            this.pcbMenuActas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMenuActas.TabIndex = 0;
            this.pcbMenuActas.TabStop = false;
            this.pcbMenuActas.Click += new System.EventHandler(this.pcbMenuActas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Actas";
            // 
            // pnlMenuUsuarios
            // 
            this.pnlMenuUsuarios.Controls.Add(this.pcbMenuUsuarios);
            this.pnlMenuUsuarios.Controls.Add(this.label3);
            this.pnlMenuUsuarios.Location = new System.Drawing.Point(3, 125);
            this.pnlMenuUsuarios.Name = "pnlMenuUsuarios";
            this.pnlMenuUsuarios.Size = new System.Drawing.Size(316, 57);
            this.pnlMenuUsuarios.TabIndex = 4;
            // 
            // pcbMenuUsuarios
            // 
            this.pcbMenuUsuarios.BackColor = System.Drawing.Color.White;
            this.pcbMenuUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMenuUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pcbMenuUsuarios.Image")));
            this.pcbMenuUsuarios.Location = new System.Drawing.Point(16, 3);
            this.pcbMenuUsuarios.Name = "pcbMenuUsuarios";
            this.pcbMenuUsuarios.Size = new System.Drawing.Size(67, 51);
            this.pcbMenuUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMenuUsuarios.TabIndex = 0;
            this.pcbMenuUsuarios.TabStop = false;
            this.pcbMenuUsuarios.Click += new System.EventHandler(this.pcbMenuUsuarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuarios";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnMenuEmpleado
            // 
            this.pnMenuEmpleado.Controls.Add(this.pcbMenuEmpleados);
            this.pnMenuEmpleado.Controls.Add(this.label1);
            this.pnMenuEmpleado.Location = new System.Drawing.Point(3, 185);
            this.pnMenuEmpleado.Name = "pnMenuEmpleado";
            this.pnMenuEmpleado.Size = new System.Drawing.Size(316, 57);
            this.pnMenuEmpleado.TabIndex = 3;
            // 
            // pcbMenuEmpleados
            // 
            this.pcbMenuEmpleados.BackColor = System.Drawing.Color.White;
            this.pcbMenuEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMenuEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("pcbMenuEmpleados.Image")));
            this.pcbMenuEmpleados.Location = new System.Drawing.Point(16, 8);
            this.pcbMenuEmpleados.Name = "pcbMenuEmpleados";
            this.pcbMenuEmpleados.Size = new System.Drawing.Size(70, 46);
            this.pcbMenuEmpleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbMenuEmpleados.TabIndex = 0;
            this.pcbMenuEmpleados.TabStop = false;
            this.pcbMenuEmpleados.Click += new System.EventHandler(this.pcbMenuEmpleados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnClose
            // 
            this.pnClose.Controls.Add(this.pictureBox2);
            this.pnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnClose.Location = new System.Drawing.Point(0, 691);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(322, 59);
            this.pnClose.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.AutoScroll = true;
            this.pnlContenedor.AutoSize = true;
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(322, 81);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(917, 750);
            this.pnlContenedor.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(1153, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 49);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(540, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 44);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1239, 831);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarFamiliasBindingSource)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMantenimiento)).EndInit();
            this.pnlMenuVacaciones.ResumeLayout(false);
            this.pnlMenuVacaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuVacaciones)).EndInit();
            this.pnlMenuActas.ResumeLayout(false);
            this.pnlMenuActas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuActas)).EndInit();
            this.pnlMenuUsuarios.ResumeLayout(false);
            this.pnlMenuUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuUsuarios)).EndInit();
            this.pnMenuEmpleado.ResumeLayout(false);
            this.pnMenuEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenuEmpleados)).EndInit();
            this.pnClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.BindingSource mostrarFamiliasBindingSource;
      
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.PictureBox pcbMenuEmpleados;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnMenuEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMenuUsuarios;
        private System.Windows.Forms.PictureBox pcbMenuUsuarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMenuActas;
        private System.Windows.Forms.PictureBox pcbMenuActas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlMenuVacaciones;
        private System.Windows.Forms.PictureBox pcbMenuVacaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbMantenimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}