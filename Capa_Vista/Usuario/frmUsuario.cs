using Capa_Negocio;
using Capa_Vista.Actas;
using Capa_Vista.Contratos;
using Capa_Vista.Familia;
using Capa_Vista.Localizacion;
using Capa_Vista.Reporte;
using Capa_Vista.SocioEconomico;
using ClosedXML.Excel;
using ClosedXML.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Usuario
{
    public partial class frmUsuario : Form
    {  // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static FormularioUsuario instanciaAbierta = null;
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            MostrarEmpleado();
            MostrarActas();
        }
        private void MostrarUsuarios()
        {
            try {
                this.dtgUsuarios.DataSource = nUsuarios.MostrarUsuarios(); 
                 }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }


        }
        private void MostrarEmpleado()
        {
            try
            {
                this.dtgPersona.DataSource = nUsuarios.MostrarPersonaEstado();
                Imagen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }
        }

        private void MostrarActas()
        {
            try
            {
                this.dtgActas.DataSource = nUsuarios.MostrarActasEstado();
                Imagen();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }
        }
        private void Imagen()
        {
            DataGridViewImageColumn image = dtgPersona.Columns["Foto"] as DataGridViewImageColumn;
            if (image != null)
            {
                image.ImageLayout = DataGridViewImageCellLayout.Zoom;
                image.DefaultCellStyle.NullValue = null;
            }
        }

        private void dtgPersona_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgPersona.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgPersona.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgPersona.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Activar").Name = "Activar" + posicion;
                    menu.Items.Add("Desactivar").Name = "Desactivar" + posicion;
                }
                menu.Show(dtgPersona, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick);
            }
        }

        private void menuclick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            try
            {

                if (id.Contains("Activar"))
                {
                    // Confirmar eliminación con un cuadro de diálogo
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas activar este empleado?", "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        id = id.Replace("Activar", "");
                        string rpta = "";
                        int Id = Convert.ToInt32(this.dtgPersona.CurrentRow.Cells["ID"].Value);
                        rpta = nUsuarios.ActualizarEstadoPersona(Id, true);
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Activo el empleado");
                            MostrarEmpleado();
                        }
                        else
                        {
                            this.MensajeError(rpta);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelaste la Activacion");
                    }

                }
                else if (id.Contains("Desactivar"))
                {
                   
                        // Confirmar eliminación con un cuadro de diálogo
                        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas desactivar este empleado?", "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            id = id.Replace("Desactivar", "");
                            string rpta = "";
                            int Id = Convert.ToInt32(this.dtgPersona.CurrentRow.Cells["ID"].Value);
                            rpta = nUsuarios.ActualizarEstadoPersona(Id,false);
                            
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Desactivo el empleado");
                                MostrarEmpleado();
                        }
                            else
                            {
                                this.MensajeError(rpta);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelaste la Desactivacion");
                        }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el realizar los cambios: " + ex.Message);
            }
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgUsuarios.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgUsuarios.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgUsuarios.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Activar").Name = "Activar" + posicion;
                    menu.Items.Add("Desactivar").Name = "Desactivar" + posicion;
                }
                menu.Show(dtgUsuarios, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick1);
            }
        }
        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            try
            {

                if (id.Contains("Activar"))
                {
                    // Confirmar eliminación con un cuadro de diálogo
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas activar este Usuario?", "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        id = id.Replace("Activar", "");
                        string rpta = "";
                        int Id = Convert.ToInt32(this.dtgUsuarios.CurrentRow.Cells["UsuarioID"].Value);
                        rpta = nUsuarios.ActualizarEstadoUsuario(Id, true);
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Activo el Usuario");
                            MostrarUsuarios();
                        }
                        else
                        {
                            this.MensajeError(rpta);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelaste la Activacion");
                    }

                }
                else if (id.Contains("Desactivar"))
                {

                    // Confirmar eliminación con un cuadro de diálogo
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas desactivar este Usuario?", "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        id = id.Replace("Desactivar", "");
                        string rpta = "";
                        int Id = Convert.ToInt32(this.dtgUsuarios.CurrentRow.Cells["UsuarioID"].Value);
                        rpta = nUsuarios.ActualizarEstadoUsuario(Id, false);
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Desactivo el Usuario");
                            MostrarUsuarios();
                        }
                        else
                        {
                            this.MensajeError(rpta);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelaste la Desactivacion");
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el realizar los cambios: " + ex.Message);
            }
        }
        private void pcbNuevo_Click(object sender, EventArgs e)
        {
           
            // Verificar si ya hay una instancia abierta
            if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
            {
                // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                instanciaAbierta = new FormularioUsuario();
                instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                instanciaAbierta.Evento = "Nuevo";
                instanciaAbierta.ShowDialog();
            }
            else
            {
                instanciaAbierta.Activate();
                // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                MessageBox.Show("Actualmente está ingresando un dato. No puede abrir nuevamente el formulario.");
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Text = "";
            MostrarUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dtgUsuarios.DataSource = nUsuarios.BuscarUsuario(txtBuscarUsuario.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dtgPersona.DataSource = nUsuarios.BuscarPersona(txtBuscarPersona.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBuscarPersona.Text = "";
            MostrarEmpleado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgUsuarios);
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

        private void button5_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgPersona);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmReporteUsuarios reporteUsuarios = new frmReporteUsuarios();
            reporteUsuarios.ShowDialog();
        }

        private void dtgActas_MouseClick(object sender, MouseEventArgs e)
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

                    menu.Items.Add("Entrega de Puesto").Name = "Entrega de Puesto" + posicion;
                    menu.Items.Add("Resolucion").Name = "Resolucion" + posicion;
                }
                menu.Show(dtgActas, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(actasmenu);
            }
        }
        private static frmResolucionBajas resolucion = null;
        private static frmEntregaPuesto entregaPuesto = null;
        private void actasmenu(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            try
            {
                string puestoFuncional = this.dtgActas.CurrentRow.Cells["Puesto_Nominal"].Value.ToString();
                string puestoNominal = this.dtgActas.CurrentRow.Cells["Puesto_Funcional"].Value.ToString();
                string nombre = this.dtgActas.CurrentRow.Cells["Empleado"].Value.ToString();
                string DPI = this.dtgActas.CurrentRow.Cells["DPI"].Value.ToString();
                string profesion = this.dtgActas.CurrentRow.Cells["PROFESION_OFICIO"].Value.ToString();

                if (id.Contains("Entrega de Puesto"))
                {

                   
                  
                    if (entregaPuesto == null || entregaPuesto.IsDisposed)
                    {
                        id = id.Replace("Entrega de Puesto", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        entregaPuesto = new frmEntregaPuesto();
                        entregaPuesto.FormClosed += (s, args) => { entregaPuesto = null; };
                        entregaPuesto.CargarDatos(DPI, puestoFuncional, puestoNominal,profesion,nombre);
                        entregaPuesto.ShowDialog();
                    }
                    else
                    {
                        entregaPuesto.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente tiene en proceso una Entrega de Puesto.");
                    }
                }
                else if (id.Contains("Resolucion"))
                {
                       if (resolucion == null || resolucion.IsDisposed)
                    {
                        id = id.Replace("Resolucion", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        resolucion = new frmResolucionBajas();
                        resolucion.FormClosed += (s, args) => { resolucion = null; };
                        resolucion.CargarDatos(puestoFuncional, puestoNominal, nombre,DPI);
                        resolucion.ShowDialog();
                    }
                    else
                    {
                        resolucion.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente tiene en ejecucion una Resolucion.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir el formulario: " + ex.Message);
            }
        }
    }
}
