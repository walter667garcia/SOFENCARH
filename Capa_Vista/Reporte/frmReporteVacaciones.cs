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
    public partial class frmReporteVacaciones : Form
    {
        public int Idpersona {  get; set; }
        public frmReporteVacaciones()
        {
            InitializeComponent();
        }

        private void frmReporteVacaciones_Load(object sender, EventArgs e)
        {
            try {
                this.sp_ListarVacacionesHistorialTableAdapter.Fill(this.dataVacaciones.sp_ListarVacacionesHistorial, Idpersona);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
