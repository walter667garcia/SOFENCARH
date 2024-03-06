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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.mHome = new FontAwesome.Sharp.IconMenuItem();
            this.mPersona = new FontAwesome.Sharp.IconMenuItem();
            this.mEmpleado = new FontAwesome.Sharp.IconMenuItem();
            this.mPuesto = new FontAwesome.Sharp.IconMenuItem();
            this.mNominal = new FontAwesome.Sharp.IconMenuItem();
            this.mFuncional = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.mSolicitud = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.mReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pContainer = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.Menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1365, 63);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "MenuBarra";
            this.menuStrip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip2_MouseDown);
            this.menuStrip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip2_MouseMove);
            this.menuStrip2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip2_MouseUp);
            // 
            // Menus
            // 
            this.Menus.AutoSize = false;
            this.Menus.BackColor = System.Drawing.Color.DarkGray;
            this.Menus.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHome,
            this.mPersona,
            this.mPuesto,
            this.mSolicitud,
            this.mReportes});
            this.Menus.Location = new System.Drawing.Point(0, 63);
            this.Menus.Name = "Menus";
            this.Menus.Padding = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.Menus.Size = new System.Drawing.Size(250, 682);
            this.Menus.TabIndex = 4;
            // 
            // mHome
            // 
            this.mHome.AutoSize = false;
            this.mHome.BackColor = System.Drawing.Color.Gray;
            this.mHome.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mHome.IconChar = FontAwesome.Sharp.IconChar.PeopleRobbery;
            this.mHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mHome.IconSize = 40;
            this.mHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mHome.MergeIndex = 0;
            this.mHome.Name = "mHome";
            this.mHome.Padding = new System.Windows.Forms.Padding(0);
            this.mHome.Size = new System.Drawing.Size(200, 40);
            this.mHome.Text = "PERSONAL";
            this.mHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mHome.Click += new System.EventHandler(this.mHome_Click);
            // 
            // mPersona
            // 
            this.mPersona.AutoSize = false;
            this.mPersona.BackColor = System.Drawing.Color.DarkGray;
            this.mPersona.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEmpleado});
            this.mPersona.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPersona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mPersona.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.mPersona.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mPersona.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mPersona.IconSize = 40;
            this.mPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mPersona.Name = "mPersona";
            this.mPersona.Padding = new System.Windows.Forms.Padding(0);
            this.mPersona.Size = new System.Drawing.Size(200, 40);
            this.mPersona.Text = "EXPEDIENTE";
            // 
            // mEmpleado
            // 
            this.mEmpleado.AutoSize = false;
            this.mEmpleado.ForeColor = System.Drawing.Color.Gray;
            this.mEmpleado.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.mEmpleado.IconColor = System.Drawing.Color.Black;
            this.mEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mEmpleado.Name = "mEmpleado";
            this.mEmpleado.Size = new System.Drawing.Size(280, 50);
            this.mEmpleado.Text = "INGRESO DE PERSONA";
            this.mEmpleado.Click += new System.EventHandler(this.mEmpleado_Click);
            // 
            // mPuesto
            // 
            this.mPuesto.AutoSize = false;
            this.mPuesto.BackColor = System.Drawing.Color.Gray;
            this.mPuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNominal,
            this.mFuncional,
            this.iconMenuItem1});
            this.mPuesto.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mPuesto.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.mPuesto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mPuesto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mPuesto.IconSize = 40;
            this.mPuesto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mPuesto.Name = "mPuesto";
            this.mPuesto.Padding = new System.Windows.Forms.Padding(0);
            this.mPuesto.Size = new System.Drawing.Size(200, 40);
            this.mPuesto.Text = "PUESTOS";
            // 
            // mNominal
            // 
            this.mNominal.ForeColor = System.Drawing.Color.Gray;
            this.mNominal.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.mNominal.IconColor = System.Drawing.Color.Black;
            this.mNominal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mNominal.Name = "mNominal";
            this.mNominal.Size = new System.Drawing.Size(228, 34);
            this.mNominal.Text = "NOMINAL";
            this.mNominal.Click += new System.EventHandler(this.mNominal_Click);
            // 
            // mFuncional
            // 
            this.mFuncional.ForeColor = System.Drawing.Color.Gray;
            this.mFuncional.IconChar = FontAwesome.Sharp.IconChar.PersonWalking;
            this.mFuncional.IconColor = System.Drawing.Color.Black;
            this.mFuncional.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mFuncional.Name = "mFuncional";
            this.mFuncional.Size = new System.Drawing.Size(228, 34);
            this.mFuncional.Text = "FUNCIONAL";
            this.mFuncional.Click += new System.EventHandler(this.mFuncional_Click);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.BookJournalWhills;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(228, 34);
            this.iconMenuItem1.Text = "RENGLONES";
            // 
            // mSolicitud
            // 
            this.mSolicitud.AutoSize = false;
            this.mSolicitud.BackColor = System.Drawing.Color.DarkGray;
            this.mSolicitud.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem2});
            this.mSolicitud.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mSolicitud.IconChar = FontAwesome.Sharp.IconChar.Wodu;
            this.mSolicitud.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mSolicitud.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mSolicitud.IconSize = 40;
            this.mSolicitud.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mSolicitud.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mSolicitud.MergeIndex = 0;
            this.mSolicitud.Name = "mSolicitud";
            this.mSolicitud.Padding = new System.Windows.Forms.Padding(0);
            this.mSolicitud.Size = new System.Drawing.Size(200, 40);
            this.mSolicitud.Text = "ACTA";
            this.mSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mSolicitud.Click += new System.EventHandler(this.mSolicitud_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem2.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(231, 34);
            this.iconMenuItem2.Text = "CREAR ACTA";
            this.iconMenuItem2.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // mReportes
            // 
            this.mReportes.AutoSize = false;
            this.mReportes.BackColor = System.Drawing.Color.Gray;
            this.mReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem3,
            this.iconMenuItem4});
            this.mReportes.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mReportes.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.mReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.mReportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mReportes.IconSize = 40;
            this.mReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mReportes.Name = "mReportes";
            this.mReportes.Padding = new System.Windows.Forms.Padding(0);
            this.mReportes.Size = new System.Drawing.Size(200, 40);
            this.mReportes.Text = "REPORTES";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(541, 34);
            this.iconMenuItem3.Text = "REPORTE DE SOLICITUD";
            this.iconMenuItem3.Click += new System.EventHandler(this.iconMenuItem3_Click);
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(541, 34);
            this.iconMenuItem4.Text = "REPORTE DE ACTA DE TOMA DE POSESION";
            this.iconMenuItem4.Click += new System.EventHandler(this.iconMenuItem4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "ENCA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 675);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(58, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.White;
            this.pContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pContainer.Cursor = System.Windows.Forms.Cursors.Default;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pContainer.Location = new System.Drawing.Point(250, 63);
            this.pContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1115, 682);
            this.pContainer.TabIndex = 5;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(245, 19);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(72, 25);
            this.lbFecha.TabIndex = 17;
            this.lbFecha.Text = "Fecha";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1365, 745);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip Menus;
        private FontAwesome.Sharp.IconMenuItem mHome;
        private FontAwesome.Sharp.IconMenuItem mPuesto;
        private FontAwesome.Sharp.IconMenuItem mReportes;
        private FontAwesome.Sharp.IconMenuItem mPersona;
        private FontAwesome.Sharp.IconMenuItem mEmpleado;
        private FontAwesome.Sharp.IconMenuItem mNominal;
        private FontAwesome.Sharp.IconMenuItem mFuncional;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem mSolicitud;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Label lbFecha;
    }
}