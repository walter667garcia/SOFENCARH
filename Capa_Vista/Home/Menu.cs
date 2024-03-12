using Capa_Vista;
using Capa_Vista.Actas;
using Capa_Vista.Home;
using Capa_Vista.Vacaciones;
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
        //variables para que el panel desplaze el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables para informacion de usuario
        public string nombreUsuario {  get; set; }

        private static IconMenuItem Menuactivo = null;
        private static Form FormActivo = null;
        public Menu(  )
        {
           InitializeComponent();

            // Configura un temporizador para actualizar la hora y la fecha cada segundo
            Timer temporizador = new Timer();
            temporizador.Interval = 1000; // 1000 milisegundos = 1 segundo
            temporizador.Tick += ActualizarHoraYFecha;
            temporizador.Start();
            // Llama a la función por primera vez para mostrar la hora y la fecha inicialmente
            ActualizarHoraYFecha(null, EventArgs.Empty);

        }

        private void ActualizarHoraYFecha(object sender, EventArgs e)
        {
            // Obtiene la hora y la fecha actual
            DateTime ahora = DateTime.Now;

            // Crea una cadena de formato personalizado para la fecha
            string formatoFecha = $"{ahora:dddd, dd MMMM yyyy}";

            // Actualiza el contenido del Label con la hora y la fecha en el nuevo formato
            lbFecha.Text = $"{formatoFecha}     {ahora.ToLongTimeString()}";
        }

        //funciones para desplazar el formulario desde el panel
        private void menuStrip2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void menuStrip2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void menuStrip2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void ValidarUsuario(String tipoUsuario)
        {
            // Ejemplo: Desactivar ciertos botones según el tipo de usuario
            if (tipoUsuario == "Administrador")
            {
                mHome.Visible = true;
                mHome.Enabled = true;
                mPersona.Visible = true;
                mPersona.Enabled = true;
                mPuesto.Visible = true;
                mPuesto.Enabled = true;
                mSolicitud.Visible = true;
                mSolicitud.Enabled = true;
                mVacaciones.Visible = true;
                mVacaciones.Enabled = true;
                lbUsuario.Text = tipoUsuario;
            }
            else if (tipoUsuario == "Empleado")
            {
                mHome.Visible = true;
                mHome.Enabled = true;
                lbUsuario.Text = tipoUsuario;
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
           // Login frm = new Login();
           // frm.Show();
        }

       

        private void mFuncional_Click(object sender, EventArgs e)
        {
           
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

        

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var ventanasAbiertasDespuesDeMenu = Application.OpenForms.Cast<Form>().SkipWhile(form => form != this).Skip(1);
            bool existenVentanasAbiertas = ventanasAbiertasDespuesDeMenu.Any();

            if (existenVentanasAbiertas)
            {
                // Advertir al usuario sobre las ventanas abiertas y preguntar si desea salir de la aplicación
                DialogResult result = MessageBox.Show("Hay ventanas abiertas en el menú. ¿Está seguro que desea salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Si el usuario elige salir, cierra todas las ventanas abiertas y finaliza la aplicación
                if (result == DialogResult.Yes)
                {
                    FormActivo.Close();
                    Application.Exit();
                }
            }
            else
            {
                // Si no hay ventanas abiertas, cierra la aplicación
                Application.Exit();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {
             frmActas actas = new frmActas();
            AbrirFormulario((IconMenuItem)sender, actas);
        }

        private void iconMenuItem3_Click(object sender, EventArgs e)
        {
            frmVacacionesPersona  periodos = new frmVacacionesPersona();
            AbrirFormulario((IconMenuItem)sender, periodos);
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            frmGraficas periodos = new frmGraficas();
            AbrirFormulario((IconMenuItem)sender, periodos);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
