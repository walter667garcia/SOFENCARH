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
    public partial class periodosenca : Form
    {
        public periodosenca()
        {
            InitializeComponent();
        }

        private void frmperiodocoordinacion_Load(object sender, EventArgs e)
        {
            

            try
            {

                // TODO: This line of code loads data into the 'periodoEnca.sp_PeriodoTotalEnca' table. You can move, or remove it, as needed.
                this.sp_PeriodoTotalEncaTableAdapter.Fill(this.periodoEnca.sp_PeriodoTotalEnca);
                this.reportViewer1.RefreshReport();

            }// TODO: This line of code loads data into the 'periodoEnca.sp_PeriodoTotalEnca' table. You can move, or remove it, as needed.
            catch {

                this.reportViewer1.RefreshReport();

            }

        }
    }
}
