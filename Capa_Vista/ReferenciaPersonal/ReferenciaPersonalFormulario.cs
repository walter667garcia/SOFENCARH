using Capa_Negocio;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capa_Vista.ReferenciaPersonal
{
    public partial class ReferenciaPersonalFormulario : Form
    {

        //Variables necesarias para iniciar 
        public int Idpersona {  get; set; }
        public string Evento { get; set; }
        //Variables necesarias pra movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public ReferenciaPersonalFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtPersona.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");

            }
            else
            {

                // Luego, verifica si el número de teléfono tiene exactamente 8 dígitos
                if (Regex.Replace(txtTelefono.Text, @"[^\d]", "").Length != 8)
                {
                    MessageBox.Show("El número de teléfono debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    rpta = nReferenciaPersonal.Insertar(
                            Idpersona,
                             this.txtPersona.Text.Trim(),
                             this.txtTelefono.Text.Trim(),
                             this.txtRelacion.Text.Trim(),
                             this.txtDocumento.Text.Trim()
                             );

                }
                else if (this.Evento == "Editar")
                {
                    rpta = nReferenciaPersonal.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                          Idpersona,
                            this.txtPersona.Text.Trim(),
                            this.txtTelefono.Text.Trim(),
                            this.txtRelacion.Text.Trim(),
                            this.txtDocumento.Text.Trim()
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

        private void LimpiarCampos()
        {
            this.txtPersona.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtRelacion.Text = string.Empty;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void CargarDatos(string id, string persona, string telefono, string relacion, string documento)
        {
            this.txtId.Text = id;
            this.txtPersona.Text = persona;
            this.txtTelefono.Text = telefono;
            this.txtRelacion.Text = relacion;
            this.txtDocumento.Text = documento;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string TelefonoNumerico = Regex.Replace(txtTelefono.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (TelefonoNumerico.Length > 8)
            {
                TelefonoNumerico = TelefonoNumerico.Substring(0, 8);
            }

            // Asigna el texto limpio al TextBox
            txtTelefono.Text = TelefonoNumerico;
            // Coloca el cursor al final del texto
            txtTelefono.SelectionStart = txtTelefono.Text.Length;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private string rutaArchivo;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF|*.pdf|Todos los archivos|*.*";
            openFileDialog.FilterIndex = 1; // Establece el filtro predeterminado como PDF

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName; // Asignación del valor a la variable miembro

                // Verificar si el archivo seleccionado es un archivo PDF
                if (Path.GetExtension(rutaArchivo).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    // Mostrar la ruta del archivo en el cuadro de texto
                    txtDocumento.Text = rutaArchivo;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un archivo PDF.", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
