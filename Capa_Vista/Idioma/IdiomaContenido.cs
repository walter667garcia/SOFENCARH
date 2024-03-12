using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista
{
    public partial class IdiomaContenido : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para el funcionamiento
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }
        public IdiomaContenido()
        {
            InitializeComponent();

            LlenarComboBoxes();
        }
        private void IdiomaContenido_Load(object sender, EventArgs e)
        {
           
        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            // Asignar los datos a los ComboBox específicos
            cmbIdioma.DataSource = dataSet.Tables["TYIDIOMA"];
            cmbIdioma.DisplayMember = "IDIOMA";
            cmbIdioma.ValueMember = "IDIDIOMA";
        }


        //Eventos necesarios para movilizar el formulario
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void llenarDatos()
        {



            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            // Asignar los datos a los ComboBox específicos
            cmbIdioma.DataSource = dataSet.Tables["TYIDIOMA"];
            cmbIdioma.DisplayMember = "IDIOMA";
            cmbIdioma.ValueMember = "IDIDIOMA";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tkbConversacion_ValueChanged(object sender, EventArgs e)
        {
            int value = tkbConversacion.Value;
            lbConversacion.Text = $"{value}%";
        }

        private void tkbEscritura_ValueChanged(object sender, EventArgs e)
        {
            int value = tkbEscritura.Value;
            lbEscritura.Text = $"{value}%";
        }

        private void tkbLectura_ValueChanged(object sender, EventArgs e)
        {
            int value = tkbLectura.Value;
            lbLectura.Text = $"{value}%";
        }


        private string rutaArchivo;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;

                // Mostrar la ruta del archivo en el cuadro de texto
                txtDocumento.Text = rutaArchivo;
            }

        }




        private void LimpiarCampos()
        {
            this.tkbConversacion.Text = string.Empty;
            this.txtDocumento.Text = string.Empty;
            this.tkbEscritura.Text = string.Empty;
            this.tkbLectura.Text = string.Empty;
            this.cmbIdioma.SelectedIndex = -1;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDocumento.Text)  
                
               
                )
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
            }
            else
            {
                string rpta = "";
            if (this.Evento =="Nuevo")
            {
                rpta = nIdioma.Insertar(
                Idpersona,
                Convert.ToInt32(cmbIdioma.SelectedValue),
                tkbConversacion.Value.ToString(),
                tkbEscritura.Value.ToString(),
                tkbLectura.Value.ToString(),
                txtDocumento.Text.Trim()
            );
               
            }
            else if (this.Evento == "Editar")
            {
                rpta = nIdioma.Actualizar(
                Convert.ToInt32(this.txtId.Text),
                Idpersona,
                Convert.ToInt32(cmbIdioma.SelectedValue),
                tkbConversacion.Value.ToString(),
                tkbEscritura.Value.ToString(),
                tkbLectura.Value.ToString(),
                txtDocumento.Text.Trim()
             );
                   
            }

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk(this.Evento == "Nuevo" ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    LimpiarCampos();
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
        public void CargarDatos(string Id, string Idioma, string Conversacion, string Escritura, string Lectura, string Documento)
        {
            this.txtId.Text = Id;

            int idIdioma = cmbIdioma.FindStringExact(Idioma);
            cmbIdioma.SelectedIndex = idIdioma;

            // Convertir las cadenas a valores numéricos antes de asignarlos a los controles de TrackBar
            int valorConversacion = int.Parse(Conversacion);
            int valorEscritura = int.Parse(Escritura);
            int valorLectura = int.Parse(Lectura);

            this.tkbConversacion.Value = valorConversacion;
            this.tkbEscritura.Value = valorEscritura;
            this.tkbLectura.Value = valorLectura;

            this.txtDocumento.Text = Documento;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rutaActual = txtDocumento.Text;

            if (!string.IsNullOrEmpty(rutaActual) && System.IO.File.Exists(rutaActual))
            {
                // Abrir el archivo con el visor predeterminado del sistema
                System.Diagnostics.Process.Start(rutaActual);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un archivo válido o la ruta del archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
