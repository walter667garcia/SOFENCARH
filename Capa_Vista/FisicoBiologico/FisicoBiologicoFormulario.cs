using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.FisicoBiologico
{
    public partial class FisicoBiologicoFormulario : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para iniciar
        public int Idpersona {  get; set; }
        public string Evento { get; set; }
        public FisicoBiologicoFormulario()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void CargarDatos(string enfermedad, string diabetes, string accidente,
                       string operacion, string alergias, string tratamiento,
                       string especifique, string lentes, string auditivo,
                       string discapacidad, string drogas, string alcohol,
                       string fuma, string peso, string estatura, string sangre,
                       string pasatiempos, string deportes, string id)
        {
            this.cmbEmfermedad.Text = enfermedad;
            this.cmbDiabetes.Text = diabetes;
            this.txtAccidente.Text = accidente;
            this.txtOperacion.Text = operacion;
            this.txtAlergias.Text = alergias;
            this.cmbtratamiento.Text = tratamiento;
            this.txtEspecifique.Text = especifique;
            this.cmblentes.Text = lentes;
            this.cmbauditivo.Text = auditivo;
            this.txtDiscapacidad.Text = discapacidad;
            this.cmbdrogas.Text = drogas;
            this.cmbalcohol.Text = alcohol;
            this.cmbfuma.Text = fuma;
            this.txtPeso.Text = peso;
            this.txtEstatura.Text = estatura;
            this.cmbsangre.Text = sangre;
            this.txtPasatienpo.Text = pasatiempos;
            this.txtDeporte.Text = deportes;
            this.txtId.Text = id;
        }
    }
}
