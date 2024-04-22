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
using Capa_Vista.Properties;
namespace SOFENCARH
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void frmConexion_Load(object sender, EventArgs e)
        {
            
        }
       
        public bool Conexion()
        {
            // Obtener los valores del formulario para la conexion
            string server = txtServer.Text;
            string database = txtDatabase.Text;
            string user = txtUser.Text;
            string password = txtPassword.Text;

            // Intentar establecer conexión a la base de datos string de connexion con parametros
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión establecida correctamente.");
                   
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

        private void GuardarConfiguracion()
        {
            try
            {
              
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
               
                // Modificar los valores de las configuraciones
                  config.AppSettings.Settings["Server"].Value = txtServer.Text;
                  config.AppSettings.Settings["Database"].Value = txtDatabase.Text;
                  config.AppSettings.Settings["User"].Value = txtUser.Text;
                  config.AppSettings.Settings["Password"].Value = txtPassword.Text;

                  // Guardar los cambios en el archivo de configuración
                  config.Save(ConfigurationSaveMode.Modified);
                  // Recargar la sección de configuración
                  ConfigurationManager.RefreshSection("appSettings");
                

                MessageBox.Show("Configuración guardada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la configuración: {ex.Message}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarConfiguracion();
        }

    }
    
}
