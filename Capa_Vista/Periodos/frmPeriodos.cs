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

namespace Capa_Vista.Vacaciones
{
    public partial class frmPeriodos : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para iniciar el formulario
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }
        public int totalRegistros {  get; set; }
        public frmPeriodos()
        {
            InitializeComponent();

            dtmFechaInicial.Format = DateTimePickerFormat.Custom;
            dtmFechaInicial.CustomFormat = "dd/MM/yyyy";

            dtmFechaFinal.Format = DateTimePickerFormat.Custom;
            dtmFechaFinal.CustomFormat = "dd/MM/yyyy";
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

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
           
        }

        private void Calcularfecha()
        {
            DateTime fechaInicial = dtmFechaInicial.Value;
            DateTime fechaFina = fechaInicial.AddYears(1);
            dtmFechaFinal.Value = fechaFina;
        }

        private void dtmFechaInicial_ValueChanged(object sender, EventArgs e)
        {
           // Calcularfecha();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtmFechaInicial.Value;
            DateTime fechaFin = dtmFechaFinal.Value;
            if (string.IsNullOrEmpty(this.txtPeriodos.Text)


               )
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
            }
            else

            {
                int tomados = 0;
                int restantes = 0;
               
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                
                    rpta = nPeriodos.Insertar(
                    Idpersona,
                    this.txtPeriodos.Text.Trim(),
                    fechaInicio,
                    fechaFin,
                    Convert.ToInt32( txtDiasVacaciones.Text),
                    tomados,
                    restantes ,
                   true
                );

                }
                else if (this.Evento == "Editar")
                {
                    MessageBox.Show("Editado");
               

                }

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk(this.Evento == "Nuevo" ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }


            }
            
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
