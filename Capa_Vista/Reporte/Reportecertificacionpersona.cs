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
    public partial class Reportecertificacionpersona : Form
    {
        public int Idpersona { get; set; }
        public Reportecertificacionpersona()
        {
            InitializeComponent();
        }

        private void Reportecertificacionpersona_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_certificacionpersonaTableAdapter.Fill(this.periodoEnca.sp_certificacionpersona, Idpersona);
                this.sp_certificacionperidosTableAdapter.Fill(this.periodoEnca.sp_certificacionperidos, Idpersona);
                
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex) 
            {

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
