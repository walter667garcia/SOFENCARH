using Capa_Negocio;
using Capa_Vista.Familia;
using Capa_Vista.ReferenciaLaboral;
using Capa_Vista.Reporte;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Vacaciones
{
    public partial class frmAsignarPeriodos : Form
    {  //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static frmPeriodos instanciaAbierta = null;

        public int idPersona { get; set; }
        public frmAsignarPeriodos()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            try
            {
                Periodos();
                Vacaciones();
                this.dtgVacacionesCanceladas.DataSource = nVacaciones.MostrarVacacionesCanceladas(idPersona);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }


        }


        private void Periodos()
        {
            this.dtgAsignarPeriodos.DataSource = nPeriodos.MostrarPeriodos(idPersona);

            int suma = 0;
            foreach (DataGridViewRow Periodos in dtgAsignarPeriodos.Rows)
            {
                // Obtener el valor de la celda como una cadena de texto
                string dias = Periodos.Cells["DIAS_DISPONIBLES"].Value.ToString();

                // Intentar convertir la cadena a un entero antes de sumarlo
                int diasDisponibles;
                if (int.TryParse(dias, out diasDisponibles))
                {
                    // Sumar el valor convertido a la suma total
                    suma += diasDisponibles;
                    lbTotalAcumulados.Text = suma.ToString();
                }

            }
            
        }

        private void Vacaciones()
        {
            this.dtgHistorialVacaciones.DataSource = nVacaciones.MostrarVacaciones(idPersona);

            int suma = 0;
            foreach (DataGridViewRow Vacaciones in dtgHistorialVacaciones.Rows)
            {

                // Obtener el valor de la celda como una cadena de texto
                string dias = Vacaciones.Cells["Dias_Tomados"].Value.ToString();

                // Intentar convertir la cadena a un entero antes de sumarlo
                int diastomados;
                if (int.TryParse(dias, out diastomados))
                {
                    // Sumar el valor convertido a la suma total
                    suma += diastomados;
                    lbTotalDiasTomados.Text = suma.ToString();
                }
            }
        }


        private void pcbNuevo_Click(object sender, EventArgs e)
        {
            int totalRegistros = dtgAsignarPeriodos.RowCount;
            // Verificar si ya hay una instancia abierta
            if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
            {
                // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                instanciaAbierta = new frmPeriodos();
                instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                instanciaAbierta.Idpersona = idPersona;
                instanciaAbierta.Evento = "Nuevo";
                instanciaAbierta.totalRegistros = totalRegistros;
                instanciaAbierta.ShowDialog();
            }
            else
            {
                instanciaAbierta.Activate();
                // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                MessageBox.Show("Actualmente está ingresando un dato. No puede abrir nuevamente el formulario.");
            }
        }
        //Eventos necesarios para movilizar el formulario
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAsignarPeriodos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static frmSolicitudVacaciones vacaciones = null;

        // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static Vacaciones historialVacaciones = null;
        private void dtgAsignarPeriodos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgAsignarPeriodos.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgAsignarPeriodos.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgAsignarPeriodos.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                  
                    menu.Items.Add("Asignar Vacaciones").Name = "Asignar Vacaciones" + posicion;
                    menu.Items.Add("Editar").Name = "Editar" + posicion;
                }
                menu.Show(dtgAsignarPeriodos, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick);
            }
        }
        private void menuclick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            try
            {

                if (id.Contains("Asignar Vacaciones"))
                {
                    DateTime fechaActual = DateTime.Now;
                    DateTime fechaPeriodo = Convert.ToDateTime(this.dtgAsignarPeriodos.CurrentRow.Cells["FECHA_INICIO"].Value);
                    // Calcular la diferencia en días entre las fechas
                    TimeSpan diferencia = fechaActual - fechaPeriodo;
                    // Verificar si la diferencia es de un año o más
                    if (diferencia.Days >= 365)
                    {
                        int diferenciaEnDias = diferencia.Days;
                        if (vacaciones == null || vacaciones.IsDisposed)
                        {
                           
                            AbrirFormularioVacaciones(diferenciaEnDias,"Completo");
                        }
                        else
                        {
                            vacaciones.Activate();
                            // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                            MessageBox.Show("Actualmente está ingresando un dato. No puede actualizar un registro.");
                        }

                    }
                    else if(diferencia.Days >= 150)
                    {
                        int diferenciaEnDias = diferencia.Days;
                        if (vacaciones == null || vacaciones.IsDisposed)
                        {
                            AbrirFormularioVacaciones(diferenciaEnDias, "Incompleto");
                        }
                        else
                        {
                            vacaciones.Activate();
                            // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                            MessageBox.Show("Actualmente está ingresando un dato. No puede actualizar un registro.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puedes asignar vacaciones a un empleado aun");
                    }

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }

        private void AbrirFormularioVacaciones(int diferencia, string Evento)
        {

            int IDPERIODO = Convert.ToInt32(this.dtgAsignarPeriodos.CurrentRow.Cells["ID_PERIODO"].Value);
            string Empleado = this.dtgAsignarPeriodos.CurrentRow.Cells["EMPLEADO"].Value.ToString();
            string DPI = this.dtgAsignarPeriodos.CurrentRow.Cells["DPI"].Value.ToString();
            string Periodo = this.dtgAsignarPeriodos.CurrentRow.Cells["PERIODO"].Value.ToString();
            string Dias = this.dtgAsignarPeriodos.CurrentRow.Cells["DIAS_DISPONIBLES"].Value.ToString();
            int DiasTomados = Convert.ToInt32(this.dtgAsignarPeriodos.CurrentRow.Cells["DIAS_TOMADOS"].Value);


            vacaciones = new frmSolicitudVacaciones();
            vacaciones.FormClosed += (s, args) => { vacaciones = null; };
            vacaciones.IdPeriodo = IDPERIODO;
            vacaciones.IdPersona = idPersona;
            vacaciones.Evento = "Nuevo";
            vacaciones.diasTomados = DiasTomados;
            vacaciones.Acumulados = Convert.ToInt32(this.lbTotalAcumulados.Text);
            vacaciones.CargarDatos(diferencia, Evento,Empleado, DPI, Periodo, Dias);
            vacaciones.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgAsignarPeriodos);
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
