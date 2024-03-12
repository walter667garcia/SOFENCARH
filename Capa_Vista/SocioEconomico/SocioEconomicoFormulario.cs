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

namespace Capa_Vista.SocioEconomico
{
    public partial class SocioEconomicoFormulario : Form
    {
        //Varibles necesarias para el movimiento del formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias pra iniciar
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }

        public SocioEconomicoFormulario()
        {
            InitializeComponent();
            LlenarComboBoxes();
        }
        private void SocioEconomicoFormulario_Load(object sender, EventArgs e)
        {
           
        }

        //Funcion para listar informacion necesaria para insertar registros
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

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

        private void txtDependencias_TextChanged(object sender, EventArgs e)
        {

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
            this.cmbAgrupacion.SelectedIndex = -1;
            this.txtDetalleAgrupacion.Text = string.Empty;
            this.txtDependencias.Text = string.Empty;
            this.txtDetalleDependencias.Text = string.Empty;
            this.cmbVivienda.SelectedIndex = -1;
            this.txtPagoVivienda.Text = string.Empty;
            this.cmbFlagDeuda.Text = string.Empty;
            this.txtMontoDeuda.Text = string.Empty;
            this.txtMotivoDeuda.Text = string.Empty;
            this.cmbFlagOtrosIngresos.SelectedIndex = -1;
            this.txtMontoOtrosIngresos.Text = string.Empty;
            this.txtFuenteOtrosIngresos.Text = string.Empty;
            this.cmbVehiculo.SelectedIndex = -1;
            this.txtTipoVehiculo.Text = string.Empty;
            this.txtPlacaVehiculo.Text = string.Empty;
            this.txtModeloVehiculo.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtDependencias.Text) || string.IsNullOrEmpty(this.txtModeloVehiculo.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");

            }
            else
            {
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    rpta = nSocioEconomico.Insertar(
                       Idpersona,
                        Convert.ToInt32(this.cmbAgrupacion.SelectedValue),
                        this.txtDetalleAgrupacion.Text.Trim(),
                        this.txtDependencias.Text.Trim(),
                        this.txtDetalleDependencias.Text.Trim(),
                        Convert.ToInt32(this.cmbVivienda.SelectedValue),
                        this.txtPagoVivienda.Text.Trim(),
                        this.cmbFlagDeuda.Text.Trim(),
                        this.txtMontoDeuda.Text.Trim(),
                        this.txtMotivoDeuda.Text.Trim(),
                        this.cmbFlagOtrosIngresos.Text.Trim(),
                        this.txtMontoOtrosIngresos.Text.Trim(),
                        this.txtFuenteOtrosIngresos.Text.Trim(),
                        Convert.ToInt32(this.cmbVehiculo.SelectedValue),
                        this.txtTipoVehiculo.Text.Trim(),
                        this.txtPlacaVehiculo.Text.Trim(),
                        this.txtModeloVehiculo.Text.Trim()
                        );
                }
                else if (this.Evento == "Editar")
                {
                    rpta = nSocioEconomico.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                      Idpersona,
                        Convert.ToInt32(this.cmbAgrupacion.SelectedValue),
                        this.txtDetalleAgrupacion.Text.Trim(),
                        this.txtDependencias.Text.Trim(),
                        this.txtDetalleDependencias.Text.Trim(),
                        Convert.ToInt32(this.cmbVivienda.SelectedValue),
                        this.txtPagoVivienda.Text.Trim(),
                        this.cmbFlagDeuda.Text.Trim(),
                        this.txtMontoDeuda.Text.Trim(),
                        this.txtMotivoDeuda.Text.Trim(),
                        this.cmbFlagOtrosIngresos.Text.Trim(),
                        this.txtMontoOtrosIngresos.Text.Trim(),
                        this.txtFuenteOtrosIngresos.Text.Trim(),
                        Convert.ToInt32(this.cmbVehiculo.SelectedValue),
                        this.txtTipoVehiculo.Text.Trim(),
                        this.txtPlacaVehiculo.Text.Trim(),
                        this.txtModeloVehiculo.Text.Trim()
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

        public void CargarDatos(string id,string agrupacion, string vivienda, string vehiculo,
                         string detalleAgrupacion, string pagoVivienda, string flagDeuda,
                         string dependencias, string detalleDependencias, string montoDeuda,
                         string motivoDeuda, string flagOtrosIngresos, string montoOtrosIngresos,
                         string fuenteOtrosIngresos, string tipoVehiculo, string placaVehiculo,
                         string modeloVehiculo)
        {
            int idAgrupacion = cmbAgrupacion.FindStringExact(agrupacion);
            cmbAgrupacion.SelectedIndex = idAgrupacion;

            int idVivienda = cmbVivienda.FindStringExact(vivienda);
            cmbVivienda.SelectedIndex = idVivienda;

            int idVehiculo = cmbVehiculo.FindStringExact(vehiculo);
            cmbVehiculo.SelectedIndex = idVehiculo;

            this.txtDetalleAgrupacion.Text = detalleAgrupacion;
            this.txtDependencias.Text = dependencias;
            this.txtDetalleDependencias.Text = detalleDependencias;
            this.txtPagoVivienda.Text = pagoVivienda;
            this.cmbFlagDeuda.Text = flagDeuda;
            this.txtMontoDeuda.Text = montoDeuda;
            this.txtMotivoDeuda.Text = motivoDeuda;
            this.cmbFlagOtrosIngresos.Text = flagOtrosIngresos;
            this.txtMontoOtrosIngresos.Text = montoOtrosIngresos;
            this.txtFuenteOtrosIngresos.Text = fuenteOtrosIngresos;
            this.txtTipoVehiculo.Text = tipoVehiculo;
            this.txtPlacaVehiculo.Text = placaVehiculo;
            this.txtModeloVehiculo.Text = modeloVehiculo;
            this.txtId.Text = id;
        }

    }
}
