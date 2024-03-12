﻿using System;
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
    public partial class frmReportePersona : Form
    {
        public int IdPersonaReporte { get; set; }
        public string PersonaReporte { get; set; }
        public frmReportePersona()
        {
            InitializeComponent();
        }

        private void frmReportePersona_Load(object sender, EventArgs e)
        {


           
        }
        private void Mostar()
        {

            try
            {
                lbPersona.Text = PersonaReporte;
                this.sp_ListarHomeUbicacionTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeUbicacion, IdPersonaReporte);
                this.sp_listarHomeEducacionTableAdapter.Fill(this.reporteDataSet.sp_listarHomeEducacion, IdPersonaReporte);
                this.sp_ListarHomeFamiliaTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeFamilia, IdPersonaReporte);
                this.sp_ListarHomeidiomaTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeidioma, IdPersonaReporte);
                this.sp_ListarHomeRHSOCIOECONOMICOTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHSOCIOECONOMICO, IdPersonaReporte);
                this.sp_ListarHomeRHOTROSDATOSTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHOTROSDATOS, IdPersonaReporte);
                this.sp_ListarHomeRHFISICABIOLOGICATableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHFISICABIOLOGICA, IdPersonaReporte);
                this.sp_ListarHomeReferenciaPersonalTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeReferenciaPersonal, IdPersonaReporte);
                this.sp_ListarHomeReferenciaLaboralTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeReferenciaLaboral, IdPersonaReporte);
                this.sp_ListarHomeRHEXPERIENCIALABORALTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHEXPERIENCIALABORAL, IdPersonaReporte);
                this.sp_ListarHomeRHDATOSADICIONALESTableAdapter.Fill(this.reporteDataSet.sp_ListarHomeRHDATOSADICIONALES, IdPersonaReporte);
                this.sp_ListarPersonaReporteTableAdapter.Fill(this.reporteDataSet.sp_ListarPersonaReporte, IdPersonaReporte);

                this.VistaReportePersona.RefreshReport();
            }
            catch (Exception ex)
            {
                this.VistaReportePersona.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostar();

        }
    }
}