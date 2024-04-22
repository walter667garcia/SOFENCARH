using Capa_Negocio;
using DocumentFormat.OpenXml.Vml.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capa_Vista.Educacion
{
    public partial class EducacionFormulario : Form
    {
        //variables para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //variables necesarias para iniciar
        
        public int Idpersona {  get; set; }
        public string Evento;

        public EducacionFormulario()
        {
            InitializeComponent();
            LlenarComboBoxes();
            dtmInicio.Format = DateTimePickerFormat.Custom;
            dtmInicio.CustomFormat = "dd/MM/yyyy";
            dtmFin.Format = DateTimePickerFormat.Custom;
            dtmFin.CustomFormat = "dd/MM/yyyy";
        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();
            cmbEducacion.DataSource = dataSet.Tables["TYNIVELACADEMICO"];
            cmbEducacion.DisplayMember = "ACADEMICO";
            cmbEducacion.ValueMember = "IDNIVEL_ACADEMICO";
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


        public void CargarDatos(string id, string educacion, string establecimiento, string fechainicio, string fechafin, string titulo, string especialidad, string documento)
        {
            txtId.Text = id;
          //  LlenarComboBoxes();
            int idEducacion = cmbEducacion.FindString(educacion);
            cmbEducacion.SelectedIndex = idEducacion;

            txtEstablecimiento.Text = establecimiento;
            dtmInicio.Text = fechainicio;
            dtmFin.Text = fechafin;
            txtTitulo.Text = titulo;
            txtEspecialidad.Text = especialidad;
            txtDocumento.Text = documento;
           
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }
        private void EducacionFormulario_Load(object sender, EventArgs e)
        {
           
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarCampos()
        {
            this.txtEstablecimiento.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.txtDocumento.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = this.dtmInicio.Value;
            DateTime fechaFin = this.dtmFin.Value;

            if (string.IsNullOrEmpty(this.txtEstablecimiento.Text) || string.IsNullOrEmpty(this.txtTitulo.Text) || string.IsNullOrEmpty(this.txtEspecialidad.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
                
            }
            else
            {
                string rpta = "";

                if (this.Evento == "Nuevo")
                {
                    rpta = nNivelAcademico.Insertar(
                        Idpersona,
                        Convert.ToInt32(this.cmbEducacion.SelectedValue),
                        this.txtEstablecimiento.Text.Trim(),
                        fechaInicio,
                        fechaFin,
                        this.txtTitulo.Text.Trim(),
                        this.txtEspecialidad.Text.Trim(),
                        this.txtDocumento.Text.Trim()
                    );
                }
                else if (this.Evento == "Editar")
                {

                    rpta = nNivelAcademico.Actualizar(
                         Convert.ToInt32(this.txtId.Text),
                        Idpersona,
                        Convert.ToInt32(this.cmbEducacion.SelectedValue),
                        this.txtEstablecimiento.Text.Trim(),
                        fechaInicio,
                        fechaFin,
                        this.txtTitulo.Text.Trim(),
                        this.txtEspecialidad.Text.Trim(),
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
