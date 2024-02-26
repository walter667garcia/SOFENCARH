using Capa_Vista;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFENCARH
{
    public partial class Menu : Form
    {

        private static IconMenuItem Menuactivo = null;
        private static Form FormActivo = null;
        public Menu( String usuario)
        {

           string user = usuario.Trim();
            InitializeComponent();
            ConfigureInterface(user);



        }



        private void ConfigureInterface(String usuario)
        {
            // Ejemplo: Desactivar ciertos botones según el tipo de usuario
            if (usuario == "operacion")
            {
                mPersona.Enabled = true;
                mHome.Enabled = true;
                MessageBox.Show($"¡Login exitoso! Tipo de usuario: {usuario}");
            }
            else if (usuario == "Tecnico")
            {
                mPersona.Enabled = false;
                mPuesto.Enabled = false;
                MessageBox.Show($"¡Login exitoso! Tipo de usuario: {usuario}");
            }

        }

       

        private void Menu_Load(object sender, EventArgs e)
        {
          
        }

        private void AbrirFormulario(IconMenuItem iconMenu, Form formulario)
        {
            if (FormActivo != null && FormActivo.GetType() == formulario.GetType())
            {
                // El formulario ya está abierto, no es necesario hacer nada
                return;
            }

           

            if (FormActivo != null)
            {
                FormActivo.Close();
            }

            FormActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;
            pContainer.Controls.Add(formulario);

            // Calcular el nuevo tamaño de la ventana principal
            int nuevoAncho = formulario.Width + pContainer.Left + pContainer.Margin.Left + pContainer.Margin.Right;
            int nuevoAlto = formulario.Height + pContainer.Top + pContainer.Margin.Top + pContainer.Margin.Bottom;

            // Establecer el nuevo tamaño de la ventana principal
            this.ClientSize = new Size(nuevoAncho, nuevoAlto);

            // Suscribirse al evento FormClosing para realizar acciones antes de cerrar
            formulario.FormClosing += (s, args) =>
            {
                
            };

            formulario.Show();
        }

       




      


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

       

        private void mFuncional_Click(object sender, EventArgs e)
        {
            frmPuesto_Funcional puesto = new frmPuesto_Funcional();
            AbrirFormulario((IconMenuItem)sender, puesto);
        }

        private void mSolicitud_Click(object sender, EventArgs e)
        {

        }

      

        private void mEmpleado_Click(object sender, EventArgs e)
        {
            frmPersona persona = new frmPersona();
            AbrirFormulario((IconMenuItem)sender, persona);
        }

        private void mHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            AbrirFormulario((IconMenuItem)sender, home);
        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mNominal_Click(object sender, EventArgs e)
        {
            frmPuestoNominal nominal = new frmPuestoNominal();
            AbrirFormulario((IconMenuItem)sender, nominal);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ext = new Login();
            ext.Show();
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            frmReporteEducacion reporte = new frmReporteEducacion();
            reporte.Show();
        }
    }
}
