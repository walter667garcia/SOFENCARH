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

namespace Capa_Vista
{
    public partial class frmFamilia : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmFamilia()
        {
            InitializeComponent();
            
          


        }
        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
        }
        private void Limpiar()
        {
            this.txtIdFAmilia.Text = string.Empty;
            this.cmbIdPersona.SelectedIndex = -1;
            this.cmbTFamilia.SelectedIndex = -1;
            this.txtNombre.Text = string.Empty;
            this.txtOcupacion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtLTrabajo.Text = string.Empty;
            this.txtDTrabajo.Text = string.Empty;
            this.txtTelTrabajo.Text = string.Empty;


        }
        private void Habilitar(bool valor)
        {
            this.cmbIdPersona.Enabled = valor;
            this.cmbTFamilia.Enabled = valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtOcupacion.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtLTrabajo.ReadOnly = !valor;
            this.txtDTrabajo.ReadOnly = !valor;
            this.txtTelTrabajo.ReadOnly = !valor;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void Mostrar()
        {
            this.dtgTFamilia.DataSource = nFamilia.MostrarPersonas();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgTFamilia.Rows.Count);
        }
        private void OcultarColumnas()
        {
            this.dtgTFamilia.Columns[0].Visible = false;
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = this.dtmFecha.Value;
                if (string.IsNullOrEmpty(this.txtNombre.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtNombre, "Ingrese un nombre");

                }
                else
                {
                    string rpta = "";
                    if (this.IsNuevo)
                    {
                        rpta = nFamilia.Insertar(
                            Convert.ToInt32(this.cmbIdPersona.SelectedValue),
                            Convert.ToInt32(this.cmbTFamilia.SelectedValue),
                            this.txtNombre.Text.Trim().ToUpper(),
                            date,
                            this.txtOcupacion.Text.Trim().ToUpper(),
                            this.txtTelefono.Text.Trim().ToUpper(),
                            this.txtLTrabajo.Text.Trim().ToUpper(),
                            this.txtDTrabajo.Text.Trim().ToUpper(),
                            this.txtTelTrabajo.Text.Trim().ToUpper());
                    }
                    else
                    {
                        rpta = nFamilia.EditarFamilia(
                            Convert.ToInt32(this.txtIdFAmilia.Text),
                            Convert.ToInt32(this.cmbIdPersona.SelectedValue),
                            Convert.ToInt32(this.cmbTFamilia.SelectedValue),
                            this.txtNombre.Text.Trim().ToUpper(),
                            date,
                            this.txtOcupacion.Text.Trim().ToUpper(),
                            this.txtTelefono.Text.Trim().ToUpper(),
                            this.txtLTrabajo.Text.Trim().ToUpper(),
                            this.txtDTrabajo.Text.Trim().ToUpper(),
                            this.txtTelTrabajo.Text.Trim().ToUpper());

                    }

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk(this.IsNuevo ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.Habilitar(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtIdFAmilia.Text))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);

            }
            else
            {
                this.MensajeError("Debe buscar un registro para modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtIdFAmilia.Text = string.Empty;
        }
        private void BuscarFamilia()
        {
            this.dtgTFamilia.DataSource = nFamilia.Buscar(this.txtBuscar.Text);
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgTFamilia.Rows.Count);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarFamilia();
        }

        private void dtgTFamilia_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgTFamilia.CurrentRow != null)
            {
                this.txtIdFAmilia.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Id"].Value);
                this.txtNombre.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Nombre"].Value);
                this.txtOcupacion.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Ocupacion"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Telefono"].Value);
                this.txtLTrabajo.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Lug_TRabajo"].Value);
                this.txtDTrabajo.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Dir_Trabajo"].Value);
                this.txtTelTrabajo.Text = Convert.ToString(this.dtgTFamilia.CurrentRow.Cells["Tel_TRabajo"].Value);
                this.tabMantenimiento.SelectedIndex = 1;
            }
        }

            private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            cmbIdPersona.DataSource = dataSet.Tables["RHPERSONA"];


            cmbIdPersona.DisplayMember = "Nombre";
            cmbIdPersona.ValueMember = "IDPERSONA";

            cmbTFamilia.DataSource = dataSet.Tables["TYTIPOFAMILIA"];
            cmbTFamilia.DisplayMember = "TIPO_FAMILIA";
            cmbTFamilia.ValueMember = "IDTIPO_FAMILIA";

        }

        private void frmFamilia_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.LlenarComboBoxes();
            this.Habilitar(false);
            this.Botones();
            this.Mostrar();
        }
    }
}
