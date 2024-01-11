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

namespace Capa_Vista
{
    public partial class frmSocio_Economico : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmSocio_Economico()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
            cmbPersona.DisplayMember = "Nombre";
            cmbPersona.ValueMember = "IDPERSONA";

            cmbVehiculo.DataSource = dataSet.Tables["TYVEHICULO"];
            cmbVehiculo.DisplayMember = "VEHICULO";
            cmbVehiculo.ValueMember = "IDVEHICULO";

            cmbVivienda.DataSource = dataSet.Tables["TYVIVIENDA"];
            cmbVivienda.DisplayMember = "VIVIENDA";
            cmbVivienda.ValueMember = "IdVIVIENDA";

            cmbAgrupacion.DataSource = dataSet.Tables["TYAGRUPACION"];
            cmbAgrupacion.DisplayMember = "AGRUPACION";
            cmbAgrupacion.ValueMember = "IDAGRUPACION";


        }
        private void Mostrar()
        {

            this.dtgSocioEconomico.DataSource = nSocioEconomico.MostrarSocioEconomico();
            this.OcultarColumnas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgSocioEconomico.Rows.Count);
        }
        private void frmSocio_Economico_Load(object sender, EventArgs e)
        {

            this.Top = 0;
            this.Left = 0;

            this.Mostrar();

            this.Habilitar(false);
            this.Botones();
            this.LlenarComboBoxes();
        }
        private void BuscarPersona()
        {
            this.dtgSocioEconomico.DataSource = nSocioEconomico.BuscarSocioEconomico(this.txtBuscar.Text);

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgSocioEconomico.Rows.Count - 1);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgSocioEconomico.Columns.Count > 0)
                {
                    this.dtgSocioEconomico.Columns[0].Visible = false;

                }
                else
                {
                    MessageBox.Show("No hay columnas para ocultar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intentar ocultar columnas: {ex.Message}");
            }
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
            this.cmbPersona.SelectedIndex = -1;
            this.cmbAgrupacion.SelectedIndex = -1;

            this.txtDetalleAgrupacion.Text = string.Empty;
            this.txtDependencias.Text = string.Empty;
            this.txtDetalleDependencias.Text = string.Empty;
            this.cmbVivienda.SelectedIndex = -1;

            this.txtPagoVivienda.Text = string.Empty;
            this.txtFlagDeuda.Text = string.Empty;
            this.txtMontoDeuda.Text = string.Empty;
            this.txtMotivoDeuda.Text = string.Empty;

            this.txtFlagOtrosIngresos.Text = string.Empty;
            this.txtMontoOtrosIngresos.Text = string.Empty;
            this.txtFuenteOtrosIngresos.Text = string.Empty;
            this.cmbVehiculo.SelectedIndex = -1;
            this.txtTipoVehiculo.Text = string.Empty;
            this.txtPlacaVehiculo.Text = string.Empty;
            this.txtModeloVehiculo.Text = string.Empty;




        }

        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;
            this.cmbAgrupacion.Enabled = valor;
            this.txtDetalleAgrupacion.ReadOnly = !valor;
            this.txtDependencias.ReadOnly = !valor;
            this.txtDetalleDependencias.ReadOnly = !valor;

            this.cmbVivienda.Enabled = valor;
            this.txtPagoVivienda.ReadOnly = !valor;
            this.txtFlagDeuda.ReadOnly = !valor;
            this.txtMontoDeuda.ReadOnly = !valor;
            this.txtMotivoDeuda.ReadOnly = !valor;

            this.txtFlagOtrosIngresos.ReadOnly = !valor;
            this.txtMontoOtrosIngresos.ReadOnly = !valor;
            this.txtFuenteOtrosIngresos.ReadOnly = !valor;
            this.cmbVehiculo.Enabled = valor;
            this.txtTipoVehiculo.ReadOnly = !valor;
            this.txtPlacaVehiculo.ReadOnly = !valor;
            this.txtModeloVehiculo.ReadOnly = !valor;

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtId.Text = string.Empty;
            this.Habilitar(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.cmbPersona.Focus();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.txtDetalleAgrupacion.Text)
                        )
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtDetalleAgrupacion, "Ingrese un detalle de agrupacion");

                }
                else
                {


                    string rpta = "";
                    if (this.IsNuevo)
                    {
                        rpta = nSocioEconomico.Insertar(

                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            Convert.ToInt32(this.cmbAgrupacion.SelectedValue),
                            this.txtDetalleAgrupacion.Text.Trim().ToUpper(),
                            this.txtDependencias.Text.Trim().ToUpper(),
                            this.txtDetalleDependencias.Text.Trim().ToUpper(),

                            Convert.ToInt32(this.cmbVivienda.SelectedValue),
                            this.txtPagoVivienda.Text.Trim().ToUpper(),
                            this.txtFlagDeuda.Text.Trim().ToUpper(),
                            this.txtMontoDeuda.Text.Trim().ToUpper(),
                            this.txtMotivoDeuda.Text.Trim().ToUpper(),

                             this.txtFlagOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtMontoOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtFuenteOtrosIngresos.Text.Trim().ToUpper(),
                             Convert.ToInt32(this.cmbVehiculo.SelectedValue),

                             this.txtTipoVehiculo.Text.Trim().ToUpper(),
                            this.txtPlacaVehiculo.Text.Trim().ToUpper(),
                            this.txtModeloVehiculo.Text.Trim().ToUpper());
                    }
                    else if (this.IsEditar)
                    {


                        rpta = nSocioEconomico.Actualizar(

                            Convert.ToInt32(this.txtId.Text), 
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            Convert.ToInt32(this.cmbAgrupacion.SelectedValue),
                            this.txtDetalleAgrupacion.Text.Trim().ToUpper(),
                            this.txtDependencias.Text.Trim().ToUpper(),
                            this.txtDetalleDependencias.Text.Trim().ToUpper(),

                            Convert.ToInt32(this.cmbVivienda.SelectedValue),
                            this.txtPagoVivienda.Text.Trim().ToUpper(),
                            this.txtFlagDeuda.Text.Trim().ToUpper(),
                            this.txtMontoDeuda.Text.Trim().ToUpper(),
                            this.txtMotivoDeuda.Text.Trim().ToUpper(),

                            this.txtFlagOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtMontoOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtFuenteOtrosIngresos.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.cmbVehiculo.SelectedValue),

                            this.txtTipoVehiculo.Text.Trim().ToUpper(),
                            this.txtPlacaVehiculo.Text.Trim().ToUpper(),
                            this.txtModeloVehiculo.Text.Trim().ToUpper()
                           );
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // También puedes registrar la excepción en un archivo de registro.
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtId.Text))
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

        private void dtgSocioEconomico_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgSocioEconomico.CurrentRow != null)
            {
                this.txtDetalleAgrupacion.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["DETALLE_AGRUPACION"].Value);
                this.txtDependencias.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["DEPENDIENTES"].Value);
                this.txtDetalleDependencias.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["DETALLE_DEPENDIENTES"].Value);
                this.txtPagoVivienda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["PAGO_VIVIENDA"].Value);
                this.txtFlagDeuda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["FLAG_DEUDAS"].Value);
                this.txtMontoDeuda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["MONTO_DEUDA"].Value);
                this.txtMotivoDeuda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["MOTIVO_DEUDA"].Value);
                this.txtFlagOtrosIngresos.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["FLAG_OTROS_INGRESOS"].Value);
                this.txtMontoOtrosIngresos.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["MONTO_OTROS_INGRESOS"].Value);
                this.txtFuenteOtrosIngresos.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["FUENTES_OTROS_INGRESOS"].Value);
                this.txtTipoVehiculo.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["TIPO_VEHICULO"].Value);
                this.txtPlacaVehiculo.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["Modelo"].Value);
                this.txtModeloVehiculo.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["Placa"].Value);
                this.txtId.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["ID_SOCIO_ECONOMICO"].Value);

            }
        }
    } } 
