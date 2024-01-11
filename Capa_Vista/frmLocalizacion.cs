using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmLocalizacion : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmLocalizacion()
        {
            InitializeComponent();
        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
            cmbPersona.DisplayMember = "Nombre";
            cmbPersona.ValueMember = "IDPERSONA";

            cmbLocalizacion.DataSource = dataSet.Tables["TyLocalizacion"];
            cmbLocalizacion.DisplayMember = "Descripcion";
            cmbLocalizacion.ValueMember = "IdLOcalizacion";




        }
        private void frmLocalizacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.LlenarComboBoxes();
            this.Habilitar(false);
            this.Botones();
            this.Mostrar();
        }
        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
        }

        private void Limpiar()
        {
            this.cmbLocalizacion.SelectedIndex = -1;
            this.cmbPersona.SelectedIndex = -1;
            this.txtLocalizacion.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.cmbLocalizacion.Enabled = valor;
            this.cmbPersona.Enabled = valor;
            this.txtLocalizacion.ReadOnly = !valor;  
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtLocalizacion.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtId.Text = string.Empty;
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtId.Text))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe buscar un registro para modificar");
            }
        }
        private void Mostrar()
        {
            this.dtgLocalizacion.DataSource = nLocalizacion.MostrarLocalizaciones();
            OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgLocalizacion.Rows.Count - 1);
        }

        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgLocalizacion.Columns.Count > 0)
                {
                    this.dtgLocalizacion.Columns[0].Visible = false;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtLocalizacion.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtLocalizacion, "Ingrese una Localizacion");
                  

                }
                else
                {
                    string rpta = "";
                    if (this.IsNuevo)
                    {

                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idLocalizacion = Convert.ToInt32(cmbLocalizacion.SelectedValue);
                        string localizacion = txtLocalizacion.Text;
                       
                        rpta = nLocalizacion.InsertarLocalizacion(idPersona, idLocalizacion, localizacion);
                    }
                    else if (this.IsEditar)
                    {
                        //
                        int id = Convert.ToInt32(txtId.Text);
                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idLocalizacion = Convert.ToInt32(cmbLocalizacion.SelectedValue);
                        string localizacion = txtLocalizacion.Text;


                        rpta = nLocalizacion.ActualizarLocalizacion (id, idPersona, idLocalizacion, localizacion
                            );
                    }

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk(this.IsNuevo ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void BuscarDpi()
        {
            this.dtgLocalizacion.DataSource = nLocalizacion.BuscarLocalizacion(this.txtBuscar.Text);

            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgLocalizacion.Rows.Count - 1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            BuscarDpi();
            OcultarColumnas();
        }

        private void dtgLocalizacion_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgLocalizacion.CurrentRow != null)
            {
                this.txtId.Text = Convert.ToString(this.dtgLocalizacion.CurrentRow.Cells["id"].Value);
                this.txtLocalizacion.Text = Convert.ToString(this.dtgLocalizacion.CurrentRow.Cells["Localizacion"].Value);
         


                this.tabControl1.SelectedIndex = 1;
            }
        }
    }
}
