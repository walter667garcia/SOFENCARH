namespace Capa_Vista.Usuario
{
    partial class frmEntregaPuesto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtHora1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoraLetras1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRenglon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPuestoSalida = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPuestoFuncional = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPuestoNominal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDPILetras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfesion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaletras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoraLetras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 60);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtDestino);
            this.panel2.Controls.Add(this.btnDestino);
            this.panel2.Controls.Add(this.txtPath);
            this.panel2.Controls.Add(this.btnOrigen);
            this.panel2.Controls.Add(this.btnGenerar);
            this.panel2.Controls.Add(this.txtHora1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtHoraLetras1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtRenglon);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtPuestoSalida);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtPuestoFuncional);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPuestoNominal);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDPI);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDPILetras);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEmpleado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProfesion);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtFechaletras);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtHora);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtHoraLetras);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(158, 65);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(437, 38);
            this.txtDestino.TabIndex = 30;
            // 
            // btnDestino
            // 
            this.btnDestino.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDestino.ForeColor = System.Drawing.Color.White;
            this.btnDestino.Location = new System.Drawing.Point(15, 65);
            this.btnDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(124, 39);
            this.btnDestino.TabIndex = 31;
            this.btnDestino.Text = "Ruta Destino:";
            this.btnDestino.UseVisualStyleBackColor = false;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(158, 18);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(437, 38);
            this.txtPath.TabIndex = 27;
            // 
            // btnOrigen
            // 
            this.btnOrigen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOrigen.ForeColor = System.Drawing.Color.White;
            this.btnOrigen.Location = new System.Drawing.Point(15, 18);
            this.btnOrigen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(124, 39);
            this.btnOrigen.TabIndex = 29;
            this.btnOrigen.Text = "Archivo Origen";
            this.btnOrigen.UseVisualStyleBackColor = false;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(672, 34);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(224, 59);
            this.btnGenerar.TabIndex = 28;
            this.btnGenerar.Text = "Generar Toma Posecion";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtHora1
            // 
            this.txtHora1.Enabled = false;
            this.txtHora1.Location = new System.Drawing.Point(15, 380);
            this.txtHora1.Name = "txtHora1";
            this.txtHora1.Size = new System.Drawing.Size(232, 22);
            this.txtHora1.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Hora:";
            // 
            // txtHoraLetras1
            // 
            this.txtHoraLetras1.Location = new System.Drawing.Point(786, 315);
            this.txtHoraLetras1.Multiline = true;
            this.txtHoraLetras1.Name = "txtHoraLetras1";
            this.txtHoraLetras1.Size = new System.Drawing.Size(232, 46);
            this.txtHoraLetras1.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(783, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Hora en Letras:";
            // 
            // txtRenglon
            // 
            this.txtRenglon.Location = new System.Drawing.Point(528, 315);
            this.txtRenglon.Name = "txtRenglon";
            this.txtRenglon.Size = new System.Drawing.Size(232, 22);
            this.txtRenglon.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(525, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "No Renglon:";
            // 
            // txtPuestoSalida
            // 
            this.txtPuestoSalida.Location = new System.Drawing.Point(275, 315);
            this.txtPuestoSalida.Name = "txtPuestoSalida";
            this.txtPuestoSalida.Size = new System.Drawing.Size(232, 22);
            this.txtPuestoSalida.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Puesto Salida:";
            // 
            // txtPuestoFuncional
            // 
            this.txtPuestoFuncional.Enabled = false;
            this.txtPuestoFuncional.Location = new System.Drawing.Point(15, 315);
            this.txtPuestoFuncional.Name = "txtPuestoFuncional";
            this.txtPuestoFuncional.Size = new System.Drawing.Size(232, 22);
            this.txtPuestoFuncional.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Puesto Funcional:";
            // 
            // txtPuestoNominal
            // 
            this.txtPuestoNominal.Enabled = false;
            this.txtPuestoNominal.Location = new System.Drawing.Point(786, 240);
            this.txtPuestoNominal.Name = "txtPuestoNominal";
            this.txtPuestoNominal.Size = new System.Drawing.Size(232, 22);
            this.txtPuestoNominal.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(783, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Puesto Nominal:";
            // 
            // txtDPI
            // 
            this.txtDPI.Enabled = false;
            this.txtDPI.Location = new System.Drawing.Point(581, 240);
            this.txtDPI.Multiline = true;
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(179, 22);
            this.txtDPI.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "DPI:";
            // 
            // txtDPILetras
            // 
            this.txtDPILetras.Location = new System.Drawing.Point(275, 240);
            this.txtDPILetras.Multiline = true;
            this.txtDPILetras.Name = "txtDPILetras";
            this.txtDPILetras.Size = new System.Drawing.Size(300, 42);
            this.txtDPILetras.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "DPI en Letras:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(15, 240);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(232, 22);
            this.txtEmpleado.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Empleado:";
            // 
            // txtProfesion
            // 
            this.txtProfesion.Enabled = false;
            this.txtProfesion.Location = new System.Drawing.Point(786, 156);
            this.txtProfesion.Name = "txtProfesion";
            this.txtProfesion.Size = new System.Drawing.Size(232, 22);
            this.txtProfesion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(783, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profesion:";
            // 
            // txtFechaletras
            // 
            this.txtFechaletras.Location = new System.Drawing.Point(528, 156);
            this.txtFechaletras.Multiline = true;
            this.txtFechaletras.Name = "txtFechaletras";
            this.txtFechaletras.Size = new System.Drawing.Size(232, 44);
            this.txtFechaletras.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha en Letras:";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(275, 156);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(127, 22);
            this.txtHora.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora:";
            // 
            // txtHoraLetras
            // 
            this.txtHoraLetras.Location = new System.Drawing.Point(15, 156);
            this.txtHoraLetras.Multiline = true;
            this.txtHoraLetras.Name = "txtHoraLetras";
            this.txtHoraLetras.Size = new System.Drawing.Size(232, 44);
            this.txtHoraLetras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora en Letras:";
            // 
            // frmEntregaPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmEntregaPuesto";
            this.Text = "frmEntregaPuesto";
            this.Load += new System.EventHandler(this.frmEntregaPuesto_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDPILetras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProfesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaletras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoraLetras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPuestoNominal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRenglon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPuestoSalida;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPuestoFuncional;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHora1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHoraLetras1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.Button btnGenerar;
    }
}