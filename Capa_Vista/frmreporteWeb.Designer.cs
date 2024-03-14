namespace Capa_Vista
{
    partial class frmreporteWeb
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.sp_ListarHomeReferenciaLaboralTableAdapter1 = new Capa_Vista.ReporteDataSetTableAdapters.sp_ListarHomeReferenciaLaboralTableAdapter();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1267, 786);
            this.webBrowser1.TabIndex = 0;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // sp_ListarHomeReferenciaLaboralTableAdapter1
            // 
            this.sp_ListarHomeReferenciaLaboralTableAdapter1.ClearBeforeFill = true;
            // 
            // frmreporteWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 786);
            this.Controls.Add(this.webBrowser1);
            this.Name = "frmreporteWeb";
            this.Text = "frmreporteWeb";
            this.Load += new System.EventHandler(this.frmreporteWeb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private ReporteDataSetTableAdapters.sp_ListarHomeReferenciaLaboralTableAdapter sp_ListarHomeReferenciaLaboralTableAdapter1;
    }
}