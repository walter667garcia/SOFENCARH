using Capa_Negocio;
using Capa_Vista.Educacion;
using Capa_Vista.Reportes;
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
                if (this.dtgActas.Columns.Count > 0)
                {
                    this.dtgActas.Columns[0].Visible = false;
                    this.dtgActas.Columns[1].Visible = false;
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
            this.dtgActas.DataSource = nActas.MostrarActas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dtgActas.DataSource = nActas.Buscar(this.txtBuscar.Text);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.txtBuscar.Text = "";
            Mostrar();
        }

        private void dtgFamilia_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgActas.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgActas.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgActas.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Editar").Name = "Editar" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                    menu.Items.Add("Reporte").Name = "Reporte" + posicion;
                }
                menu.Show(dtgActas, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick1);
            }
        }
        private static frmReporteActas actas = null;
        private static ActasFormulario formulario = null;

        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            int Idpersona = Convert.ToInt32(this.dtgActas.CurrentRow.Cells["IdPersona"].Value);
            string id = e.ClickedItem.Name.ToString();

            try
            {
                if (id.Contains("Editar"))
                {
                    if (actas == null || actas.IsDisposed)
                    {
                        id = id.Replace("Editar", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        string Id = this.dtgActas.CurrentRow.Cells["ID_ACTA"].Value.ToString();
                      string fecha =  this.dtgActas.CurrentRow.Cells["FECHA_INGRESO"].Value.ToString();
                        string puestoFuncional = this.dtgActas.CurrentRow.Cells["PUESTO_FUNCIONAL"].Value.ToString();
                      string coordinacion=  this.dtgActas.CurrentRow.Cells["COORDINACION"].Value.ToString();
                      string puestoNominal=  this.dtgActas.CurrentRow.Cells["PUESTO_NOMINAL"].Value.ToString();
                       string renglon = this.dtgActas.CurrentRow.Cells["ABREVIATURA"].Value.ToString();
                       string unidad = this.dtgActas.CurrentRow.Cells["UNIDAD_SECCION"].Value.ToString();
                       string salrio= this.dtgActas.CurrentRow.Cells["SALARIO_BASE"].Value.ToString();
                       string descripcion= this.dtgActas.CurrentRow.Cells["DESCRIPCION"].Value.ToString();

                        formulario = new ActasFormulario();
                        formulario.FormClosed += (s, args) => { formulario = null; };
                        formulario.Idpersona = Idpersona;

                        formulario.CargarDatos(Id, fecha,puestoFuncional, coordinacion,
                            puestoNominal, renglon, unidad, salrio, descripcion
                            );
                        formulario.Evento = "Editar";
                        formulario.ShowDialog();
                    }
                    else
                    {
                        actas.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando un dato. No puede actualizar un registro.");
                    }
                }else
                if (id.Contains("Reporte"))
                {
                    if (actas == null || actas.IsDisposed)
                    {
                        id = id.Replace("Reporte", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        actas = new frmReporteActas();
                        actas.FormClosed += (s, args) => { actas = null; }; // Establece actas a null cuando se cierra el formulario
                       // actas.Idacta = Idpersona;
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
