using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Reporte
{
    public partial class Reportepersonacoordinacion : Form
    {
        public int Idpersona {  get; set; }
        public Reportepersonacoordinacion()
        {
            InitializeComponent();
        }

        private void Reportepersonacoordinacion_Load(object sender, EventArgs e)
        {

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'periodoEnca.sp_PeriodoTotalPersona' table. You can move, or remove it, as needed.
                this.sp_PeriodoTotalCoordinacionTableAdapter.Fill(this.periodoEnca.sp_PeriodoTotalCoordinacion, Idpersona);
               

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();

            }
        }
    }
}
