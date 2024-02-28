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
            this.pContainer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1365, 65);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "MenuBarra";
            // 
            // Menus
            // 
            this.Menus.AutoSize = false;
            this.Menus.BackColor = System.Drawing.Color.Silver;
            this.Menus.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHome,
            this.mPersona,
            this.mPuesto,
            this.mSolicitud,
            this.mReportes});
            this.Menus.Location = new System.Drawing.Point(0, 65);
            this.Menus.Name = "Menus";
            this.Menus.Padding = new System.Windows.Forms.Padding(5, 30, 20, 0);
            this.Menus.Size = new System.Drawing.Size(300, 680);
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
            this.mSolicitud.MergeIndex = 0;
            this.mSolicitud.Name = "mSolicitud";
            this.mSolicitud.Padding = new System.Windows.Forms.Padding(0);
            this.mSolicitud.Size = new System.Drawing.Size(200, 40);
            this.mSolicitud.Text = "SOLICITUD";
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
            this.iconMenuItem2.Size = new System.Drawing.Size(280, 34);
            this.iconMenuItem2.Text = "VER SOLICITUDES";
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
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.White;
            this.pContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pContainer.Location = new System.Drawing.Point(300, 65);
            this.pContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1065, 680);
            this.pContainer.TabIndex = 5;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1309, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 39);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(15, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 39);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1365, 745);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip Menus;
        private FontAwesome.Sharp.IconMenuItem mHome;
        private FontAwesome.Sharp.IconMenuItem mPuesto;
        private System.Windows.Forms.Panel pContainer;
        private FontAwesome.Sharp.IconMenuItem mReportes;
        private FontAwesome.Sharp.IconMenuItem mPersona;
        private FontAwesome.Sharp.IconMenuItem mEmpleado;
        private FontAwesome.Sharp.IconMenuItem mNominal;
        private FontAwesome.Sharp.IconMenuItem mFuncional;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem mSolicitud;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Button button2;
    }
}