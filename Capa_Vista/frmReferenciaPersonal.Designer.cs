namespace Capa_Vista
{
    partial class frmReferenciaPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReferenciaPersonal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtgReferenciaPersonal = new System.Windows.Forms.DataGridView();
            this.lbTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtRelacion = new System.Windows.Forms.TextBox();
            this.lbRelacion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReferenciaPersonal)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(35, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 500);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtgReferenciaPersonal);
            this.tabPage1.Controls.Add(this.lbTotal);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtgReferenciaPersonal
            // 
            this.dtgReferenciaPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dtgReferenciaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReferenciaPersonal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgReferenciaPersonal.Location = new System.Drawing.Point(3, 192);
            this.dtgReferenciaPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgReferenciaPersonal.Name = "dtgReferenciaPersonal";
            this.dtgReferenciaPersonal.RowHeadersWidth = 51;
            this.dtgReferenciaPersonal.RowTemplate.Height = 24;
            this.dtgReferenciaPersonal.Size = new System.Drawing.Size(1011, 276);
            this.dtgReferenciaPersonal.TabIndex = 2;
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
            this.tabPage2.Controls.Add(this.txtRelacion);
            this.tabPage2.Controls.Add(this.lbRelacion);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtNombre);
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
            this.tabPage2.Size = new System.Drawing.Size(1017, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Location = new System.Drawing.Point(645, 376);
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
            this.btnEditar.Location = new System.Drawing.Point(505, 376);
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
            this.btnNuevo.Location = new System.Drawing.Point(249, 376);
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
            this.btnGuardar.Location = new System.Drawing.Point(373, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 63);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(867, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 50;
            // 
            // txtRelacion
            // 
            this.txtRelacion.Location = new System.Drawing.Point(332, 66);
            this.txtRelacion.Name = "txtRelacion";
            this.txtRelacion.Size = new System.Drawing.Size(247, 22);
            this.txtRelacion.TabIndex = 49;
            // 
            // lbRelacion
            // 
            this.lbRelacion.AutoSize = true;
            this.lbRelacion.Location = new System.Drawing.Point(332, 27);
            this.lbRelacion.Name = "lbRelacion";
            this.lbRelacion.Size = new System.Drawing.Size(74, 16);
            this.lbRelacion.TabIndex = 48;
            this.lbRelacion.Text = "RELACION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(28, 238);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(247, 22);
            this.txtTelefono.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "TELEFONO";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 138);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 22);
            this.txtNombre.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "NOMBRE";
            // 
            // cmbPersona
            // 
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(31, 47);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(199, 24);
            this.cmbPersona.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "PERSONA";
            // 
            // frmReferenciaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 548);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmReferenciaPersonal";
            this.Text = "frmReferenciaPersonal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReferenciaPersonal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgReferenciaPersonal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label label2;
    }
}