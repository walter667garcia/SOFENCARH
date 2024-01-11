using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmPuesto_Funcional : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmPuesto_Funcional()
        {
            InitializeComponent();
        }

        private void frmPuesto_Funcional_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.LlenarComboBoxes();
            this.Habilitar(false);
            this.Botones();
            this.Mostrar();
        }

        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosPuestoFuncional();

            // Asignar los datos a los ComboBox específicos
            cmbPuesto.DataSource = dataSet.Tables["TYPUESTONOMINAL"];
            cmbPuesto.DisplayMember = "PUESTO_NOMINAL";
            cmbPuesto.ValueMember = "ID_PUESTO_NOMINAL";

            cmbSeccion.DataSource = dataSet.Tables["TYUNIDADSECCION"];
            cmbSeccion.DisplayMember = "UNIDAD_SECCION";
            cmbSeccion.ValueMember = "IDUNIDAD_SECCION";

            cmbRenglon.DataSource = dataSet.Tables["TYRENGLONPRESUPUESTARIO"];
            cmbRenglon.DisplayMember = "RENGLON_PRESUPUESTARIO";
            cmbRenglon.ValueMember = "ID_RENGLON";

        }
        private void BuscarDpi()
        {
            this.dtgPuesto.DataSource = nPuestoFuncional.Buscar(this.txtbuscar.Text);

            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgPuesto.Rows.Count - 1);
        }
        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgPuesto.Columns.Count > 0)
                {
                    this.dtgPuesto.Columns[0].Visible = false;
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
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            BuscarDpi();
            OcultarColumnas();
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
            this.cmbPuesto.SelectedIndex = -1;
            this.cmbRenglon.SelectedIndex = -1;
            this.cmbSeccion.SelectedIndex = -1;
            this.txtPuesto.Text = string.Empty;
            this.txtSalario.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.cmbPuesto.Enabled = valor;
            this.cmbSeccion.Enabled = valor;
            this.cmbRenglon.Enabled = valor;
            this.txtPuesto.ReadOnly = !valor;
            this.txtSalario.ReadOnly = !valor;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPuesto.Focus();
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
            this.dtgPuesto.DataSource = nPuestoFuncional.MostrarPuestosFuncionales();
            OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgPuesto.Rows.Count - 1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtPuesto.Text)|| 
                    string.IsNullOrEmpty(this.txtSalario.Text) || 
                    string.IsNullOrEmpty(this.cmbPuesto.DisplayMember) ||
                    string.IsNullOrEmpty(this.cmbRenglon.DisplayMember)||
                    string.IsNullOrEmpty(this.cmbSeccion.DisplayMember)
                    )
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtPuesto, "Ingrese una Puesto");
                    errorIcono.SetError(cmbSeccion, "Ingrese una Seccion");
                    errorIcono.SetError(cmbPuesto, "Ingrese un Puesto");
                    errorIcono.SetError(cmbRenglon, "Ingrese un Renglon");
                    errorIcono.SetError(txtSalario, "Ingrese un Salarios");


                }
                else
                {
                    string rpta = "";
                    if (this.IsNuevo)
                    {

                        rpta = nPuestoFuncional.InsertarPuestoFuncional(
                               
                        this.txtPuesto.Text.Trim().ToUpper(),
                         Convert.ToInt32(this.cmbRenglon.SelectedValue),
                        Convert.ToInt32(this.cmbPuesto.SelectedValue),
                        Convert.ToInt32(this.cmbSeccion.SelectedValue),
                        this.txtSalario.Text.Trim().ToUpper()
                       );

        }
                    else if (this.IsEditar)
                    {
                        rpta = nPuestoFuncional.EditarPuestoFuncional(

                       Convert.ToInt32(this.txtId.Text),
                       this.txtPuesto.Text.Trim().ToUpper(),
                        Convert.ToInt32(this.cmbRenglon.SelectedValue),
                       Convert.ToInt32(this.cmbPuesto.SelectedValue),
                       Convert.ToInt32(this.cmbSeccion.SelectedValue),
                       this.txtSalario.Text.Trim().ToUpper()
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
                    this.Habilitar(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void dtgPuesto_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgPuesto.CurrentRow != null)
            {
                this.txtId.Text = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["id"].Value);
                this.txtPuesto.Text = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["Puesto"].Value);
                this.txtSalario.Text = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["SALARIO_BASE"].Value);
                this.tabControl1.SelectedIndex = 1;
            }
        }
    }
}
