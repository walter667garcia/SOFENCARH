using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Capa_Vista
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Mostrar();

            

        }

        private void Mostrar()
        {
            nHome datos = new nHome();
            DataSet dataSet = datos.PersonaInformacion();

            this.dtgHome.DataSource = dataSet.Tables["RHPersona"];

            Imagen();



        }

        private void MosttrarEducacion()
        {
            this.dtgEducacion.DataSource = nHome.BuscarEducacion(this.txtBuscarEducacion.Text);

            
        }

        private void MostrarUbicacion()
        {
            this.dtgUbicacion.DataSource = nHome.BuscarUbicacion(this.txtBuscarUbicacion.Text);
        }

        private void MostrarIdioma()
        {
            this.dtgIdiomas.DataSource = nHome.BuscarIdioma(this.txtBuscarIdiomas.Text);
        }

        private void MostrarFamilia()
        {
            this.dtgFamilia.DataSource = nHome.BuscarFamilia(this.txtBuscarIdiomas.Text);
        }

        private void Imagen()
        {
            DataGridViewImageColumn image = dtgHome.Columns["Foto"] as DataGridViewImageColumn;
            if (image != null )
            {
                image.ImageLayout = DataGridViewImageCellLayout.Zoom;
                image.DefaultCellStyle.NullValue = null;
            }
        }

        private void dtgHome_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          /*  if(e.RowIndex >= 0 && e.RowIndex < dtgHome.RowCount -1)
            {
                using (Pen pen = new Pen(SystemColors.ControlDark, 1))
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    int y = e.CellBounds.Bottom - 1;
                    int x1 = e.CellBounds.Left;
                    int x2 = e.CellBounds.Right;
                   

                   
                    e.Graphics.DrawLine(pen, x1, y, x2, y);
                    e.Handled = true;
                }
               
            }
          */
        }

        private void dtgHome_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgHome.CurrentRow != null)

            {
                byte[] datosBinarios = this.dtgHome.CurrentRow.Cells["Foto"].Value as byte[];

                if (datosBinarios != null && datosBinarios.Length > 0)
                {
                    // Asignar la imagen al PictureBox directamente desde los datos binarios
                    ptFoto.Image = Image.FromStream(new MemoryStream(datosBinarios));
                }
                else
                {
                    MessageBox.Show("Los datos binarios de la imagen son nulos o vacíos.");
                }


                this.lbNombre1.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Nombre1"].Value);
                this.lbNombre2.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Nombre2"].Value);
                this.lbApellido1.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Apellido1"].Value);
                this.lbApellido2.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Apellido2"].Value);
                this.lbFecha.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Fecha_Nacimiento"].Value);
                this.lbEdad.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Edad"].Value);

                this.lbNacionalidad.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Nacionalidad"].Value);
                this.lbDPI.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["DPI"].Value);
                this.lbNit.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Nit"].Value);
                this.lbIggs.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["IGSS"].Value);
                this.lbGenero.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Genero"].Value);

                this.lbEstadoCivil.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Estado_Civil"].Value);
                this.txtBuscarEducacion.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["DPI"].Value);
                this.txtBuscarUbicacion.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["DPI"].Value);
                this.txtBuscarIdiomas.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["DPI"].Value);
                this.txtBuscarFamilia.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["DPI"].Value);
                this.tbHome.SelectedIndex = 1;
            }
        }

        private void txtBuscarEducacion_TextChanged(object sender, EventArgs e)
        {
            MosttrarEducacion();
        }

        private void dtgHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarUbicacion_TextChanged(object sender, EventArgs e)
        {
            MostrarUbicacion();
        }

        private void txtBuscarIdiomas_TextChanged(object sender, EventArgs e)
        {
            MostrarIdioma();
        }

        private void txtBuscarFamilia_TextChanged(object sender, EventArgs e)
        {
            MostrarFamilia();
        }
    }
}
