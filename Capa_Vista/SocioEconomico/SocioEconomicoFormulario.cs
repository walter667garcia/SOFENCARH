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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatos(string agrupacion, string vivienda, string vehiculo,
                         string detalleAgrupacion, string pagoVivienda, string flagDeuda,
                         string dependencias, string detalleDependencias, string montoDeuda,
                         string motivoDeuda, string flagOtrosIngresos, string montoOtrosIngresos,
                         string fuenteOtrosIngresos, string tipoVehiculo, string placaVehiculo,
                         string modeloVehiculo, string id)
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
