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
    public partial class Vacaciones : Form
    {
        public int IdPersona {  get; set; }
        public Vacaciones()
        {
            InitializeComponent();
        }

        private void Vacaciones_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            this.dtgHistorialVacaciones.DataSource = nVacaciones.MostrarVacaciones(IdPersona);
        }
    }
}
