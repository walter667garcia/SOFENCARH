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

        }
        public void CargarOtrosDatos(string id, string trabajoEnca, string fechaT, string puesto,
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
