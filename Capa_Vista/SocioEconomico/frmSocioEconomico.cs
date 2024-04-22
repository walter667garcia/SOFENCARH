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

namespace Capa_Vista.SocioEconomico
{
    public partial class frmSocioEconomico : Form
    {
        // Variable estática para mantener un seguimiento de si ya hay una instancia abierta
        private static SocioEconomicoFormulario instanciaAbierta = null;

        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        //variables necesarias para iniciar
        public int Idpersona { get; set; }
        public string Persona { get; set; }
        public frmSocioEconomico()
        {
            InitializeComponent();
          
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

        private void frmSocioEconomico_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void pcbTitulo_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgSocioEconomico.Columns.Count > 0)
                {
                    this.dtgSocioEconomico.Columns[0].Visible = false;
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
                this.dtgSocioEconomico.DataSource = nHome.BuscarSocioEconomico(Idpersona);
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
                instanciaAbierta = new SocioEconomicoFormulario();
                instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                instanciaAbierta.Idpersona = Idpersona;
                instanciaAbierta.Evento = "Nuevo";
                instanciaAbierta.Show();
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

        private void dtgSocioEconomico_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgSocioEconomico.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgSocioEconomico.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgSocioEconomico.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Editar").Name = "Editar" + posicion;
                    menu.Items.Add("Eliminar").Name = "Eliminar" + posicion;
                }
                menu.Show(dtgSocioEconomico, e.X, e.Y);
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
                        id = id.Replace("Ubicacion", "");
                        // Si no hay una instancia abierta, crear una nueva instancia y mostrar el formulario
                        string Id = this.dtgSocioEconomico.CurrentRow.Cells["id"].Value.ToString();
                        string Agrupacion = dtgSocioEconomico.CurrentRow.Cells["AGRUPACION"].Value.ToString();
                        string Vivienda = dtgSocioEconomico.CurrentRow.Cells["VIVIENDA"].Value.ToString();
                        string Vehiculo = dtgSocioEconomico.CurrentRow.Cells["VEHICULO"].Value.ToString();
                        string DetalleAgrupacion = this.dtgSocioEconomico.CurrentRow.Cells["DETALLE_AGRUPACION"].Value.ToString();
                        string Dependencias = this.dtgSocioEconomico.CurrentRow.Cells["DEPENDIENTES"].Value.ToString();
                        string DetalleDependencias = this.dtgSocioEconomico.CurrentRow.Cells["DETALLE_DEPENDIENTES"].Value.ToString();
                        string PagoVivienda = this.dtgSocioEconomico.CurrentRow.Cells["PAGO_VIVIENDA"].Value.ToString();
                        string FlagDeuda = this.dtgSocioEconomico.CurrentRow.Cells["FLAG_DEUDAS"].Value.ToString();
                        string MontoDeuda = this.dtgSocioEconomico.CurrentRow.Cells["MONTO_DEUDA"].Value.ToString();
                        string MotivoDeuda = this.dtgSocioEconomico.CurrentRow.Cells["MOTIVO_DEUDA"].Value.ToString();
                        string FlagOtrosIngresos = this.dtgSocioEconomico.CurrentRow.Cells["FLAG_OTROS_INGRESOS"].Value.ToString();
                        string MontoOtrosIngresos = this.dtgSocioEconomico.CurrentRow.Cells["MONTO_OTROS_INGRESOS"].Value.ToString();
                        string FuenteOtrosIngresos = this.dtgSocioEconomico.CurrentRow.Cells["FUENTES_OTROS_INGRESOS"].Value.ToString();
                        string TipoVehiculo = this.dtgSocioEconomico.CurrentRow.Cells["TIPO_VEHICULO"].Value.ToString();
                        string PlacaVehiculo = this.dtgSocioEconomico.CurrentRow.Cells["MODELO_VEHICULO"].Value.ToString();
                        string ModeloVehiculo = this.dtgSocioEconomico.CurrentRow.Cells["PLACA_VEHICULO"].Value.ToString();
                       

                        instanciaAbierta = new SocioEconomicoFormulario();
                        instanciaAbierta.FormClosed += (s, args) => { instanciaAbierta = null; };
                        instanciaAbierta.Idpersona = Idpersona;
                        instanciaAbierta.Evento = "Editar";
                        instanciaAbierta.CargarDatos(
                            Id,Agrupacion,Vivienda,Vehiculo,DetalleAgrupacion,Dependencias,
                           DetalleDependencias, PagoVivienda,FlagDeuda,MontoDeuda ,MotivoDeuda,FlagOtrosIngresos,
                            MontoOtrosIngresos,FuenteOtrosIngresos,TipoVehiculo,PlacaVehiculo,ModeloVehiculo);
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
                            int Id = Convert.ToInt32(this.dtgSocioEconomico.CurrentRow.Cells["ID"].Value);
                            rpta = nSocioEconomico.Eliminar(Id);
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
