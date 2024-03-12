using Capa_Negocio;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Localizacion
{
    public partial class UbicacionFormulario : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para editar un registro
        public int Idpersona { get; set; }
        public string Evento { get; set; }
        public UbicacionFormulario()
        {
            InitializeComponent();
            LlenarComboBoxes();
        }
        private void UbicacionFormulario_Load(object sender, EventArgs e)
        {
           
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


        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();
            cmbLocalizacion.DataSource = dataSet.Tables["TyLocalizacion"];
            cmbLocalizacion.DisplayMember = "Descripcion";
            cmbLocalizacion.ValueMember = "IdLOcalizacion";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            this.cmbLocalizacion.SelectedIndex = -1;
            this.txtLocalizacion.Text = string.Empty;
        }
        private void LimpiarCampos()
        {
            this.cmbLocalizacion.SelectedIndex = -1;
            this.txtLocalizacion.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtLocalizacion.Text) )
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
              
            }
            else
            {
                string rpta = "";
            if (this.Evento == "Nuevo")
            {
                rpta = nLocalizacion.InsertarLocalizacion(
                     Idpersona,
                     Convert.ToInt32(cmbLocalizacion.SelectedValue),
                    this.txtLocalizacion.Text.Trim()
                     
             );

             
            }
            else if (this.Evento == "Editar")
            {
              rpta= nLocalizacion.ActualizarLocalizacion(
                      Convert.ToInt32(txtID.Text),
                      Idpersona,
                      Convert.ToInt32(cmbLocalizacion.SelectedValue),
                      txtLocalizacion.Text.Trim()

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

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void CargarDatos(string id, string descripcion, string localizacion )
        {
            txtID.Text = id;
            int idLocalizacion = cmbLocalizacion.FindStringExact(descripcion);
            cmbLocalizacion.SelectedIndex = idLocalizacion;
            txtLocalizacion.Text = localizacion;
           
        }
    }
}
