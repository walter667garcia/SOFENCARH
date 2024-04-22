using Capa_Negocio;
using Capa_Vista.Localizacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.ReferenciaPersonal
{
    public partial class frmReferenciaPersonal : Form
    {
        // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static ReferenciaPersonalFormulario instanciaAbierta = null;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //VAriables para movilizar el formulario

        //variables necesarias para iniciar
        public int Idpersona { get; set; }
        public string Persona { get; set; }
        public frmReferenciaPersonal( )
        {
            InitializeComponent();
           
        }
        private void frmReferenciaPersonal_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void pcbTitulo_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
        //Eventos necesarios para movilizar el formulario
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

        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgPersonal.Columns.Count > 0)
                {
                    this.dtgPersonal.Columns[0].Visible = false;
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
        public void Mostrar()
        {
            try
            {
                this.lbPersona.Text = Persona;
                this.dtgPersonal.DataSource = nHome.BuscarReferenciaPersonal(Idpersona);
                OcultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intenta mostrar : {ex.Message}");
            }
        }
        private void pcbNuevo_Click(object sender, EventArgs e)
        {
            // Verificar si ya hay una instancia abierta
            if (instanciaAbierta == null || instanciaAbierta.IsDisposed)
            {
                // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                instanciaAbierta = new ReferenciaPersonalFormulario();
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

        private void dtgPersonal_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgPersonal.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgPersonal.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgPersonal.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Editar").Name = "Editar" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                }
                menu.Show(dtgPersonal, e.X, e.Y);
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
                        string Id = this.dtgPersonal.CurrentRow.Cells["Id"].Value.ToString();
                        string Persona = this.dtgPersonal.CurrentRow.Cells["Nombre"].Value.ToString();
                        string Telefono = this.dtgPersonal.CurrentRow.Cells["Telefono"].Value.ToString();
                        string Relacion = this.dtgPersonal.CurrentRow.Cells["Relacion"].Value.ToString();
                        string Documento = this.dtgPersonal.CurrentRow.Cells["Documento"].Value.ToString();


                        instanciaAbierta = new ReferenciaPersonalFormulario();
                        instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                        instanciaAbierta.Idpersona = Idpersona;
                        instanciaAbierta.Evento = "Editar";
                        instanciaAbierta.CargarDatos(Id, Persona, Telefono, Relacion, Documento);
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
                            int Id = Convert.ToInt32(this.dtgPersonal.CurrentRow.Cells["ID"].Value);
                            rpta = nReferenciaPersonal.Eliminar(Id);
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
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
