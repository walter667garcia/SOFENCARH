using Capa_Negocio;
using Capa_Vista.Vacaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmSolicitudVacaciones : Form
    {
       public int IdPeriodo {  get; set; } //ID_PERIODO
       public int IdPersona {  get; set; }
        public string Evento {  get; set; }
        public int diasTomados { get; set; }
        public int Acumulados { get; set; }
        public frmSolicitudVacaciones()
        {
            InitializeComponent();
        }

        private void frmSolicitudVacaciones_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatos( int dias,string Evento,string empleado, string dpi,string periodo ,string diasDisponibles)
        {
            if (Evento == "Completo")
            {

                txtEmpleado.Text = empleado;
                txtDPI.Text = dpi;
                txtPeriodo.Text = periodo;
                txtDiasDisponibles.Text = diasDisponibles.ToString();
                lbAcomulados.Text = Acumulados.ToString();
            }
            else if(Evento == "Incompleto")
            {
                txtEmpleado.Text = empleado;
                txtDPI.Text = dpi;
                txtPeriodo.Text = periodo;

                // Calcular cuántos días proporcionalmente te corresponderían
                double proporcion = (double)dias / 365;
                int diasVacaciones = (int)Math.Round(23 * proporcion);
                int sub = (diasVacaciones - diasTomados);
                txtDiasDisponibles.Text = sub.ToString();
                lbAcomulados.Text = Acumulados.ToString();
            }
        }

        private void Calcular()
        {
            // Obtener las fechas seleccionadas de los DateTimePicker
            DateTime fechaInicio = dtmfechaInicio.Value;
            DateTime fechaFin = dtmfechaFinal.Value;

            // Calcular la diferencia en días entre las fechas
            TimeSpan diferencia = fechaFin - fechaInicio;
            int diasDiferencia = (int)diferencia.TotalDays;

            // Obtener el número de días festivos desde el TextBox txtDiasDisponibles
            int diasFestivos;
            if (!int.TryParse(txtDiasFestivos.Text, out diasFestivos))
            {
                MessageBox.Show("El valor de días festivos no es válido.");
                return; // Salir del método si no se puede obtener un número válido
            }

            // Obtener el número de días disponibles desde el TextBox txtDiasDisponibles
            int diasDisponibles;
            if (!int.TryParse(txtDiasDisponibles.Text, out diasDisponibles))
            {
                MessageBox.Show("El valor de días disponibles no es válido.");
                return; // Salir del método si no se puede obtener un número válido
            }

            // Restar los días festivos de la diferencia total de días
            int resumen = diasDiferencia - diasFestivos;
            txtTotal.Text = resumen.ToString();

            // Restar los días disponibles del resumen
            int restantes =  diasDisponibles - resumen;

            // Mostrar los días restantes en el TextBox txtRestantes
            txtRestantes.Text = restantes.ToString();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtmfechaInicio.Value;
            DateTime fechaFin = dtmfechaFinal.Value;

            if (string.IsNullOrEmpty(this.txtDiasFestivos.Text) || string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");

            }
            else
            {
                
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    int disponibles, total;
                    total = Convert.ToInt32(this.txtTotal.Text);
                    disponibles = Convert.ToInt32(this.txtDiasDisponibles.Text);
                    if (total <= disponibles)
                    {
                        rpta = nVacaciones.InsertarVacaciones(
                        IdPersona,
                        IdPeriodo,
                        fechaInicio,
                        fechaFin,
                        Convert.ToInt32(this.txtDiasFestivos.Text),
                        Convert.ToInt32(this.txtTotal.Text),
                        this.txtDescripcion.Text
                       );
                    }
                    else
                    {
                        MessageBox.Show("No puedes tomas mas dias de los disponibles en este periodo");
                    }
                   
                }
                else if (this.Evento == "Editar")
                {
                  
                }
                if (rpta.Equals("OK"))
                {
                    int subtotal = (diasTomados + Convert.ToInt32(txtTotal.Text));
                    string rptaP = ""; 
                    this.MensajeOk(this.Evento == "Nuevo" ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    rptaP = nVacaciones.DescontarPeriodo(
                        IdPeriodo,
                        Convert.ToInt32(txtRestantes.Text),
                        subtotal,
                        Convert.ToInt32(txtRestantes.Text)

                        );

                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }
            }
        }
    }
}
