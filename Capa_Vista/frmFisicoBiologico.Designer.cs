namespace Capa_Vista
{
    partial class frmFisicoBiologico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFisicoBiologico));
            this.tabFisicoBiologico = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgBiologicos = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPasatienpo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSangre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFuma = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAlcohol = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDrogas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiscapacidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAuditivo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLentes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEspecifique = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAccidente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiabetes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabFisicoBiologico.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBiologicos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFisicoBiologico
            // 
            this.tabFisicoBiologico.Controls.Add(this.tabPage1);
            this.tabFisicoBiologico.Controls.Add(this.tabPage2);
            this.tabFisicoBiologico.Location = new System.Drawing.Point(49, 33);
            this.tabFisicoBiologico.Name = "tabFisicoBiologico";
            this.tabFisicoBiologico.SelectedIndex = 0;
            this.tabFisicoBiologico.Size = new System.Drawing.Size(1025, 674);
            this.tabFisicoBiologico.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgBiologicos);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgBiologicos
            // 
            this.dtgBiologicos.BackgroundColor = System.Drawing.Color.White;
            this.dtgBiologicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBiologicos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgBiologicos.Location = new System.Drawing.Point(3, 200);
            this.dtgBiologicos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgBiologicos.Name = "dtgBiologicos";
            this.dtgBiologicos.RowHeadersWidth = 51;
            this.dtgBiologicos.RowTemplate.Height = 24;
            this.dtgBiologicos.Size = new System.Drawing.Size(1011, 442);
            this.dtgBiologicos.TabIndex = 2;
            this.dtgBiologicos.DoubleClick += new System.EventHandler(this.dtgBiologicos_DoubleClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(665, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "label1";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(310, 22);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.txtDeporte);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.txtPasatienpo);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtSangre);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.txtEstatura);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.txtPeso);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtFuma);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtAlcohol);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtDrogas);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtDiscapacidad);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtAuditivo);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtLentes);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtEspecifique);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtTratamiento);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtAlergias);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtOperacion);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtAccidente);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDiabetes);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEnfermedad);
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
            this.tabPage2.Size = new System.Drawing.Size(1017, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(803, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 71;
            this.txtId.Visible = false;
            // 
            // txtDeporte
            // 
            this.txtDeporte.Location = new System.Drawing.Point(585, 397);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(189, 22);
            this.txtDeporte.TabIndex = 70;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(585, 365);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 69;
            this.label20.Text = "DEPORTE";
            // 
            // txtPasatienpo
            // 
            this.txtPasatienpo.Location = new System.Drawing.Point(582, 312);
            this.txtPasatienpo.Name = "txtPasatienpo";
            this.txtPasatienpo.Size = new System.Drawing.Size(189, 22);
            this.txtPasatienpo.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(582, 280);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 16);
            this.label19.TabIndex = 67;
            this.label19.Text = "PASATIEMPO";
            // 
            // txtSangre
            // 
            this.txtSangre.Location = new System.Drawing.Point(582, 226);
            this.txtSangre.Name = "txtSangre";
            this.txtSangre.Size = new System.Drawing.Size(189, 22);
            this.txtSangre.TabIndex = 66;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(582, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 65;
            this.label18.Text = "SANGRE";
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(585, 151);
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.Size = new System.Drawing.Size(189, 22);
            this.txtEstatura.TabIndex = 64;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(585, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 63;
            this.label17.Text = "ESTATURA";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(588, 88);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(189, 22);
            this.txtPeso.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(588, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 16);
            this.label16.TabIndex = 61;
            this.label16.Text = "PESO";
            // 
            // txtFuma
            // 
            this.txtFuma.Location = new System.Drawing.Point(323, 441);
            this.txtFuma.Name = "txtFuma";
            this.txtFuma.Size = new System.Drawing.Size(189, 22);
            this.txtFuma.TabIndex = 60;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(323, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 16);
            this.label15.TabIndex = 59;
            this.label15.Text = "FUMA";
            // 
            // txtAlcohol
            // 
            this.txtAlcohol.Location = new System.Drawing.Point(326, 365);
            this.txtAlcohol.Name = "txtAlcohol";
            this.txtAlcohol.Size = new System.Drawing.Size(189, 22);
            this.txtAlcohol.TabIndex = 58;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(326, 333);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 16);
            this.label14.TabIndex = 57;
            this.label14.Text = "ALCOHOL";
            // 
            // txtDrogas
            // 
            this.txtDrogas.Location = new System.Drawing.Point(326, 292);
            this.txtDrogas.Name = "txtDrogas";
            this.txtDrogas.Size = new System.Drawing.Size(189, 22);
            this.txtDrogas.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 260);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 55;
            this.label13.Text = "DROGAS";
            // 
            // txtDiscapacidad
            // 
            this.txtDiscapacidad.Location = new System.Drawing.Point(332, 206);
            this.txtDiscapacidad.Name = "txtDiscapacidad";
            this.txtDiscapacidad.Size = new System.Drawing.Size(189, 22);
            this.txtDiscapacidad.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 53;
            this.label12.Text = "DISCAPACIDAD";
            // 
            // txtAuditivo
            // 
            this.txtAuditivo.Location = new System.Drawing.Point(329, 131);
            this.txtAuditivo.Name = "txtAuditivo";
            this.txtAuditivo.Size = new System.Drawing.Size(189, 22);
            this.txtAuditivo.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "AUDITIVO";
            // 
            // txtLentes
            // 
            this.txtLentes.Location = new System.Drawing.Point(332, 68);
            this.txtLentes.Name = "txtLentes";
            this.txtLentes.Size = new System.Drawing.Size(189, 22);
            this.txtLentes.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 49;
            this.label10.Text = "LENTES";
            // 
            // txtEspecifique
            // 
            this.txtEspecifique.Location = new System.Drawing.Point(39, 579);
            this.txtEspecifique.Name = "txtEspecifique";
            this.txtEspecifique.Size = new System.Drawing.Size(189, 22);
            this.txtEspecifique.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 547);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "ESPECIFIQUE";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(42, 503);
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(189, 22);
            this.txtTratamiento.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "TRATAMIENTO";
            // 
            // txtAlergias
            // 
            this.txtAlergias.Location = new System.Drawing.Point(45, 428);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(189, 22);
            this.txtAlergias.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 43;
            this.label7.Text = "ALERGIAS";
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(45, 365);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(189, 22);
            this.txtOperacion.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "OPERACION";
            // 
            // txtAccidente
            // 
            this.txtAccidente.Location = new System.Drawing.Point(48, 292);
            this.txtAccidente.Name = "txtAccidente";
            this.txtAccidente.Size = new System.Drawing.Size(189, 22);
            this.txtAccidente.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "ACCIDENTE";
            // 
            // txtDiabetes
            // 
            this.txtDiabetes.Location = new System.Drawing.Point(48, 216);
            this.txtDiabetes.Name = "txtDiabetes";
            this.txtDiabetes.Size = new System.Drawing.Size(189, 22);
            this.txtDiabetes.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "DIABETES";
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(51, 131);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(189, 22);
            this.txtEnfermedad.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "ENFERMEDAD";
            // 
            // cmbPersona
            // 
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(51, 56);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(121, 24);
            this.cmbPersona.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 36);
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
            this.btnCancelar.Location = new System.Drawing.Point(731, 547);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 63);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(591, 547);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 63);
            this.btnEditar.TabIndex = 31;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(335, 547);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 63);
            this.btnNuevo.TabIndex = 29;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(459, 547);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 63);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmFisicoBiologico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 714);
            this.Controls.Add(this.tabFisicoBiologico);
            this.Name = "frmFisicoBiologico";
            this.Text = "frmFisicoBiologico";
            this.Load += new System.EventHandler(this.frmFisicoBiologico_Load);
            this.tabFisicoBiologico.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBiologicos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFisicoBiologico;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgBiologicos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.TextBox txtDeporte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPasatienpo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSangre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFuma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAlcohol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDrogas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiscapacidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAuditivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLentes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEspecifique;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAccidente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiabetes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}