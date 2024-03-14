using Capa_Negocio;
using Capa_Vista.Familia;
using Capa_Vista.ReferenciaLaboral;
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
            this.dtgAsignarPeriodos.DataSource = nPeriodos.MostrarPeriodos(idPersona);
            int suma = 0;

            foreach (DataGridViewRow fila in dtgAsignarPeriodos.Rows)
            {
                // Obtener el valor de la celda como una cadena de texto
                string dias = fila.Cells["DIAS_DISPONIBLES"].Value.ToString();

                // Intentar convertir la cadena a un entero antes de sumarlo
                int diasDisponibles;
                if (int.TryParse(dias, out diasDisponibles))
                {
                    // Sumar el valor convertido a la suma total
                    suma += diasDisponibles;
                    lbTotalDias.Text = suma.ToString();
                }
            }

            /*  List<int> ids = new List<int>();

              // Obtener el número total de filas en el DataGridView
              int totalFilas = dtgAsignarPeriodos.RowCount;

              // Verificar si hay más de 5 filas
              if (totalFilas > 5)
              {
                  // Determinar el índice desde el cual comenzar a recopilar los ID
                  int startIndex = Math.Max(totalFilas - 5, 0);

                  // Recorrer las filas del DataGridView
                  for (int i = 0; i < startIndex; i++)
                  {
                      // Obtener el valor del ID de la fila actual
                      int id = Convert.ToInt32(dtgAsignarPeriodos.Rows[i].Cells["ID_PERIODO"].Value);

                      string rpt = "";

                      rpt = nPeriodos.ActualizarEstado(
                          id, false);

                      // aui quiero ejecutar el procedimiento almacenado
                      // Agregar el ID a la lista
                      ids.Add(id);
                  }

                  // Usar los IDs recopilados según sea necesario
                  foreach (int id in ids)
                  {
                      // Realizar operaciones con los IDs
                      Console.WriteLine("ID: " + id);
                  }


              }
              else
              {
                  MessageBox.Show("El número total de filas es igual o menor a 5.");
              }*/
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

            vacaciones = new frmSolicitudVacaciones();
            vacaciones.FormClosed += (s, args) => { vacaciones = null; };
            vacaciones.IdPeriodo = IDPERIODO;
            vacaciones.IdPersona = idPersona;
            vacaciones.Evento = "Nuevo";
            vacaciones.CargarDatos(diferencia, Evento,Empleado, DPI, Periodo, Dias);
            vacaciones.ShowDialog();
        }

    }
}
