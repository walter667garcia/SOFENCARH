using Capa_Negocio;
using Capa_Vista.Actas;
using DocumentFormat.OpenXml.Office2021.PowerPoint.Tasks;
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
    public partial class frmVacacionesPersona : Form
    {
        public frmVacacionesPersona()
        {
            InitializeComponent();
        }

        private void frmVacacionesPersona_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            this.dtgVacacionesPersona.DataSource = nPeriodos.MostrarPersonas();
        }

        private void dtgVacacionesPersona_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgVacacionesPersona.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgVacacionesPersona.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgVacacionesPersona.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Agregar Periodos").Name = "Agregar Periodos" + posicion;
                    menu.Items.Add("Historial Vacaciones").Name = "Historial Vacaciones" + posicion;

                }
                menu.Show(dtgVacacionesPersona, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick1);
            }
        }

        private static frmAsignarPeriodos asignarPeriodos = null;
        private static Vacaciones historialVacaciones = null;
        


        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            int Idpersona = Convert.ToInt32(this.dtgVacacionesPersona.CurrentRow.Cells["Id"].Value);
            string id = e.ClickedItem.Name.ToString();

            try
            {
                if (id.Contains("Agregar Periodos"))
                {
                    if (asignarPeriodos == null || asignarPeriodos.IsDisposed)
                    {
                        id = id.Replace("Agregar Periodos", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario

                        asignarPeriodos = new frmAsignarPeriodos();
                        asignarPeriodos.FormClosed += (s, args) => { asignarPeriodos = null; };
                        asignarPeriodos.idPersona = Idpersona;


                        asignarPeriodos.ShowDialog();
                    }
                    else
                    {
                        asignarPeriodos.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando un dato. No puede actualizar un registro.");
                    }
                }
                else if (id.Contains("Historial Vacaciones"))
                {
                    // Verificar si ya hay una instancia abierta
                    if (historialVacaciones == null || historialVacaciones.IsDisposed)
                    {
                        id = id.Replace("Historial Vacaciones", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        historialVacaciones = new Vacaciones();
                        historialVacaciones.FormClosed += (s, args) => { historialVacaciones = null; };
                        historialVacaciones.IdPersona = Idpersona;
                        historialVacaciones.ShowDialog();
                    }
                    else
                    {
                        historialVacaciones.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando solicitando un reporte. No puede abrir nuevamente el formulario.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }

        private void BuscarPersona()
        {
            this.dtgVacacionesPersona.DataSource = nVacaciones.BuscarPersona(this.txtBuscar.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BuscarPersona();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Mostrar();
            txtBuscar.Text = "";
        }
    }
}
