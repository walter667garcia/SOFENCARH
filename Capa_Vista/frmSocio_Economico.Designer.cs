namespace Capa_Vista
{
    partial class frmSocio_Economico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocio_Economico));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgSocioEconomico = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtModeloVehiculo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPagoVivienda = new System.Windows.Forms.TextBox();
            this.txtFlagDeuda = new System.Windows.Forms.TextBox();
            this.txtTipoVehiculo = new System.Windows.Forms.TextBox();
            this.txtMontoOtrosIngresos = new System.Windows.Forms.TextBox();
            this.txtFuenteOtrosIngresos = new System.Windows.Forms.TextBox();
            this.txtFlagOtrosIngresos = new System.Windows.Forms.TextBox();
            this.txtPlacaVehiculo = new System.Windows.Forms.TextBox();
            this.txtMontoDeuda = new System.Windows.Forms.TextBox();
            this.txtMotivoDeuda = new System.Windows.Forms.TextBox();
            this.txtDetalleDependencias = new System.Windows.Forms.TextBox();
            this.txtDependencias = new System.Windows.Forms.TextBox();
            this.txtDetalleAgrupacion = new System.Windows.Forms.TextBox();
            this.cmbAgrupacion = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.cmbVivienda = new System.Windows.Forms.ComboBox();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSocioEconomico)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.dtgSocioEconomico);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(469, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 28);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "label18";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(37, 53);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(301, 34);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dtgSocioEconomico
            // 
            this.dtgSocioEconomico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgSocioEconomico.BackgroundColor = System.Drawing.Color.White;
            this.dtgSocioEconomico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSocioEconomico.Location = new System.Drawing.Point(6, 148);
            this.dtgSocioEconomico.Name = "dtgSocioEconomico";
            this.dtgSocioEconomico.RowHeadersWidth = 51;
            this.dtgSocioEconomico.RowTemplate.Height = 24;
            this.dtgSocioEconomico.Size = new System.Drawing.Size(1238, 449);
            this.dtgSocioEconomico.TabIndex = 0;
            this.dtgSocioEconomico.DoubleClick += new System.EventHandler(this.dtgSocioEconomico_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.txtModeloVehiculo);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtPagoVivienda);
            this.tabPage2.Controls.Add(this.txtFlagDeuda);
            this.tabPage2.Controls.Add(this.txtTipoVehiculo);
            this.tabPage2.Controls.Add(this.txtMontoOtrosIngresos);
            this.tabPage2.Controls.Add(this.txtFuenteOtrosIngresos);
            this.tabPage2.Controls.Add(this.txtFlagOtrosIngresos);
            this.tabPage2.Controls.Add(this.txtPlacaVehiculo);
            this.tabPage2.Controls.Add(this.txtMontoDeuda);
            this.tabPage2.Controls.Add(this.txtMotivoDeuda);
            this.tabPage2.Controls.Add(this.txtDetalleDependencias);
            this.tabPage2.Controls.Add(this.txtDependencias);
            this.tabPage2.Controls.Add(this.txtDetalleAgrupacion);
            this.tabPage2.Controls.Add(this.cmbAgrupacion);
            this.tabPage2.Controls.Add(this.cmbVehiculo);
            this.tabPage2.Controls.Add(this.cmbVivienda);
            this.tabPage2.Controls.Add(this.cmbPersona);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.HideSelection = false;
            this.txtId.Location = new System.Drawing.Point(675, 512);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 34);
            this.txtId.TabIndex = 43;
            this.txtId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(491, 489);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 46);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Location = new System.Drawing.Point(367, 489);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 46);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Location = new System.Drawing.Point(139, 489);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 46);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Location = new System.Drawing.Point(250, 489);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 46);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtModeloVehiculo
            // 
            this.txtModeloVehiculo.BackColor = System.Drawing.Color.White;
            this.txtModeloVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeloVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModeloVehiculo.Location = new System.Drawing.Point(838, 501);
            this.txtModeloVehiculo.Name = "txtModeloVehiculo";
            this.txtModeloVehiculo.Size = new System.Drawing.Size(346, 34);
            this.txtModeloVehiculo.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(869, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 28);
            this.label12.TabIndex = 37;
            this.label12.Text = "MODELO VEHICULO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(880, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 28);
            this.label17.TabIndex = 36;
            this.label17.Text = "TIPO VEHICULO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(481, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 28);
            this.label16.TabIndex = 35;
            this.label16.Text = "MOTIVO DEUDA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(880, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 28);
            this.label15.TabIndex = 34;
            this.label15.Text = "VEHICULO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(882, 170);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 28);
            this.label14.TabIndex = 33;
            this.label14.Text = "FUENTE OTROS INGRESOS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(880, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(262, 28);
            this.label13.TabIndex = 32;
            this.label13.Text = "MONTO OTROS INGRESOS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(878, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 28);
            this.label11.TabIndex = 30;
            this.label11.Text = "PLACA VEHICULO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(880, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 28);
            this.label10.TabIndex = 29;
            this.label10.Text = "FLAG OTROS INGRESOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(481, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 28);
            this.label9.TabIndex = 28;
            this.label9.Text = "MONTO DEUDA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "FLAG DEUDAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 28);
            this.label7.TabIndex = 26;
            this.label7.Text = "PAGO VIVIENDA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(486, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "TIPO VIVIENDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "DETALLE DEPENDIENTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "DEPENDIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "DETALLE AGRUPACION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "AGRUPACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "PERSONA";
            // 
            // txtPagoVivienda
            // 
            this.txtPagoVivienda.BackColor = System.Drawing.Color.White;
            this.txtPagoVivienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoVivienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPagoVivienda.Location = new System.Drawing.Point(486, 131);
            this.txtPagoVivienda.Name = "txtPagoVivienda";
            this.txtPagoVivienda.Size = new System.Drawing.Size(290, 34);
            this.txtPagoVivienda.TabIndex = 16;
            // 
            // txtFlagDeuda
            // 
            this.txtFlagDeuda.BackColor = System.Drawing.Color.White;
            this.txtFlagDeuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlagDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFlagDeuda.Location = new System.Drawing.Point(491, 210);
            this.txtFlagDeuda.Name = "txtFlagDeuda";
            this.txtFlagDeuda.Size = new System.Drawing.Size(290, 34);
            this.txtFlagDeuda.TabIndex = 15;
            // 
            // txtTipoVehiculo
            // 
            this.txtTipoVehiculo.BackColor = System.Drawing.Color.White;
            this.txtTipoVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoVehiculo.Location = new System.Drawing.Point(883, 347);
            this.txtTipoVehiculo.Name = "txtTipoVehiculo";
            this.txtTipoVehiculo.Size = new System.Drawing.Size(290, 34);
            this.txtTipoVehiculo.TabIndex = 14;
            // 
            // txtMontoOtrosIngresos
            // 
            this.txtMontoOtrosIngresos.BackColor = System.Drawing.Color.White;
            this.txtMontoOtrosIngresos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoOtrosIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoOtrosIngresos.Location = new System.Drawing.Point(883, 131);
            this.txtMontoOtrosIngresos.Name = "txtMontoOtrosIngresos";
            this.txtMontoOtrosIngresos.Size = new System.Drawing.Size(290, 34);
            this.txtMontoOtrosIngresos.TabIndex = 13;
            // 
            // txtFuenteOtrosIngresos
            // 
            this.txtFuenteOtrosIngresos.BackColor = System.Drawing.Color.White;
            this.txtFuenteOtrosIngresos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuenteOtrosIngresos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFuenteOtrosIngresos.Location = new System.Drawing.Point(883, 210);
            this.txtFuenteOtrosIngresos.Name = "txtFuenteOtrosIngresos";
            this.txtFuenteOtrosIngresos.Size = new System.Drawing.Size(290, 34);
            this.txtFuenteOtrosIngresos.TabIndex = 12;
            // 
            // txtFlagOtrosIngresos
            // 
            this.txtFlagOtrosIngresos.Location = new System.Drawing.Point(885, 63);
            this.txtFlagOtrosIngresos.Name = "txtFlagOtrosIngresos";
            this.txtFlagOtrosIngresos.Size = new System.Drawing.Size(290, 34);
            this.txtFlagOtrosIngresos.TabIndex = 11;
            // 
            // txtPlacaVehiculo
            // 
            this.txtPlacaVehiculo.BackColor = System.Drawing.Color.White;
            this.txtPlacaVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPlacaVehiculo.Location = new System.Drawing.Point(874, 433);
            this.txtPlacaVehiculo.Name = "txtPlacaVehiculo";
            this.txtPlacaVehiculo.Size = new System.Drawing.Size(290, 34);
            this.txtPlacaVehiculo.TabIndex = 10;
            // 
            // txtMontoDeuda
            // 
            this.txtMontoDeuda.BackColor = System.Drawing.Color.White;
            this.txtMontoDeuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoDeuda.Location = new System.Drawing.Point(484, 289);
            this.txtMontoDeuda.Name = "txtMontoDeuda";
            this.txtMontoDeuda.Size = new System.Drawing.Size(358, 34);
            this.txtMontoDeuda.TabIndex = 9;
            // 
            // txtMotivoDeuda
            // 
            this.txtMotivoDeuda.BackColor = System.Drawing.Color.White;
            this.txtMotivoDeuda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoDeuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMotivoDeuda.Location = new System.Drawing.Point(484, 384);
            this.txtMotivoDeuda.Name = "txtMotivoDeuda";
            this.txtMotivoDeuda.Size = new System.Drawing.Size(358, 34);
            this.txtMotivoDeuda.TabIndex = 8;
            // 
            // txtDetalleDependencias
            // 
            this.txtDetalleDependencias.BackColor = System.Drawing.Color.White;
            this.txtDetalleDependencias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleDependencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalleDependencias.Location = new System.Drawing.Point(36, 417);
            this.txtDetalleDependencias.Name = "txtDetalleDependencias";
            this.txtDetalleDependencias.Size = new System.Drawing.Size(406, 34);
            this.txtDetalleDependencias.TabIndex = 7;
            // 
            // txtDependencias
            // 
            this.txtDependencias.BackColor = System.Drawing.Color.White;
            this.txtDependencias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDependencias.Location = new System.Drawing.Point(28, 326);
            this.txtDependencias.Name = "txtDependencias";
            this.txtDependencias.Size = new System.Drawing.Size(290, 34);
            this.txtDependencias.TabIndex = 6;
            // 
            // txtDetalleAgrupacion
            // 
            this.txtDetalleAgrupacion.BackColor = System.Drawing.Color.White;
            this.txtDetalleAgrupacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleAgrupacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDetalleAgrupacion.Location = new System.Drawing.Point(28, 250);
            this.txtDetalleAgrupacion.Name = "txtDetalleAgrupacion";
            this.txtDetalleAgrupacion.Size = new System.Drawing.Size(409, 34);
            this.txtDetalleAgrupacion.TabIndex = 5;
            this.txtDetalleAgrupacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbAgrupacion
            // 
            this.cmbAgrupacion.BackColor = System.Drawing.Color.White;
            this.cmbAgrupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAgrupacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAgrupacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbAgrupacion.FormattingEnabled = true;
            this.cmbAgrupacion.Location = new System.Drawing.Point(31, 162);
            this.cmbAgrupacion.Name = "cmbAgrupacion";
            this.cmbAgrupacion.Size = new System.Drawing.Size(290, 36);
            this.cmbAgrupacion.TabIndex = 3;
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.BackColor = System.Drawing.Color.White;
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(883, 277);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(290, 36);
            this.cmbVehiculo.TabIndex = 2;
            // 
            // cmbVivienda
            // 
            this.cmbVivienda.BackColor = System.Drawing.Color.White;
            this.cmbVivienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVivienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVivienda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbVivienda.FormattingEnabled = true;
            this.cmbVivienda.Location = new System.Drawing.Point(484, 61);
            this.cmbVivienda.Name = "cmbVivienda";
            this.cmbVivienda.Size = new System.Drawing.Size(290, 36);
            this.cmbVivienda.TabIndex = 1;
            // 
            // cmbPersona
            // 
            this.cmbPersona.BackColor = System.Drawing.Color.White;
            this.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(28, 72);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(290, 36);
            this.cmbPersona.TabIndex = 0;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // frmSocio_Economico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSocio_Economico";
            this.Text = "frmSocio_Economico";
            this.Load += new System.EventHandler(this.frmSocio_Economico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSocioEconomico)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPagoVivienda;
        private System.Windows.Forms.TextBox txtFlagDeuda;
        private System.Windows.Forms.TextBox txtTipoVehiculo;
        private System.Windows.Forms.TextBox txtMontoOtrosIngresos;
        private System.Windows.Forms.TextBox txtFuenteOtrosIngresos;
        private System.Windows.Forms.TextBox txtFlagOtrosIngresos;
        private System.Windows.Forms.TextBox txtPlacaVehiculo;
        private System.Windows.Forms.TextBox txtMontoDeuda;
        private System.Windows.Forms.TextBox txtMotivoDeuda;
        private System.Windows.Forms.TextBox txtDetalleDependencias;
        private System.Windows.Forms.TextBox txtDependencias;
        private System.Windows.Forms.TextBox txtDetalleAgrupacion;
        private System.Windows.Forms.ComboBox cmbAgrupacion;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.ComboBox cmbVivienda;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModeloVehiculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgSocioEconomico;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}