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
            this.mLocalizacion = new FontAwesome.Sharp.IconMenuItem();
            this.mSocio = new FontAwesome.Sharp.IconMenuItem();
            this.mFamilia = new FontAwesome.Sharp.IconMenuItem();
            this.mEstudios = new FontAwesome.Sharp.IconMenuItem();
            this.mIdioma = new FontAwesome.Sharp.IconMenuItem();
            this.mEmpleado = new FontAwesome.Sharp.IconMenuItem();
            this.mPuesto = new FontAwesome.Sharp.IconMenuItem();
            this.mNominal = new FontAwesome.Sharp.IconMenuItem();
            this.mFuncional = new FontAwesome.Sharp.IconMenuItem();
            this.mSolicitud = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.mReportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.pContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mOtrosDatos = new FontAwesome.Sharp.IconMenuItem();
            this.mReferenciaPersonal = new FontAwesome.Sharp.IconMenuItem();
            this.mreferenciaLaboral = new FontAwesome.Sharp.IconMenuItem();
            this.mFisicaBiologica = new FontAwesome.Sharp.IconMenuItem();
            this.mEperienciaLaboral = new FontAwesome.Sharp.IconMenuItem();
            this.mDatosAdicionales = new FontAwesome.Sharp.IconMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Menus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1423, 157);
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
            this.Menus.Location = new System.Drawing.Point(0, 157);
            this.Menus.Name = "Menus";
            this.Menus.Padding = new System.Windows.Forms.Padding(5, 30, 20, 0);
            this.Menus.Size = new System.Drawing.Size(300, 769);
            this.Menus.TabIndex = 4;
            // 
            // mHome
            // 
            this.mHome.AutoSize = false;
            this.mHome.BackColor = System.Drawing.Color.DarkGray;
            this.mHome.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mHome.ForeColor = System.Drawing.Color.Black;
            this.mHome.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyCrack;
            this.mHome.IconColor = System.Drawing.Color.Black;
            this.mHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mHome.IconSize = 40;
            this.mHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mHome.MergeIndex = 0;
            this.mHome.Name = "mHome";
            this.mHome.Padding = new System.Windows.Forms.Padding(0);
            this.mHome.Size = new System.Drawing.Size(200, 100);
            this.mHome.Text = "INICIO        ";
            this.mHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mHome.Click += new System.EventHandler(this.mHome_Click);
            // 
            // mPersona
            // 
            this.mPersona.AutoSize = false;
            this.mPersona.BackColor = System.Drawing.Color.Gray;
            this.mPersona.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLocalizacion,
            this.mSocio,
            this.mFamilia,
            this.mEstudios,
            this.mIdioma,
            this.mDatosAdicionales,
            this.mEperienciaLaboral,
            this.mFisicaBiologica,
            this.mreferenciaLaboral,
            this.mReferenciaPersonal,
            this.mOtrosDatos,
            this.mEmpleado});
            this.mPersona.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPersona.ForeColor = System.Drawing.Color.Black;
            this.mPersona.IconChar = FontAwesome.Sharp.IconChar.R;
            this.mPersona.IconColor = System.Drawing.Color.Black;
            this.mPersona.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mPersona.IconSize = 40;
            this.mPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mPersona.Name = "mPersona";
            this.mPersona.Padding = new System.Windows.Forms.Padding(0);
            this.mPersona.Size = new System.Drawing.Size(200, 100);
            this.mPersona.Text = "EXPEDIENTE";
            // 
            // mLocalizacion
            // 
            this.mLocalizacion.AutoSize = false;
            this.mLocalizacion.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLocalizacion.ForeColor = System.Drawing.Color.Gray;
            this.mLocalizacion.IconChar = FontAwesome.Sharp.IconChar.Map;
            this.mLocalizacion.IconColor = System.Drawing.Color.Black;
            this.mLocalizacion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mLocalizacion.IconSize = 40;
            this.mLocalizacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mLocalizacion.Name = "mLocalizacion";
            this.mLocalizacion.Padding = new System.Windows.Forms.Padding(0);
            this.mLocalizacion.Size = new System.Drawing.Size(200, 50);
            this.mLocalizacion.Text = "UBICACION";
            this.mLocalizacion.Click += new System.EventHandler(this.mLocalizacion_Click);
            // 
            // mSocio
            // 
            this.mSocio.AutoSize = false;
            this.mSocio.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSocio.ForeColor = System.Drawing.Color.Gray;
            this.mSocio.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.mSocio.IconColor = System.Drawing.Color.Black;
            this.mSocio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mSocio.IconSize = 40;
            this.mSocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mSocio.Name = "mSocio";
            this.mSocio.Padding = new System.Windows.Forms.Padding(0);
            this.mSocio.Size = new System.Drawing.Size(320, 50);
            this.mSocio.Text = "SOCIO ECONOMICO";
            this.mSocio.Click += new System.EventHandler(this.mSocio_Click);
            // 
            // mFamilia
            // 
            this.mFamilia.AutoSize = false;
            this.mFamilia.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mFamilia.ForeColor = System.Drawing.Color.Gray;
            this.mFamilia.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.mFamilia.IconColor = System.Drawing.Color.Black;
            this.mFamilia.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mFamilia.IconSize = 40;
            this.mFamilia.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mFamilia.Name = "mFamilia";
            this.mFamilia.Padding = new System.Windows.Forms.Padding(0);
            this.mFamilia.Size = new System.Drawing.Size(200, 50);
            this.mFamilia.Text = "FAMILIA";
            this.mFamilia.Click += new System.EventHandler(this.mFamilia_Click);
            // 
            // mEstudios
            // 
            this.mEstudios.AutoSize = false;
            this.mEstudios.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mEstudios.ForeColor = System.Drawing.Color.Gray;
            this.mEstudios.IconChar = FontAwesome.Sharp.IconChar.School;
            this.mEstudios.IconColor = System.Drawing.Color.Black;
            this.mEstudios.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mEstudios.IconSize = 40;
            this.mEstudios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mEstudios.Name = "mEstudios";
            this.mEstudios.Padding = new System.Windows.Forms.Padding(0);
            this.mEstudios.Size = new System.Drawing.Size(200, 50);
            this.mEstudios.Text = "ESTUDIOS";
            this.mEstudios.Click += new System.EventHandler(this.mEstudios_Click);
            // 
            // mIdioma
            // 
            this.mIdioma.AutoSize = false;
            this.mIdioma.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mIdioma.ForeColor = System.Drawing.Color.Gray;
            this.mIdioma.IconChar = FontAwesome.Sharp.IconChar.Language;
            this.mIdioma.IconColor = System.Drawing.Color.Black;
            this.mIdioma.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mIdioma.IconSize = 40;
            this.mIdioma.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mIdioma.Name = "mIdioma";
            this.mIdioma.Padding = new System.Windows.Forms.Padding(0);
            this.mIdioma.Size = new System.Drawing.Size(200, 50);
            this.mIdioma.Text = "IDIOMAS";
            this.mIdioma.Click += new System.EventHandler(this.mIdioma_Click);
            // 
            // mEmpleado
            // 
            this.mEmpleado.AutoSize = false;
            this.mEmpleado.ForeColor = System.Drawing.Color.Gray;
            this.mEmpleado.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.mEmpleado.IconColor = System.Drawing.Color.Black;
            this.mEmpleado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mEmpleado.Name = "mEmpleado";
            this.mEmpleado.Size = new System.Drawing.Size(244, 50);
            this.mEmpleado.Text = "PERSONA";
            this.mEmpleado.Click += new System.EventHandler(this.mEmpleado_Click);
            // 
            // mPuesto
            // 
            this.mPuesto.AutoSize = false;
            this.mPuesto.BackColor = System.Drawing.Color.DarkGray;
            this.mPuesto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNominal,
            this.mFuncional});
            this.mPuesto.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPuesto.ForeColor = System.Drawing.Color.Black;
            this.mPuesto.IconChar = FontAwesome.Sharp.IconChar.PeopleLine;
            this.mPuesto.IconColor = System.Drawing.Color.Black;
            this.mPuesto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mPuesto.IconSize = 40;
            this.mPuesto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mPuesto.Name = "mPuesto";
            this.mPuesto.Padding = new System.Windows.Forms.Padding(0);
            this.mPuesto.Size = new System.Drawing.Size(200, 100);
            this.mPuesto.Text = "PUESTOS";
            // 
            // mNominal
            // 
            this.mNominal.ForeColor = System.Drawing.Color.Gray;
            this.mNominal.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.mNominal.IconColor = System.Drawing.Color.Black;
            this.mNominal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mNominal.Name = "mNominal";
            this.mNominal.Size = new System.Drawing.Size(224, 34);
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
            this.mFuncional.Size = new System.Drawing.Size(224, 34);
            this.mFuncional.Text = "FUNCIONAL";
            this.mFuncional.Click += new System.EventHandler(this.mFuncional_Click);
            // 
            // mSolicitud
            // 
            this.mSolicitud.AutoSize = false;
            this.mSolicitud.BackColor = System.Drawing.Color.Gray;
            this.mSolicitud.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem2,
            this.iconMenuItem5});
            this.mSolicitud.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSolicitud.ForeColor = System.Drawing.Color.Black;
            this.mSolicitud.IconChar = FontAwesome.Sharp.IconChar.Wodu;
            this.mSolicitud.IconColor = System.Drawing.Color.Black;
            this.mSolicitud.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mSolicitud.IconSize = 40;
            this.mSolicitud.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mSolicitud.MergeIndex = 0;
            this.mSolicitud.Name = "mSolicitud";
            this.mSolicitud.Padding = new System.Windows.Forms.Padding(0);
            this.mSolicitud.Size = new System.Drawing.Size(200, 100);
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
            this.iconMenuItem2.Size = new System.Drawing.Size(225, 34);
            this.iconMenuItem2.Text = "TECNICO";
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconMenuItem5.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.Cow;
            this.iconMenuItem5.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Size = new System.Drawing.Size(225, 34);
            this.iconMenuItem5.Text = "JORNALERO";
            // 
            // mReportes
            // 
            this.mReportes.AutoSize = false;
            this.mReportes.BackColor = System.Drawing.Color.DarkGray;
            this.mReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem3,
            this.iconMenuItem4,
            this.iconMenuItem6});
            this.mReportes.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mReportes.ForeColor = System.Drawing.Color.Black;
            this.mReportes.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.mReportes.IconColor = System.Drawing.Color.Black;
            this.mReportes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mReportes.IconSize = 40;
            this.mReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mReportes.Name = "mReportes";
            this.mReportes.Padding = new System.Windows.Forms.Padding(0);
            this.mReportes.Size = new System.Drawing.Size(200, 100);
            this.mReportes.Text = "REPORTES";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(224, 34);
            this.iconMenuItem3.Text = "1";
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(224, 34);
            this.iconMenuItem4.Text = "2";
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.ForeColor = System.Drawing.Color.Gray;
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem6.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Size = new System.Drawing.Size(224, 34);
            this.iconMenuItem6.Text = "3";
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.White;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pContainer.Location = new System.Drawing.Point(300, 157);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1123, 769);
            this.pContainer.TabIndex = 5;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // mOtrosDatos
            // 
            this.mOtrosDatos.AutoSize = false;
            this.mOtrosDatos.ForeColor = System.Drawing.Color.Gray;
            this.mOtrosDatos.IconChar = FontAwesome.Sharp.IconChar.Dev;
            this.mOtrosDatos.IconColor = System.Drawing.Color.Black;
            this.mOtrosDatos.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mOtrosDatos.Name = "mOtrosDatos";
            this.mOtrosDatos.Size = new System.Drawing.Size(244, 46);
            this.mOtrosDatos.Text = "OTROS DATOS";
            this.mOtrosDatos.Click += new System.EventHandler(this.mOtrosDatos_Click);
            // 
            // mReferenciaPersonal
            // 
            this.mReferenciaPersonal.AutoSize = false;
            this.mReferenciaPersonal.ForeColor = System.Drawing.Color.Gray;
            this.mReferenciaPersonal.IconChar = FontAwesome.Sharp.IconChar.Passport;
            this.mReferenciaPersonal.IconColor = System.Drawing.Color.Black;
            this.mReferenciaPersonal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mReferenciaPersonal.Name = "mReferenciaPersonal";
            this.mReferenciaPersonal.Size = new System.Drawing.Size(320, 50);
            this.mReferenciaPersonal.Text = "REFERENCIA PERSONAL";
            this.mReferenciaPersonal.Click += new System.EventHandler(this.mReferenciaPersonal_Click);
            // 
            // mreferenciaLaboral
            // 
            this.mreferenciaLaboral.AutoSize = false;
            this.mreferenciaLaboral.ForeColor = System.Drawing.Color.Gray;
            this.mreferenciaLaboral.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.mreferenciaLaboral.IconColor = System.Drawing.Color.Black;
            this.mreferenciaLaboral.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mreferenciaLaboral.Name = "mreferenciaLaboral";
            this.mreferenciaLaboral.Size = new System.Drawing.Size(320, 50);
            this.mreferenciaLaboral.Text = "REFERENCIA LABORAL";
            this.mreferenciaLaboral.Click += new System.EventHandler(this.mreferenciaLaboral_Click);
            // 
            // mFisicaBiologica
            // 
            this.mFisicaBiologica.AutoSize = false;
            this.mFisicaBiologica.ForeColor = System.Drawing.Color.Gray;
            this.mFisicaBiologica.IconChar = FontAwesome.Sharp.IconChar.PersonRays;
            this.mFisicaBiologica.IconColor = System.Drawing.Color.Black;
            this.mFisicaBiologica.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mFisicaBiologica.Name = "mFisicaBiologica";
            this.mFisicaBiologica.Size = new System.Drawing.Size(260, 50);
            this.mFisicaBiologica.Text = "FISICA BIOLOGICA";
            this.mFisicaBiologica.Click += new System.EventHandler(this.mFisicaBiologica_Click);
            // 
            // mEperienciaLaboral
            // 
            this.mEperienciaLaboral.AutoSize = false;
            this.mEperienciaLaboral.ForeColor = System.Drawing.Color.Gray;
            this.mEperienciaLaboral.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.mEperienciaLaboral.IconColor = System.Drawing.Color.Black;
            this.mEperienciaLaboral.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mEperienciaLaboral.Name = "mEperienciaLaboral";
            this.mEperienciaLaboral.Size = new System.Drawing.Size(320, 50);
            this.mEperienciaLaboral.Text = "EXPERIENCIA LABORAL";
            this.mEperienciaLaboral.Click += new System.EventHandler(this.mEperienciaLaboral_Click);
            // 
            // mDatosAdicionales
            // 
            this.mDatosAdicionales.AutoSize = false;
            this.mDatosAdicionales.ForeColor = System.Drawing.Color.Gray;
            this.mDatosAdicionales.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.mDatosAdicionales.IconColor = System.Drawing.Color.Black;
            this.mDatosAdicionales.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.mDatosAdicionales.IconSize = 40;
            this.mDatosAdicionales.Name = "mDatosAdicionales";
            this.mDatosAdicionales.Size = new System.Drawing.Size(300, 50);
            this.mDatosAdicionales.Text = "DATOS ADICIONALES";
            this.mDatosAdicionales.Click += new System.EventHandler(this.mDatosAdicionales_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1196, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 132);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1423, 926);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.MenuStrip Menus;
        private FontAwesome.Sharp.IconMenuItem mHome;
        private FontAwesome.Sharp.IconMenuItem mPuesto;
        private System.Windows.Forms.Panel pContainer;
        private FontAwesome.Sharp.IconMenuItem mReportes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconMenuItem mPersona;
        private FontAwesome.Sharp.IconMenuItem mLocalizacion;
        private FontAwesome.Sharp.IconMenuItem mSocio;
        private FontAwesome.Sharp.IconMenuItem mFamilia;
        private FontAwesome.Sharp.IconMenuItem mEstudios;
        private FontAwesome.Sharp.IconMenuItem mIdioma;
        private FontAwesome.Sharp.IconMenuItem mEmpleado;
        private FontAwesome.Sharp.IconMenuItem mNominal;
        private FontAwesome.Sharp.IconMenuItem mFuncional;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem mSolicitud;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem mDatosAdicionales;
        private FontAwesome.Sharp.IconMenuItem mEperienciaLaboral;
        private FontAwesome.Sharp.IconMenuItem mFisicaBiologica;
        private FontAwesome.Sharp.IconMenuItem mreferenciaLaboral;
        private FontAwesome.Sharp.IconMenuItem mReferenciaPersonal;
        private FontAwesome.Sharp.IconMenuItem mOtrosDatos;
        private System.Windows.Forms.Button button1;
    }
}