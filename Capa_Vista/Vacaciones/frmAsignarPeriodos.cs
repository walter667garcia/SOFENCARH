using Capa_Negocio;
using Capa_Vista.Familia;
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

        public int idPersona {  get; set; }
        public frmAsignarPeriodos()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            this.dtgAsignarPeriodos.DataSource = nPeriodos.MostrarPeriodos(idPersona);

            List<int> ids = new List<int>();

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
                        id,false);

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
            }
        }
        private void pcbNuevo_Click(object sender, EventArgs e)
        {
            // Verificar si ya hay una instancia abierta
            if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
            {
                // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                instanciaAbierta = new frmPeriodos();
                instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                instanciaAbierta.Idpersona = idPersona;
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
    }
}
