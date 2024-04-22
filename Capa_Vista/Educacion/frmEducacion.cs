using Capa_Negocio;
using Capa_Vista.DatosAdicionales;
using Capa_Vista.Localizacion;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.Educacion
{
    public partial class frmEducacion : Form
    {

        //variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static EducacionFormulario instanciaAbierta = null;
        //variables necesarias para iniciar 
        public int Idpersona { get; set; }
        public string Persona { get; set; }
        public frmEducacion()
        {
           
            InitializeComponent();
        }

        private void frmEducacion_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        //eventos necesarios para movilizar el formulario
        private void plMenu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void plMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void plMenu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void pcbNuevo_Click(object sender, EventArgs e)
        {
            // Verificar si ya hay una instancia abierta
            if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
            {
                // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                instanciaAbierta = new EducacionFormulario();
                instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                instanciaAbierta.Idpersona = Idpersona;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Verificar si ya hay una instancia abierta
            if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
            {
                this.Close();
            }
            else
            {
                instanciaAbierta.Activate();
                // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                MessageBox.Show("No puedes cerrar esta ventana porque estas ingresando un dato");
            }
        }
        private void OcultarColumnas()
        {

            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgEducacion.Columns.Count > 0)
                {
                    this.dtgEducacion.Columns[0].Visible = false;
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
                lbPersona.Text = Persona;
                this.dtgEducacion.DataSource = nHome.BuscarEducacion(Idpersona);
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }
        }

        private void pcbTitulo_Click(object sender, EventArgs e)
        {
            Mostrar();
           
        }

        private void lbPersona_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgEducacion_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dtgEducacion_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgEducacion.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgEducacion.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgEducacion.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Editar").Name = "Editar" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                }
                menu.Show(dtgEducacion, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick);
            }

        }
        private void menuclick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            try
            {

                if (id.Contains("Editar"))
                {
                    if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
                    {
                        id = id.Replace("Editar", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        var datos = dtgEducacion.CurrentRow.Cells;
                        string Id = datos["ID"].Value?.ToString();
                        string Educacion = datos["Educacion"].Value?.ToString();
                        string Establecimiento = datos["ESTABLECIMIENTO"].Value?.ToString();
                        string fechaInicio = datos["INICIO"].Value?.ToString();
                        string fechaFin = datos["FIN"].Value?.ToString();
                        string Titulo = datos["Titulo"].Value?.ToString();
                        string Especialidad = datos["ESPECIALIDAD"].Value?.ToString();
                        string Documento = datos["DOCUMENTO"].Value?.ToString();


                        instanciaAbierta = new EducacionFormulario();
                        instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                        instanciaAbierta.Idpersona = Idpersona;
                        instanciaAbierta.CargarDatos(Id,Educacion, Establecimiento,
                                                     fechaInicio, fechaFin, Titulo, Especialidad, Documento);
                        instanciaAbierta.Evento = "Editar";
                        instanciaAbierta.ShowDialog();
                    }
                    else
                    {
                        instanciaAbierta.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando un dato. No puede actualizar un registro.");
                    }
                }
                else if (id.Contains("Eliminar"))
                {
                    if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
                    {
                        // Confirmar eliminación con un cuadro de diálogo
                        DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            id = id.Replace("Eliminar", "");
                            string rpta = "";
                            int Id = Convert.ToInt32(this.dtgEducacion.CurrentRow.Cells["ID"].Value);
                            rpta = nNivelAcademico.Eliminar(Id);
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Eliminó el registro");
                                Mostrar();
                            }
                            else
                            {
                                this.MensajeError(rpta);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelaste la eliminacion");
                        }
                    }
                    else
                    {
                        instanciaAbierta.Activate();
                        // Si ya hay una instancia abierta, mostrar un mensaje de advertencia
                        MessageBox.Show("Actualmente está ingresando o actualizando un registro. No se puede eliminar un registro.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario: " + ex.Message);
            }
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Enca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Enca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
