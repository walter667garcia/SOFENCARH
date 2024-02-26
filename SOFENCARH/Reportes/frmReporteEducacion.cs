using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFENCARH
{
    public partial class frmReporteEducacion : Form
    {
        private int idEducacion {  get; set; }
        private int idPersona = 4053;

        public frmReporteEducacion()
        {
            InitializeComponent();
        }

        private void frmReporteEducacion_Load(object sender, EventArgs e)
        {

            this.sp_listarHomeEducacionTableAdapter.Fill(this.dsPrincipal.sp_listarHomeEducacion, idPersona);

            this.reportViewer1.RefreshReport();
        }
    }
}
