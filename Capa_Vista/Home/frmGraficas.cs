using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Home
{
    public partial class frmGraficas : Form
    {
        public frmGraficas()
        {
            InitializeComponent();
        }

        private void frmGraficas_Load(object sender, EventArgs e)
        {

        }
        private void CustomizeMonthCalendar()
        {
            // Cambiar el color de fondo del control MonthCalendar
            calendario.BackColor = Color.LightGray;

            // Cambiar el color de fondo de los días de la semana
            calendario.TitleBackColor = Color.DarkGray;
            calendario.TitleForeColor = Color.White;

            // Cambiar el color de fondo de las fechas seleccionadas
            calendario.BackColor = Color.White;
            calendario.ForeColor = Color.Black;

            // Cambiar el color de fondo del control de días del mes
            calendario.CalendarDimensions = new Size(1, 1); // Mostrar un mes a la vez
            calendario.FirstDayOfWeek = Day.Monday; // Configurar el primer día de la semana
            calendario.MaxSelectionCount = 1; // Permitir seleccionar solo una fecha

           
        }
    }
}
