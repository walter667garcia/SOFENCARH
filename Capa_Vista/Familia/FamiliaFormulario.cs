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
        }

        private void FamiliaFormulario_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void CargarTFamilia(string Familia, string f_nacimiento, string Id, string Nombre,
                            string Ocupacion, string Telefono, string Lug_TRabajo,
                            string Dir_Trabajo, string Tel_TRabajo)
        {
            int idfamilia = cmbTFamilia.FindStringExact(Familia);
            cmbTFamilia.SelectedIndex = idfamilia;

            dtmFecha.Text = f_nacimiento;

            this.txtId.Text = Id;
            this.txtNombre.Text = Nombre;
            this.txtOcupacion.Text = Ocupacion;
            this.txtTelefono.Text = Telefono;
            this.txtLTrabajo.Text = Lug_TRabajo;
            this.txtDTrabajo.Text = Dir_Trabajo;
            this.txtTelTrabajo.Text = Tel_TRabajo;
        }
    }
}
