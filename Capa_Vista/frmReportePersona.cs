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
    public partial class frmReportePersona : Form
    {
        public int Idpersona {  get; set; }
        public string Persona {  get; set; }
        public frmReportePersona()
        {
            InitializeComponent();
        }

        private void frmReportePersona_Load(object sender, EventArgs e)
        {
            this.sp_ListarPersonaReporteTableAdapter.Fill(this.reporteDataSet.sp_ListarPersonaReporte, Idpersona);
            this.sp_listarHomeEducacionTableAdapter.Fill(this.reporteDataSet.sp_listarHomeEducacion, Idpersona);
            this.reportViewer1.RefreshReport();
        }
    }
}
