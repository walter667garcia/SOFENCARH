using Capa_Negocio;
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
using System.Globalization;

namespace Capa_Vista.ExperienciaLaboral
{
    public partial class ExperienciaLaboralFormulario : Form
    {
        //Variables Necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para iniciar
        public int Idpersona {  get; set; }
        public string Evento { get; set; }

        public ExperienciaLaboralFormulario()
        {
            InitializeComponent();

            dtmFechaIngreso.Format = DateTimePickerFormat.Custom;
            dtmFechaIngreso.CustomFormat = "dd/MM/yyyy";
            dtmFechaRetiro.Format = DateTimePickerFormat.Custom;
            dtmFechaRetiro.CustomFormat = "dd/MM/yyyy";
        }

        //Eventos necesarios para movilizar el formulario
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            this.txtId.Text = string.Empty;
            this.txtEmpresa.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtJefe.Text = string.Empty;
            this.txtPuesto.Text = string.Empty;
            this.txtSalario.Text = string.Empty;
            dtmFechaIngreso.Text = string.Empty;
            dtmFechaRetiro.Text = string.Empty;
            this.txtMotivo.Text = string.Empty;
            this.cmbReferencia.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtDocumento.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            DateTime fechaIngreso = this.dtmFechaIngreso.Value;
            DateTime fechaRetiro = this.dtmFechaRetiro.Value;

            if (string.IsNullOrEmpty(this.txtEmpresa.Text) || 
                string.IsNullOrEmpty(this.txtSalario.Text) || 
                string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
                this.txtEmpresa.Text = "***";
                this.txtSalario.Text = "***";
                this.txtDescripcion.Text = "***";
                this.txtDocumento.Text = "***";
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
                if (Evento == "Nuevo")
                {
                    rpta = nExperienciaLaboral.Insertar(
                        Idpersona,
                        this.txtEmpresa.Text.Trim(),
                        this.txtTelefono.Text.Trim(),
                        this.txtJefe.Text.Trim(),
                        this.txtPuesto.Text.Trim(),
                        this.txtSalario.Text.Trim(),
                        fechaIngreso,
                        fechaRetiro,
                        this.txtMotivo.Text.Trim(),
                        this.cmbReferencia.Text.Trim(),
                        this.txtDescripcion.Text.Trim(),
                        this.txtDocumento.Text.Trim()
                    );
                }
                else if(Evento == "Editar")
                {
                    rpta = nExperienciaLaboral.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                        Idpersona,
                        this.txtEmpresa.Text.Trim(),
                        this.txtTelefono.Text.Trim(),
                        this.txtJefe.Text.Trim(),
                        this.txtPuesto.Text.Trim(),
                        this.txtSalario.Text.Trim(),
                        fechaIngreso,
                        fechaRetiro,
                        this.txtMotivo.Text.Trim(),
                        this.cmbReferencia.Text.Trim(),
                        this.txtDescripcion.Text.Trim(),
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
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void CargarDatos(string id, string empresa, string fechaIngreso, string fechaRetiro,
                                     string telefono, string jefe, string puesto, string salario,
                                     string motivo, string referencia, string descripcion, string documento)
        {
            this.txtId.Text = id;
            this.txtEmpresa.Text = empresa;
            this.dtmFechaIngreso.Text = fechaIngreso;
            this.dtmFechaRetiro.Text = fechaRetiro;
            this.txtTelefono.Text = telefono;
            this.txtJefe.Text = jefe;
            this.txtPuesto.Text = puesto;
            this.txtSalario.Text = salario;
            this.txtMotivo.Text = motivo;
            this.cmbReferencia.Text = referencia;
            this.txtDescripcion.Text = descripcion;
            this.txtDocumento.Text = documento;
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtSalario.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtSalario.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtSalario.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtSalario.SelectionStart = txtSalario.Text.Length;
        }
    }
}
