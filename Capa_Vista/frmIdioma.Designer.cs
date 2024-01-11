namespace Capa_Vista
{
    partial class frmIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdioma));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtgIdioma = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtId_Idioma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtLectura = new System.Windows.Forms.TextBox();
            this.txtEscritura = new System.Windows.Forms.TextBox();
            this.txtConversacion = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIdioma)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dtgIdioma);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1106, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LIsta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(6, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(740, 55);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 28);
            this.lblTotal.TabIndex = 3;
            // 
            // dtgIdioma
            // 
            this.dtgIdioma.BackgroundColor = System.Drawing.Color.White;
            this.dtgIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIdioma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgIdioma.Location = new System.Drawing.Point(3, 121);
            this.dtgIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgIdioma.Name = "dtgIdioma";
            this.dtgIdioma.RowHeadersWidth = 51;
            this.dtgIdioma.RowTemplate.Height = 24;
            this.dtgIdioma.Size = new System.Drawing.Size(1100, 424);
            this.dtgIdioma.TabIndex = 0;
            this.dtgIdioma.DoubleClick += new System.EventHandler(this.dtgIdioma_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.txtId_Idioma);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtDocumento);
            this.tabPage2.Controls.Add(this.txtLectura);
            this.tabPage2.Controls.Add(this.txtEscritura);
            this.tabPage2.Controls.Add(this.txtConversacion);
            this.tabPage2.Controls.Add(this.cmbIdioma);
            this.tabPage2.Controls.Add(this.cmbPersona);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1106, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(741, 429);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 46);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(567, 429);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 46);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(201, 429);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 46);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(398, 429);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 46);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtId_Idioma
            // 
            this.txtId_Idioma.Enabled = false;
            this.txtId_Idioma.Location = new System.Drawing.Point(776, 31);
            this.txtId_Idioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId_Idioma.Name = "txtId_Idioma";
            this.txtId_Idioma.Size = new System.Drawing.Size(100, 34);
            this.txtId_Idioma.TabIndex = 19;
            this.txtId_Idioma.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "DOCUMENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "LECTURA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "ESCRITURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONVERSACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "IDIOMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "DPI PERSONA";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.White;
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumento.Location = new System.Drawing.Point(495, 326);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(297, 34);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // txtLectura
            // 
            this.txtLectura.BackColor = System.Drawing.Color.White;
            this.txtLectura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLectura.Location = new System.Drawing.Point(201, 326);
            this.txtLectura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.Size = new System.Drawing.Size(248, 34);
            this.txtLectura.TabIndex = 7;
            this.txtLectura.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEscritura
            // 
            this.txtEscritura.BackColor = System.Drawing.Color.White;
            this.txtEscritura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscritura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEscritura.Location = new System.Drawing.Point(495, 217);
            this.txtEscritura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEscritura.Name = "txtEscritura";
            this.txtEscritura.Size = new System.Drawing.Size(209, 34);
            this.txtEscritura.TabIndex = 6;
            this.txtEscritura.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtConversacion
            // 
            this.txtConversacion.BackColor = System.Drawing.Color.White;
            this.txtConversacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConversacion.Location = new System.Drawing.Point(495, 93);
            this.txtConversacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConversacion.Name = "txtConversacion";
            this.txtConversacion.Size = new System.Drawing.Size(209, 34);
            this.txtConversacion.TabIndex = 5;
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(201, 215);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(248, 36);
            this.cmbIdioma.TabIndex = 4;
            // 
            // cmbPersona
            // 
            this.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(201, 91);
            this.cmbPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(248, 36);
            this.cmbPersona.TabIndex = 3;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 723);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmIdioma";
            this.Text = "frmIdioma";
            this.Load += new System.EventHandler(this.frmIdioma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIdioma)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtLectura;
        private System.Windows.Forms.TextBox txtEscritura;
        private System.Windows.Forms.TextBox txtConversacion;
        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.TextBox txtId_Idioma;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dtgIdioma;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}