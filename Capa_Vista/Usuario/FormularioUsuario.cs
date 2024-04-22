using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Usuario
{
    public partial class FormularioUsuario : Form
    {
        public int IdUsuario {  get; set; }
        public string Evento {  get; set; }
    
        public FormularioUsuario()
        {
            InitializeComponent();
            LlenarComboBoxes();
        }

        private void FormularioUsuario_Load(object sender, EventArgs e)
        {

        }

        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosPersona();
            cmbTipousuario.DataSource = dataSet.Tables["TiposUsuario"];
            cmbTipousuario.DisplayMember = "TipoUsuario";
            cmbTipousuario.ValueMember = "TipoUsuarioID";

        }
        private byte[] ObtenerImagenComoBytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imagenBytes = pcbFoto.Image != null ? ObtenerImagenComoBytes(pcbFoto.Image) : null;
            if (string.IsNullOrEmpty(this.txtNombre.Text)
              
               )
            {
                
                MensajeError("Falta ingresar algunos datos Remarcados");
            }
            else
            {
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                  
                    rpta = nUsuarios.InsertarUsuario(
                    txtNombre.Text.Trim(),
                    txtContraseña.Text.Trim(),
                    Convert.ToBoolean(cmbEstado.SelectedValue),
                    Convert.ToInt32(cmbTipousuario.SelectedValue),
                     imagenBytes);

                }
                else if (this.Evento == "Editar")
                {
                    rpta = nUsuarios.EditarUsuario(
                    IdUsuario,
                    txtNombre.Text.Trim(),
                    txtContraseña.Text.Trim(),
                    Convert.ToBoolean(cmbEstado.SelectedValue),
                    Convert.ToInt32(cmbTipousuario.SelectedValue),
                    imagenBytes
                 );

                }

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk(this.Evento == "Nuevo" ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                   
                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }


            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private Image imagenActual;
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            // Configura el filtro para permitir solo imágenes
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
            DialogResult rs = ofd.ShowDialog();

            if (rs == DialogResult.OK)
            {
                // Guarda la imagen actual antes de cargar una nueva imagen
                imagenActual = pcbFoto.Image;

                // Verifica si el archivo seleccionado es una imagen
                string extension = Path.GetExtension(ofd.FileName).ToLower();
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp")
                {
                    try
                    {
                        // Carga la imagen
                        Image img = Image.FromFile(ofd.FileName);

                        // Verifica el tamaño de la imagen en centímetros
                        float anchoCm = img.Width / img.HorizontalResolution * 2.54f; // Ancho en centímetros
                        float altoCm = img.Height / img.VerticalResolution * 2.54f; // Alto en centímetros

                        // Define el tamaño máximo permitido (en centímetros)
                        float maxAnchoCm = 10; // 10 cm de ancho
                        float maxAltoCm = 15; // 15 cm de alto

                        if (anchoCm > maxAnchoCm || altoCm > maxAltoCm)
                        {
                            MessageBox.Show("El tamaño de la imagen es demasiado grande. Por favor, selecciona una imagen más pequeña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Sale de la función sin cargar la imagen
                        }

                        // Carga la imagen si pasa todas las verificaciones
                        pcbFoto.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Restaura la imagen anterior
                        pcbFoto.Image = imagenActual;
                    }
                }
                else
                {
                    // Muestra un mensaje de error si el archivo no es una imagen
                    MessageBox.Show("Por favor, selecciona un archivo de imagen válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Restaura la imagen anterior
                    pcbFoto.Image = imagenActual;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
