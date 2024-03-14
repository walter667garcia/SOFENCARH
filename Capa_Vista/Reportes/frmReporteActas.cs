using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Reportes
{
    public partial class frmReporteActas : Form
    {
        public frmReporteActas()
        {
            InitializeComponent();
        }

        private void frmReporteActas_Load(object sender, EventArgs e)
        {
            this.sp_ReporteActasTableAdapter.Fill(this.reporteDataSet.sp_ReporteActas, 1);
            this.reportViewer1.RefreshReport();
        }
    }
}
