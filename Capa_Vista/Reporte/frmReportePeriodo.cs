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
    public partial class frmReportePeriodo : Form
    {
        public int Idpersona {  get; set; }
        public frmReportePeriodo()
        {
            InitializeComponent();
        }

        private void frmReportePeriodo_Load(object sender, EventArgs e)
        {
            try
            {
                this.sp_SeleccionarPeriodosTableAdapter.Fill(this.usuariosDataset.sp_SeleccionarPeriodos, Idpersona);
                this.reportViewer1.RefreshReport();
            } catch (Exception ex) {
                this.reportViewer1.RefreshReport();
            }

            
          
        }
    }
}
