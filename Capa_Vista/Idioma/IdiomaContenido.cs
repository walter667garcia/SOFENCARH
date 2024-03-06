using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista
{
    public partial class IdiomaContenido : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para el funcionamiento
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }
        public IdiomaContenido()
        {
            InitializeComponent();
            llenarDatos();
           
        }
        private void IdiomaContenido_Load(object sender, EventArgs e)
        {
            LlenarComboBoxes();
        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            // Asignar los datos a los ComboBox específicos
            cmbIdioma.DataSource = dataSet.Tables["TYIDIOMA"];
            cmbIdioma.DisplayMember = "IDIOMA";
            cmbIdioma.ValueMember = "IDIDIOMA";
        }


        //Eventos necesarios para movilizar el formulario
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        private void llenarDatos()
        {



            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            // Asignar los datos a los ComboBox específicos
            cmbIdioma.DataSource = dataSet.Tables["TYIDIOMA"];
            cmbIdioma.DisplayMember = "IDIOMA";
            cmbIdioma.ValueMember = "IDIDIOMA";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tkbConversacion_ValueChanged(object sender, EventArgs e)
        {
            int value = tkbConversacion.Value;
            lbConversacion.Text = $"{value}%";
        }

        private void tkbEscritura_ValueChanged(object sender, EventArgs e)
        {
            int value = tkbEscritura.Value;
            lbEscritura.Text = $"{value}%";
        }

        private void tkbLectura_ValueChanged(object sender, EventArgs e)
        {
            int value = tkbLectura.Value;
            lbLectura.Text = $"{value}%";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void CargarIdioma(string Idioma, string Id, string Conversacion, string Escritura, string Lectura, string Documento)
        {
            int idIdioma = cmbIdioma.FindStringExact(Idioma);
            cmbIdioma.SelectedIndex = idIdioma;

            this.txtId.Text = Id;

            // Convertir las cadenas a valores numéricos antes de asignarlos a los controles de TrackBar
            int valorConversacion = int.Parse(Conversacion);
            int valorEscritura = int.Parse(Escritura);
            int valorLectura = int.Parse(Lectura);

            this.tkbConversacion.Value = valorConversacion;
            this.tkbEscritura.Value = valorEscritura;
            this.tkbLectura.Value = valorLectura;

            this.txtDocumento.Text = Documento;
        }
    }
}
