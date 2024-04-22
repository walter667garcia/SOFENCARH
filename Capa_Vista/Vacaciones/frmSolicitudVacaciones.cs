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

            dtmfechaInicio.Format = DateTimePickerFormat.Custom;
            dtmfechaInicio.CustomFormat = "dd/MM/yyyy";

            dtmfechaFinal.Format = DateTimePickerFormat.Custom;
            dtmfechaFinal.CustomFormat = "dd/MM/yyyy";

            
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

        private void calculo()
        {
            int diasFestivos = Convert.ToInt32(txtDiasFestivos.Text);



            // Obtener las fechas seleccionadas de los DateTimePicker
            DateTime fechaInicio = mtCalendario.SelectionStart; //dtmfechaInicio.Value;
            DateTime fechaFin = mtCalendario.SelectionEnd;// dtmfechaFinal.Value;

   
           

            // Calcular la diferencia en días entre las fechas
            TimeSpan diferencia = fechaFin - fechaInicio;
            int diasDiferencia = (int)diferencia.TotalDays;

            // Contadores para los días sábados y domingos
            int sabados = 0;
            int domingos = 0;

            // Iterar sobre cada día dentro del rango
            for (DateTime fecha = fechaInicio; fecha <= fechaFin; fecha = fecha.AddDays(1))
            {
                // Verificar si el día actual es sábado o domingo
                if (fecha.DayOfWeek == DayOfWeek.Saturday)
                {
                    sabados++;
                }
                else if (fecha.DayOfWeek == DayOfWeek.Sunday)
                {
                    domingos++;
                }
            }

            int subtotal =( sabados + domingos + diasFestivos);

            if (diasDiferencia > subtotal && diasDiferencia !=0){
                int suma = (diasDiferencia - subtotal);
                int diasDisponibles = Convert.ToInt32(txtDiasDisponibles.Text);
                if (diasDisponibles >= suma && diasDisponibles != 0)
                {
                    int restantes = (diasDisponibles - suma);

                    //Dias tomados
                    this.txtTotal.Text = suma.ToString();
                    //Dias restantes
                    this.txtRestantes.Text = restantes.ToString();
                    
                   
                }
                else
                {
                    MessageBox.Show("No puedes asignar mas dias de vacaciones de los que tienes disponibles en este periodo");
                }

            }
            else
            {
                MessageBox.Show("Los dias de de descanso + los dias feriados sobrepasan la fechas estimadas");
            }

           

          
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            if (this.txtDiasFestivos.Text !="" )
            {
                calculo();
            }
            else
            {
                MessageBox.Show("Necesita ingresar todos los campos");
            }
           
           
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

            if (string.IsNullOrEmpty(this.txtDiasFestivos.Text) ||
                 string.IsNullOrEmpty(this.txtDescripcion.Text)||
                string.IsNullOrEmpty(this.dtmfechaInicio.Text) ||
                string.IsNullOrEmpty(this.dtmfechaFinal.Text) 
                 )
            {
                MensajeError("Falta ingresar algunos datos Remarcados");

            }
            else
            {
                
                string rpta = "";
                if (this.Evento == "Nuevo")
                { bool estado = true;
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
                        this.txtDescripcion.Text,
                        estado
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiasFestivos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
