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
    public partial class frmReporteActas : Form
    {
        public int Idacta { get; set; }
        public string Persona { get; set; }
        public frmReporteActas()
        {
            InitializeComponent();
        }


        private void frmReporteActas_Load(object sender, EventArgs e)
        {

            try
            {
                lbPersona.Text = Persona;
                this.sp_ReporteActasTableAdapter.Fill(this.reporteDataSet.sp_ReporteActas, Idacta);
               
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
