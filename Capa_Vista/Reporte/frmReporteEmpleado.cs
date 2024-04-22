using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteEmpleado : Form
    {
        public int Idpersona {  get; set; }
        public frmReporteEmpleado()
        {
            InitializeComponent();
        }

        private void frmReporteEmpleado_Load(object sender, EventArgs e)
        {



          
        }

        private void pictureBox3_Click(object sender, EventArgs e)

        {
            try {


                this.sp_ListarPersonaReporteTableAdapter.Fill(this.personaDataSet.sp_ListarPersonaReporte, Idpersona);
                this.sp_ListarHomeUbicacionTableAdapter.Fill(this.personaDataSet.sp_ListarHomeUbicacion, Idpersona);
                this.sp_ListarHomeFamiliaTableAdapter.Fill(this.personaDataSet.sp_ListarHomeFamilia, Idpersona);
                this.sp_listarHomeEducacionTableAdapter.Fill(this.personaDataSet.sp_listarHomeEducacion, Idpersona);
                this.sp_ListarHomeidiomaTableAdapter.Fill(this.personaDataSet.sp_ListarHomeidioma, Idpersona);
                this.sp_ListarHomeRHEXPERIENCIALABORALTableAdapter.Fill(this.personaDataSet.sp_ListarHomeRHEXPERIENCIALABORAL, Idpersona);
                this.sp_ListarHomeRHSOCIOECONOMICOTableAdapter.Fill(this.personaDataSet.sp_ListarHomeRHSOCIOECONOMICO, Idpersona);
                this.sp_ListarHomeRHFISICABIOLOGICATableAdapter.Fill(this.personaDataSet.sp_ListarHomeRHFISICABIOLOGICA, Idpersona);
                this.sp_ListarHomeReferenciaLaboralTableAdapter.Fill(this.personaDataSet.sp_ListarHomeReferenciaLaboral, Idpersona);
                this.sp_ListarHomeReferenciaPersonalTableAdapter.Fill(this.personaDataSet.sp_ListarHomeReferenciaPersonal, Idpersona);
                this.sp_ListarHomeRHOTROSDATOSTableAdapter.Fill(this.personaDataSet.sp_ListarHomeRHOTROSDATOS, Idpersona);
                this.sp_ListarHomeRHDATOSADICIONALESTableAdapter.Fill(this.personaDataSet.sp_ListarHomeRHDATOSADICIONALES, Idpersona);

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
            
            

         
        }
    }
}
