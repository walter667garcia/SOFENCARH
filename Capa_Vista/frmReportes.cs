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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
          
            this.sp_ListarHomeUbicacionTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeUbicacion, 1);
            this.sp_listarHomeEducacionTableAdapter.Fill(this.reporteDataSet.sp_listarHomeEducacion, 1);
            this.sp_ListarHomeFamiliaTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeFamilia, 1);
            this.sp_ListarHomeidiomaTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeidioma, 1);
            this.sp_ListarHomeRHSOCIOECONOMICOTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHSOCIOECONOMICO, 1);
            this.sp_ListarHomeRHOTROSDATOSTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHOTROSDATOS, 1);
            this.sp_ListarHomeRHFISICABIOLOGICATableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHFISICABIOLOGICA,1);
            this.sp_ListarHomeReferenciaPersonalTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeReferenciaPersonal,1);
            this.sp_ListarHomeReferenciaLaboralTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeReferenciaLaboral,1);
            this.sp_ListarHomeRHEXPERIENCIALABORALTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHEXPERIENCIALABORAL,1);
            this.sp_ListarHomeRHDATOSADICIONALESTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHDATOSADICIONALES,1);
         
            this.reportViewer1.RefreshReport();
        }
    }
}
