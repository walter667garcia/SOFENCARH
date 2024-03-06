using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Actas
{
    public partial class ActasFormulario : Form
    {
        private int Idpersona;
        public ActasFormulario(int idpersona)
        {
            Idpersona = idpersona;
            InitializeComponent();
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
            LlenarComboBoxes();
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

                
                    rpta = nActas.Insertar(
                        Idpersona,
                        fechaInicio,
                        this.txtfuncional.Text.Trim().ToUpper(),
                        Convert.ToInt32(this.cmbcoordinacion.SelectedValue),
                         Convert.ToInt32(this.cmbPuesto.SelectedValue),
                        Convert.ToInt32(this.cmbRenglon.SelectedValue),
                         Convert.ToInt32(this.cmbSeccion.SelectedValue),
                        this.txtsalario.Text.Trim().ToUpper(),
                        this.txtdescripcion.Text.Trim().ToUpper()
                    );
                

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
    }
}
