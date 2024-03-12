namespace Capa_Vista.Idioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdioma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbNuevo = new System.Windows.Forms.PictureBox();
            this.pcbTitulo = new System.Windows.Forms.PictureBox();
            this.lbPersona = new System.Windows.Forms.Label();
            this.plContenedor = new System.Windows.Forms.Panel();
            this.dtgIdioma = new System.Windows.Forms.DataGridView();
            this.plMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).BeginInit();
            this.plContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIdioma)).BeginInit();
            this.SuspendLayout();
            // 
            // plMenu
            // 
            this.plMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plMenu.Controls.Add(this.pictureBox1);
            this.plMenu.Controls.Add(this.pcbNuevo);
            this.plMenu.Controls.Add(this.pcbTitulo);
            this.plMenu.Controls.Add(this.lbPersona);
            this.plMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMenu.ForeColor = System.Drawing.Color.White;
            this.plMenu.Location = new System.Drawing.Point(0, 0);
            this.plMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plMenu.Name = "plMenu";
            this.plMenu.Size = new System.Drawing.Size(1200, 85);
            this.plMenu.TabIndex = 0;
            this.plMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMenu_MouseDown);
            this.plMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMenu_MouseMove);
            this.plMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMenu_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1123, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbNuevo
            // 
            this.pcbNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("pcbNuevo.Image")));
            this.pcbNuevo.Location = new System.Drawing.Point(1041, 8);
            this.pcbNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbNuevo.Name = "pcbNuevo";
            this.pcbNuevo.Size = new System.Drawing.Size(65, 70);
            this.pcbNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNuevo.TabIndex = 2;
            this.pcbNuevo.TabStop = false;
            this.pcbNuevo.Click += new System.EventHandler(this.pcbNuevo_Click);
            // 
            // pcbTitulo
            // 
            this.pcbTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pcbTitulo.Image")));
            this.pcbTitulo.Location = new System.Drawing.Point(14, 4);
            this.pcbTitulo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pcbTitulo.Name = "pcbTitulo";
            this.pcbTitulo.Size = new System.Drawing.Size(65, 70);
            this.pcbTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTitulo.TabIndex = 1;
            this.pcbTitulo.TabStop = false;
            this.pcbTitulo.Click += new System.EventHandler(this.pcbTitulo_Click);
            // 
            // lbPersona
            // 
            this.lbPersona.AutoSize = true;
            this.lbPersona.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersona.Location = new System.Drawing.Point(94, 48);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(70, 26);
            this.lbPersona.TabIndex = 0;
            this.lbPersona.Text = "label1";
            // 
            // plContenedor
            // 
            this.plContenedor.BackColor = System.Drawing.Color.White;
            this.plContenedor.Controls.Add(this.dtgIdioma);
            this.plContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContenedor.Location = new System.Drawing.Point(0, 85);
            this.plContenedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plContenedor.Name = "plContenedor";
            this.plContenedor.Size = new System.Drawing.Size(1200, 515);
            this.plContenedor.TabIndex = 1;
            // 
            // dtgIdioma
            // 
            this.dtgIdioma.AllowUserToAddRows = false;
            this.dtgIdioma.AllowUserToDeleteRows = false;
            this.dtgIdioma.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(211)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgIdioma.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgIdioma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgIdioma.BackgroundColor = System.Drawing.Color.White;
            this.dtgIdioma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgIdioma.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dtgIdioma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIdioma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgIdioma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgIdioma.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgIdioma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgIdioma.GridColor = System.Drawing.SystemColors.GrayText;
            this.dtgIdioma.Location = new System.Drawing.Point(0, 0);
            this.dtgIdioma.MultiSelect = false;
            this.dtgIdioma.Name = "dtgIdioma";
            this.dtgIdioma.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgIdioma.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgIdioma.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgIdioma.RowTemplate.Height = 24;
            this.dtgIdioma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIdioma.Size = new System.Drawing.Size(1200, 515);
            this.dtgIdioma.TabIndex = 8;
            this.dtgIdioma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgIdioma_MouseClick);
            // 
            // frmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.plContenedor);
            this.Controls.Add(this.plMenu);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.frmIdioma_Load);
            this.plMenu.ResumeLayout(false);
            this.plMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTitulo)).EndInit();
            this.plContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIdioma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMenu;
        private System.Windows.Forms.PictureBox pcbNuevo;
        private System.Windows.Forms.PictureBox pcbTitulo;
        private System.Windows.Forms.Label lbPersona;
        private System.Windows.Forms.Panel plContenedor;
        private System.Windows.Forms.DataGridView dtgIdioma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}