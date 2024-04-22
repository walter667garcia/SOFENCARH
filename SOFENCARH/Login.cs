using Capa_Vista;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            authService = new vLogin();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Código adicional de inicialización si es necesario
        }

        public bool Conexion()
        {
            // Obtener los valores de configuración de la aplicación
            string Server = ConfigurationManager.AppSettings["Server"];
            string Database = ConfigurationManager.AppSettings["Database"];
            string User = ConfigurationManager.AppSettings["User"];
            string Password = ConfigurationManager.AppSettings["Password"];

            // Intentar establecer conexión a la base de datos string de connexion con parametros
            string connectionString = $"Data Source={Server};Initial Catalog={Database};User ID={User};Password={Password};";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión establecida correctamente.");
                    Validad();
                    connection.Close();
                    return true; // Devolver verdadero si la conexión se estableció con éxito 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");
                    return false; // Devolver falso si hubo un error al conectar
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion();
          


        }

        private void Validad()
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
                    /* Menu menu = new Menu();
                     menu.ValidarUsuario(userType);
                     menu.Show();
                     this.Close();
                    */
                    Menu a = new Menu();
                    a.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            frmConexion con = new frmConexion();
            con.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
