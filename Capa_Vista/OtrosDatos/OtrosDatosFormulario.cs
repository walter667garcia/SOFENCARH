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

namespace Capa_Vista.OtrosDatos
{
    public partial class OtrosDatosFormulario : Form
    {  
        //VAriables necesarias para iniciar
        public int Idpersona {  get; set; } 
        public string Evento { get; set; }

        //Variables necesarias para movilizar el formulario 
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public OtrosDatosFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       // Eventos necesarios para moviliar el formulario
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

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechat = this.dtmFechaT.Value;
            DateTime fechaS = this.dtmFechasS.Value;
            if (string.IsNullOrEmpty(this.txtPuesto.Text) ||
             string.IsNullOrEmpty(this.txtPustoConocido.Text) ||
             string.IsNullOrEmpty(this.txtxEncaRelacion.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
            }


            else
            {
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    rpta = nOtrosDatos.Insertar(
                       Idpersona,
                        this.cmbTrabajoEnca.Text.Trim(),
                        fechat,
                        this.txtPuesto.Text.Trim(),
                        this.cmbSolicitudEnca.Text.Trim(),
                        fechaS,
                        this.txtPlaza.Text.Trim(),
                        this.cmbDisponibilidad.Text.Trim(),
                        this.txtFamilliaEnca.Text.Trim(),
                        this.txtFamiliaEncaActual.Text.Trim(),
                        this.txtxEncaRelacion.Text.Trim(),
                        this.txtPustoConocido.Text.Trim(),
                        this.cmbPlazaVacante.Text.Trim()
                    );
                }
                else if (this.Evento == "Editar")
                {
                    rpta = nOtrosDatos.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                        Idpersona,
                        this.cmbTrabajoEnca.Text.Trim(),
                        fechat,
                        this.txtPuesto.Text.Trim(),
                        this.cmbSolicitudEnca.Text.Trim(),
                        fechaS,
                        this.txtPlaza.Text.Trim(),
                        this.cmbDisponibilidad.Text.Trim(),
                        this.txtFamilliaEnca.Text.Trim(),
                        this.txtFamiliaEncaActual.Text.Trim(),
                        this.txtxEncaRelacion.Text.Trim(),
                        this.txtPustoConocido.Text.Trim(),
                        this.cmbPlazaVacante.Text.Trim()
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
            this.cmbTrabajoEnca.Text = string.Empty;
            this.dtmFechaT.Value = DateTime.Today;
            this.txtPuesto.Text = string.Empty;
            this.cmbSolicitudEnca.Text = string.Empty;
            this.dtmFechasS.Value = DateTime.Today;
            this.txtPlaza.Text = string.Empty;
            this.cmbDisponibilidad.Text = string.Empty;
            this.txtFamilliaEnca.Text = string.Empty;
            this.txtFamiliaEncaActual.Text = string.Empty;
            this.txtxEncaRelacion.Text = string.Empty;
            this.cmbPlazaVacante.Text = string.Empty;
            this.txtPustoConocido.Text = string.Empty;

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void CargarDatos(string id, string trabajoEnca, string fechaT, string puesto,
                             string solicitudEnca, string fechaS, string plaza, string disponibilidad,
                             string familiaEnca, string familiaEncaActual, string encaRelacion,
                             string puestoConocido, string plazaVacante)
        {
            this.txtId.Text = id;
            this.cmbTrabajoEnca.Text = trabajoEnca;
            this.dtmFechaT.Text = fechaT;
            this.txtPuesto.Text = puesto;
            this.cmbSolicitudEnca.Text = solicitudEnca;
            this.dtmFechasS.Text = fechaS;
            this.txtPlaza.Text = plaza;
            this.cmbDisponibilidad.Text = disponibilidad;
            this.txtFamilliaEnca.Text = familiaEnca;
            this.txtFamiliaEncaActual.Text = familiaEncaActual;
            this.txtxEncaRelacion.Text = encaRelacion;
            this.txtPustoConocido.Text = puestoConocido;
            this.cmbPlazaVacante.Text = plazaVacante;
        }
    }
}
