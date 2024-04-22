using Capa_Vista;
using Capa_Vista.Actas;
using Capa_Vista.Usuario;
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
using System.Xml.Linq;

namespace SOFENCARH
{
    public partial class Menu : Form
    { //variables par movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Menu()
        {
            InitializeComponent();

            // Inicializar el temporizador
            timer1.Interval = 1; // Intervalo de 1 segundo
            timer1.Tick += timer1_Tick; // Asociar el evento Tick del temporizador
            timer1.Start(); // Iniciar el temporizador
        }
        private static Form FormActivo = null;
        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void AbrirFormulario( Form formulario)
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
          
            pnlContenedor.Controls.Add(formulario);

            // Calcular el nuevo tamaño de la ventana principal
            int nuevoAncho = formulario.Width + pnlContenedor.Left + pnlContenedor.Margin.Left + pnlContenedor.Margin.Right;
            int nuevoAlto = formulario.Height + pnlContenedor.Top + pnlContenedor.Margin.Top + pnlContenedor.Margin.Bottom;

            // Establecer el nuevo tamaño de la ventana principal
            this.ClientSize = new Size(nuevoAncho, nuevoAlto);

            // Suscribirse al evento FormClosing para realizar acciones antes de cerrar
            formulario.FormClosing += (s, args) =>
            {

            };

            formulario.Show();
        }

        private void pcbMenuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario usuario = new frmUsuario();
            AbrirFormulario(usuario);
            pnlMenuUsuarios.BackColor = Color.DodgerBlue;
            pnMenuEmpleado.BackColor = Color.DarkGray;
            pnlMenuActas.BackColor = Color.DarkGray;
            pnlMenuVacaciones.BackColor = Color.DarkGray;
        }

        private void pcbMenuEmpleados_Click(object sender, EventArgs e)
        {
            frmPersona persona = new frmPersona();
            AbrirFormulario(persona);
            pnMenuEmpleado.BackColor = Color.DodgerBlue;
            pnlMenuUsuarios.BackColor = Color.DarkGray;
            pnlMenuActas.BackColor = Color.DarkGray;
            pnlMenuVacaciones.BackColor = Color.DarkGray;

        }

        private void pcbMenuVacaciones_Click(object sender, EventArgs e)
        {
            frmVacacionesPersona vacaciones = new frmVacacionesPersona();
            AbrirFormulario(vacaciones);

            pnlMenuVacaciones.BackColor = Color.DodgerBlue;
            pnMenuEmpleado.BackColor = Color.DarkGray;
            pnlMenuUsuarios.BackColor = Color.DarkGray;
            pnlMenuActas.BackColor = Color.DarkGray;
        }

        private void pcbMenuActas_Click(object sender, EventArgs e)
        {
            frmActas actas = new frmActas();
            AbrirFormulario(actas);
            pnlMenuActas.BackColor = Color.DodgerBlue;
            pnMenuEmpleado.BackColor = Color.DarkGray;
            pnlMenuUsuarios.BackColor = Color.DarkGray;
            pnlMenuVacaciones.BackColor = Color.DarkGray;

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

        private void pcbMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimineto mantenimiento = new frmMantenimineto();
            AbrirFormulario(mantenimiento);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime now = DateTime.Now;

            // Actualizar el texto del Label con la fecha y hora actual
            label7.Text = now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
