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

            if (FormActivo != null && !ConfirmarCierreFormulario())
            {
                // El usuario canceló el cierre del formulario actual
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
                // Lógica de limpieza o validación antes de cerrar el formulario
                if (!ConfirmarCierreFormulario())
                {
                    args.Cancel = true; // Cancelar el cierre del formulario si el usuario cancela
                }
            };

            formulario.Show();
        }

        private bool ConfirmarCierreFormulario()
        {
            // Muestra un cuadro de diálogo de confirmación al usuario
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cerrar la ventana actual? Se perderán los datos no guardados.", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return resultado == DialogResult.Yes;
        }




      


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login ext = new Login();
            ext.Show();
        }

        

       

        private void mFuncional_Click(object sender, EventArgs e)
        {
            frmPuesto_Funcional puesto = new frmPuesto_Funcional();
            AbrirFormulario((IconMenuItem)sender, puesto);
        }

        private void mSolicitud_Click(object sender, EventArgs e)
        {

        }

        private void mLocalizacion_Click(object sender, EventArgs e)
        {
            frmLocalizacion localizacion = new frmLocalizacion();
            AbrirFormulario((IconMenuItem)sender, localizacion);
        }

        private void mSocio_Click(object sender, EventArgs e)
        {
            frmSocio_Economico socio = new frmSocio_Economico();
            AbrirFormulario((IconMenuItem)sender, socio);
        }

        private void mFamilia_Click(object sender, EventArgs e)
        {
            frmFamilia familia = new frmFamilia();
            AbrirFormulario((IconMenuItem)sender, familia);
        }

        private void mEstudios_Click(object sender, EventArgs e)
        {
            frmNivel_Academico estudios = new frmNivel_Academico();
            AbrirFormulario((IconMenuItem)sender, estudios);
        }

        private void mIdioma_Click(object sender, EventArgs e)
        {
            frmIdioma idioma = new frmIdioma();
            AbrirFormulario((IconMenuItem)sender, idioma);
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

        private void mDatosAdicionales_Click(object sender, EventArgs e)
        {
            frmDatosAdicionales Adicionales = new frmDatosAdicionales();
            AbrirFormulario((IconMenuItem)sender, Adicionales);
        }

        private void mEperienciaLaboral_Click(object sender, EventArgs e)
        {
            frmExperienciaLaboral experienciaLaboral = new frmExperienciaLaboral();
            AbrirFormulario((IconMenuItem)sender, experienciaLaboral);
        }

        private void mFisicaBiologica_Click(object sender, EventArgs e)
        {
            frmFisicoBiologico fisicoBiologico = new frmFisicoBiologico();
            AbrirFormulario((IconMenuItem)sender, fisicoBiologico);
        }

        private void mreferenciaLaboral_Click(object sender, EventArgs e)
        {
            frmReferenciaLaboral referenciaLaboral = new frmReferenciaLaboral();
            AbrirFormulario((IconMenuItem)sender, referenciaLaboral);
        }

        private void mReferenciaPersonal_Click(object sender, EventArgs e)
        {
            frmReferenciaPersonal referenciaPersonal = new frmReferenciaPersonal();
            AbrirFormulario((IconMenuItem)sender, referenciaPersonal);
        }

        private void mOtrosDatos_Click(object sender, EventArgs e)
        {

            frmOtrosDatos otrosDatos = new frmOtrosDatos();
            AbrirFormulario((IconMenuItem)sender, otrosDatos);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
