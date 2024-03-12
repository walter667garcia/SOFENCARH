using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Actas
{
    public partial class ActasFormulario : Form
    {
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public ActasFormulario()
        {
           
            InitializeComponent();
            LlenarComboBoxes();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActasFormulario_Load(object sender, EventArgs e)
        {
          
        }

        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosPuestoFuncional();

            // Asignar los datos a los ComboBox específicos
            cmbPuesto.DataSource = dataSet.Tables["TYPUESTONOMINAL"];
            cmbPuesto.DisplayMember = "PUESTO_NOMINAL";
            cmbPuesto.ValueMember = "ID_PUESTO_NOMINAL";

            cmbSeccion.DataSource = dataSet.Tables["TYUNIDADSECCION"];
            cmbSeccion.DisplayMember = "UNIDAD_SECCION";
            cmbSeccion.ValueMember = "IDUNIDAD_SECCION";

            cmbRenglon.DataSource = dataSet.Tables["TYRENGLONPRESUPUESTARIO"];
            cmbRenglon.DisplayMember = "ABREVIATURA";
            cmbRenglon.ValueMember = "ID_RENGLON";

            cmbcoordinacion.DataSource = dataSet.Tables["TYCOORDINACION"];
            cmbcoordinacion.DisplayMember = "COORDINACION";
            cmbcoordinacion.ValueMember = "ID_COORDINACION";

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
            this.dtmingreso.Text = string.Empty;
            this.txtfuncional.Text = string.Empty;
            this.cmbcoordinacion.Text = string.Empty;
            this.cmbPuesto.Text = string.Empty;
            this.cmbRenglon.Text = string.Empty;
            this.cmbSeccion.Text = string.Empty;
            this.txtsalario.Text = string.Empty;
            this.txtdescripcion.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = this.dtmingreso.Value;
         
            if (string.IsNullOrEmpty(this.txtfuncional.Text) ||
                string.IsNullOrEmpty(this.cmbcoordinacion.Text) ||
                string.IsNullOrEmpty(this.cmbPuesto.Text) ||
                string.IsNullOrEmpty(this.cmbRenglon.Text) ||
                string.IsNullOrEmpty(this.cmbSeccion.Text) ||
                string.IsNullOrEmpty(this.txtsalario.Text) || 
                string.IsNullOrEmpty(this.txtdescripcion.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
            }
            else
            {
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    rpta = nActas.Insertar(
                        Idpersona,
                        fechaInicio,
                        this.txtfuncional.Text.Trim(),
                        Convert.ToInt32(this.cmbcoordinacion.SelectedValue),
                         Convert.ToInt32(this.cmbPuesto.SelectedValue),
                        Convert.ToInt32(this.cmbRenglon.SelectedValue),
                         Convert.ToInt32(this.cmbSeccion.SelectedValue),
                        this.txtsalario.Text.Trim(),
                        this.txtdescripcion.Text.Trim()
                    );
                } else if(this.Evento == "Editar")
                {
                     rpta = nActas.Actualizar(
                       Convert.ToInt32(this.txtId.Text),
                       Idpersona,
                       fechaInicio,
                       this.txtfuncional.Text.Trim(),
                       Convert.ToInt32(this.cmbcoordinacion.SelectedValue),
                        Convert.ToInt32(this.cmbPuesto.SelectedValue),
                       Convert.ToInt32(this.cmbRenglon.SelectedValue),
                        Convert.ToInt32(this.cmbSeccion.SelectedValue),
                       this.txtsalario.Text.Trim(),
                       this.txtdescripcion.Text.Trim()
                   );
                }

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se insertó de forma correcta el registro");
                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }

                LimpiarCampos();
            }
        }
        public void CargarDatos(string id, string fechaInicio, string puestoFuncional,
            string coordinacion,string puestoNominal,string renglon, string unidadSeccion, 
            string salario, string descripcion)
        {
            this.txtId.Text = id;
            this.dtmingreso.Text = fechaInicio;
            this.txtfuncional.Text = puestoFuncional;

            int idCoordinacion = cmbcoordinacion.FindString(coordinacion);
            cmbcoordinacion.SelectedIndex = idCoordinacion;

            int idNominal = cmbPuesto.FindString(puestoNominal);
            cmbPuesto.SelectedIndex = idNominal;

            int idRenglon = cmbRenglon.FindString(renglon);
            cmbRenglon.SelectedIndex = idRenglon;

            int idSeccion = cmbSeccion.FindString(unidadSeccion);
            cmbSeccion.SelectedIndex = idSeccion;

            this.txtsalario.Text = salario;
            this.txtdescripcion.Text = descripcion;

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

        private void txtsalario_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtsalario.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtsalario.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtsalario.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtsalario.SelectionStart = txtsalario.Text.Length;
        }

        private void txtfuncional_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtfuncional.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtfuncional.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtfuncional.SelectionStart = textoValidado.Length;
            }
        }

        private string ValidarTexto(string texto)
        {
            // Filtra letras (mayúsculas y minúsculas), espacios y puntos.
            string patron = "[a-zA-Z0-9áéíóúÁÉÍÓÚ-ñ -.,+]";

            StringBuilder textoValidado = new StringBuilder();

            foreach (char caracter in texto)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(caracter.ToString(), patron))
                {
                    textoValidado.Append(caracter);
                }
            }

            return textoValidado.ToString();
        }

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtdescripcion.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtdescripcion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtdescripcion.SelectionStart = textoValidado.Length;
            }
        }
    }
}
