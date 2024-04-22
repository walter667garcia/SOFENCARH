using Capa_Negocio;
using Capa_Vista.Actas;
using Capa_Vista.Reporte;
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
            try
            {
                this.dtgVacacionesPersona.DataSource = nPeriodos.MostrarPersonas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }
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
                    menu.Items.Add("Mantenimiento").Name = "Mantenimiento" + posicion;
                    menu.Items.Add("Reporte Periodos").Name = "Reporte Periodos" + posicion;
                    menu.Items.Add("Reporte Vacaciones").Name = "Reporte Vacaciones" + posicion;
                    menu.Items.Add("Reporte Certificación").Name = "Reporte Certificación" + posicion;


                }
                menu.Show(dtgVacacionesPersona, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick1);
            }
        }

        private static frmAsignarPeriodos asignarPeriodos = null;
        private static periodosPersona reporteperiodo = null;
        private static frmReporteVacaciones reporte = null;
        private static Reportecertificacionpersona reportecertificacion = null;



        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            int Idpersona = Convert.ToInt32(this.dtgVacacionesPersona.CurrentRow.Cells["Id"].Value);
            string id = e.ClickedItem.Name.ToString();

            try
            {
                if (id.Contains("Mantenimiento"))
                {
                    if (asignarPeriodos == null || asignarPeriodos.IsDisposed)
                    {
                        id = id.Replace("Mantenimiento", "");
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
                else if (id.Contains("Reporte Vacaciones"))
                {
                    // Verificar si ya hay una instancia abierta
                    if (reporte == null || reporte.IsDisposed)
                    {
                        id = id.Replace("Reporte Vacaciones", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        reporte = new frmReporteVacaciones();
                        reporte.FormClosed += (s, args) => { reporte = null; };
                        reporte.Idpersona = Idpersona;
                        reporte.ShowDialog();
                    }
                    else
                    {
                        reporte.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando solicitando un reporte. No puede abrir nuevamente el formulario.");
                    }
                }
                else if (id.Contains("Reporte Periodos"))
                {
                    // Verificar si ya hay una instancia abierta
                    if (reporteperiodo == null || reporteperiodo.IsDisposed)
                    {
                        id = id.Replace("Reporte Periodos", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        reporteperiodo = new periodosPersona();
                        reporteperiodo.FormClosed += (s, args) => { reporteperiodo = null; };
                        reporteperiodo.Idpersona = Idpersona;
                        reporteperiodo.ShowDialog();
                    }
                    else
                    {
                        reporteperiodo.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando solicitando un reporte. No puede abrir nuevamente el formulario.");
                    }
                }
                else if (id.Contains("Reporte Certificación"))
                {
                    // Verificar si ya hay una instancia abierta
                    if (reportecertificacion == null || reportecertificacion.IsDisposed)
                    {
                        id = id.Replace("Reporte Certificación", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        reportecertificacion = new Reportecertificacionpersona();
                        reportecertificacion.FormClosed += (s, args) => { reportecertificacion = null; };
                        reportecertificacion.Idpersona = Idpersona;
                        reportecertificacion.ShowDialog();
                    }
                    else
                    {
                        reportecertificacion.Activate();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            periodosenca reportecoordinacion = new periodosenca(); 
            reportecoordinacion.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            periodosenca reporteenca = new periodosenca();
            reporteenca.ShowDialog();
        }
    }
}
