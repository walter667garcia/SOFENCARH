using Capa_Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFENCARH
{
    public partial class Login : Form
    {
        private vLogin  authService;
        public Login()
        {
            InitializeComponent();
            DibujarBordesRedondos(this);
            authService = new vLogin();

        }

        private void DibujarBordesRedondos(Form formulario)
        {
            // Crear un objeto GraphicsPath para definir la forma del formulario
            GraphicsPath path = new GraphicsPath();

            int radio = 20; // Puedes ajustar el radio según tus preferencias

            // Agregar arcos para las esquinas redondas
            path.AddArc(new Rectangle(0, 0, radio * 2, radio * 2), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(formulario.Width - radio * 2, 0, radio * 2, radio * 2), 270, 90); // Esquina superior derecha
            path.AddArc(new Rectangle(formulario.Width - radio * 2, formulario.Height - radio * 2, radio * 2, radio * 2), 0, 90); // Esquina inferior derecha
            path.AddArc(new Rectangle(0, formulario.Height - radio * 2, radio * 2, radio * 2), 90, 90); // Esquina inferior izquierda

            // Cerrar la forma
            path.CloseFigure();

            // Asignar el objeto GraphicsPath al objeto Region del formulario
            formulario.Region = new Region(path);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Código adicional de inicialización si es necesario
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUser.Text;
                string password = txtPassword.Text;
                string userType;
                bool isValid;
                bool isValidUser = authService.validad(username, password, out isValid, out userType);

                if (isValidUser)
                {
                    Menu menu = new Menu(userType);
                    menu.Show();
                    this.Hide();
                    // MessageBox.Show($"¡Login exitoso! Tipo de usuario: {userType}");
                }
                else
                {
                    MessageBox.Show("Error en el login. Verifique sus credenciales o su cuenta está desactivada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la autenticación: " + ex.Message);
            }
        }

       

       

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
