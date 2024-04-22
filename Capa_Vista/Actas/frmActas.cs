using Capa_Negocio;
using Capa_Vista.Educacion;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            try
            {
                this.dtgActas.DataSource = nActas.MostrarActas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }
           
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
      /*  private static frmReporteActas actas = null;*/
        private static ActasFormulario formulario = null;
        private static frmTomaPosesion actas = null;
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            int Idpersona = Convert.ToInt32(this.dtgActas.CurrentRow.Cells["IdPersona"].Value);
            string id = e.ClickedItem.Name.ToString();

            try
            {
                if (id.Contains("Editar"))
                {
                    if (formulario == null || formulario.IsDisposed)
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
                        formulario.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando un dato. No puede actualizar un registro.");
                    }
                }else if (id.Contains("Eliminar"))
                {
                    id = id.Replace("Eliminar", "");
                    string rpta = "";
                 
                    int Id = Convert.ToInt32(this.dtgActas.CurrentRow.Cells["ID_ACTA"].Value);
                    rpta = nUsuarios.DesactivarActa(Id);
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Elimino el Acta");
                        Mostrar();
                    }
                    else
                    {
                        this.MensajeError(rpta);

                    }
                }

                else
                if (id.Contains("Reporte"))
                 

                {
                    string puestoFuncional = this.dtgActas.CurrentRow.Cells["Puesto_Nominal"].Value.ToString();
                    string puestoNominal = this.dtgActas.CurrentRow.Cells["Puesto_Funcional"].Value.ToString();
                    string nombre = this.dtgActas.CurrentRow.Cells["Empleado"].Value.ToString();
                    string DPI = this.dtgActas.CurrentRow.Cells["DPI"].Value.ToString();
                    string profesion = this.dtgActas.CurrentRow.Cells["PROFESION_OFICIO"].Value.ToString();
                    string salario = this.dtgActas.CurrentRow.Cells["Salario_Base"].Value.ToString();
                    string abrebiatura = this.dtgActas.CurrentRow.Cells["Abreviatura"].Value.ToString();

                    if (actas == null || actas.IsDisposed)
                    {
                        id = id.Replace("Reporte", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        actas = new frmTomaPosesion();
                        actas.FormClosed += (s, args) => { actas = null; }; // Establece actas a null cuando se cierra el formulario
                      actas.CargarDatos(DPI, puestoFuncional,puestoNominal,profesion,nombre,salario,abrebiatura);
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

        private void ExportarDataGridViewAExcel(DataGridView dataGridView)
        {
            // Verificar si hay datos en el DataGridView
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo libro de Excel
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Hoja1");

            // Agregar los encabezados de columnas
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cell(1, i).Value = dataGridView.Columns[i - 1].HeaderText;
            }

            // Agregar los datos de las filas
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Guardar el archivo de Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "ArchivoExcel.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("El archivo Excel se ha exportado correctamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Abrir el archivo de Excel después de guardarlo
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgActas);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
