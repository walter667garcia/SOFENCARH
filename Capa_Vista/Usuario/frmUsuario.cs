using Capa_Negocio;
using Capa_Vista.Localizacion;
using Capa_Vista.SocioEconomico;
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
        }
        private void MostrarUsuarios()
        {
            this.dtgUsuarios.DataSource = nUsuarios.MostrarUsuarios();

        }
        private void MostrarEmpleado()
        {
            this.dtgPersona.DataSource = nUsuarios.MostrarPersonaEstado();
            Imagen();
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
    }
}
