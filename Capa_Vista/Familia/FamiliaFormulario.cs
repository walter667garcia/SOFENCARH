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

namespace Capa_Vista.Familia
{
    public partial class FamiliaFormulario : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para el funcionamiento
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }

        public FamiliaFormulario()
        {
            InitializeComponent();
            LlenarComboBoxes();
            dtmFecha.Format = DateTimePickerFormat.Custom;
            dtmFecha.CustomFormat = "dd/MM/yyyy";
        }

        private void FamiliaFormulario_Load(object sender, EventArgs e)
        {
           
        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();
            cmbTFamilia.DataSource = dataSet.Tables["TYTIPOFAMILIA"];
            cmbTFamilia.DisplayMember = "TIPO_FAMILIA";
            cmbTFamilia.ValueMember = "IDTIPO_FAMILIA";

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
          
            this.cmbTFamilia.SelectedValue = 0;
            this.txtNombre.Text = string.Empty;
            dtmFecha.Text = string.Empty;
            this.txtOcupacion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtLTrabajo.Text = string.Empty;
            this.txtDTrabajo.Text = string.Empty;
            this.txtTelTrabajo.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fecha = dtmFecha.Value;
            if (string.IsNullOrEmpty(this.txtNombre.Text) ||
              string.IsNullOrEmpty(this.txtTelefono.Text) ||
              string.IsNullOrEmpty(this.txtTelTrabajo.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
                this.txtNombre.Text = "***";
                this.txtTelefono.Text = "***";
                this.txtTelTrabajo.Text = "***";
            }
            else
            {

                // Verifica si el número de teléfono tiene exactamente 8 dígitos en txtTelefono o txtTeltrabajo
                if (Regex.Replace(txtTelefono.Text, @"[^\d]", "").Length != 8 || Regex.Replace(txtTelTrabajo.Text, @"[^\d]", "").Length != 8)
                {
                    MessageBox.Show("El número de teléfono debe tener exactamente 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    rpta = nFamilia.Insertar(
                       Idpersona,
                        Convert.ToInt32(this.cmbTFamilia.SelectedValue),
                        this.txtNombre.Text.Trim(),
                        fecha,
                        this.txtOcupacion.Text.Trim(),
                        this.txtTelefono.Text.Trim(),
                        this.txtLTrabajo.Text.Trim(),
                        this.txtDTrabajo.Text.Trim(),
                        this.txtTelTrabajo.Text.Trim());
                }
                else if (this.Evento == "Editar")
                {
                    rpta = nFamilia.EditarFamilia(
                        Convert.ToInt32(this.txtId.Text),
                       Idpersona,
                        Convert.ToInt32(this.cmbTFamilia.SelectedValue),
                        this.txtNombre.Text.Trim(),
                        fecha,
                        this.txtOcupacion.Text.Trim(),
                        this.txtTelefono.Text.Trim(),
                        this.txtLTrabajo.Text.Trim(),
                        this.txtDTrabajo.Text.Trim(),
                        this.txtTelTrabajo.Text.Trim());
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
        public void CargarDatos(string Id,string Familia, string Nombre, string f_nacimiento,
                            string Ocupacion, string Telefono, string Lug_TRabajo,
                            string Dir_Trabajo, string Tel_TRabajo)
        {
            this.txtId.Text = Id;

            int idfamilia = cmbTFamilia.FindStringExact(Familia);
            cmbTFamilia.SelectedIndex = idfamilia;

            this.txtNombre.Text = Nombre;
            dtmFecha.Text = f_nacimiento;
            this.txtOcupacion.Text = Ocupacion;
            this.txtTelefono.Text = Telefono;
            this.txtLTrabajo.Text = Lug_TRabajo;
            this.txtDTrabajo.Text = Dir_Trabajo;
            this.txtTelTrabajo.Text = Tel_TRabajo;
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

        private void txtTelTrabajo_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string TelefonoNumerico = Regex.Replace(txtTelTrabajo.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (TelefonoNumerico.Length > 8)
            {
                TelefonoNumerico = TelefonoNumerico.Substring(0, 8);
            }

            // Asigna el texto limpio al TextBox
            txtTelTrabajo.Text = TelefonoNumerico;
            // Coloca el cursor al final del texto
            txtTelTrabajo.SelectionStart = txtTelTrabajo.Text.Length;
        }

        private void dtmFecha_ValueChanged(object sender, EventArgs e)
        {
            // Calcula la edad
            DateTime fechaNacimiento = dtmFecha.Value;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Verifica si aún no ha pasado el cumpleaños de este año
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            // Asigna la edad al campo correspondiente
            txtEdad.Text = edad.ToString();
        }
    }
}
