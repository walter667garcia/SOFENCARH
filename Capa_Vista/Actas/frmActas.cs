using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Actas
{
    public partial class frmActas : Form
    {
        public frmActas()
        {
            InitializeComponent();
        }

        private void frmActas_Load(object sender, EventArgs e)
        {
            Mostrar();
            Ocultar();
        }

        private void Ocultar()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgFamilia.Columns.Count > 0)
                {
                    this.dtgFamilia.Columns[0].Visible = false;
                    this.dtgFamilia.Columns[1].Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay columnas para ocultar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intentar ocultar columnas: {ex.Message}");
            }
        }
        private void Mostrar()
        {
            this.dtgFamilia.DataSource = nActas.MostrarActas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dtgFamilia.DataSource = nActas.Buscar(this.txtBuscar.Text);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dtgFamilia_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgFamilia.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgFamilia.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgFamilia.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Reporte").Name = "Reporte" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                }
                menu.Show(dtgFamilia, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick1);
            }
        }
        private static frmReporteActas actas = null;

        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            int Idpersona = Convert.ToInt32(this.dtgFamilia.CurrentRow.Cells["ID_ACTA"].Value);
            string Persona = "Ejemplo";
            string id = e.ClickedItem.Name.ToString();

            try
            {
                if (id.Contains("Reporte"))
                {
                    if (actas == null || actas.IsDisposed)
                    {
                        id = id.Replace("Reporte", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        actas = new frmReporteActas();
                        actas.FormClosed += (s, args) => { actas = null; }; // Establece actas a null cuando se cierra el formulario
                        actas.Idacta = Idpersona;
                        actas.Persona = Persona;
                        actas.ShowDialog();
                    }
                    else
                    {
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando un dato. No puede abrir nuevamente el formulario.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }
    }
}
