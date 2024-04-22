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
    public partial class frmReporteProfesion : Form
    {
        public frmReporteProfesion()
        {
            InitializeComponent();
        }

        private void frmReporteProfesion_Load(object sender, EventArgs e)
        {
            try
            {   // TODO: This line of code loads data into the 'usuariosDataset.sp_ListarUsuarios' table. You can move, or remove it, as needed.
                this.sp_ReporteProfesionesTableAdapter.Fill(this.datosNuevos.sp_ReporteProfesiones);


                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }

            // TODO: This line of code loads data into the 'datosNuevos.sp_ReporteProfesiones' table. You can move, or remove it, as needed.
          
        }
    }
}
