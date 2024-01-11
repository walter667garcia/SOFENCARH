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
    public partial class frmIdioma : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmIdioma()
        {
            InitializeComponent();
          
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmIdioma_Load(object sender, EventArgs e)
        {
            this.LlenarComboBoxes();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void Mostrar()
        {
            this.dtgIdioma.DataSource = nIdioma.MostarrhIdioma();
            OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgIdioma.Rows.Count -1);
        }



        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            // Asignar los datos a los ComboBox específicos
            cmbIdioma.DataSource = dataSet.Tables["TYIDIOMA"];
            cmbIdioma.DisplayMember = "IDIOMA";
            cmbIdioma.ValueMember = "IDIDIOMA";

            cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
            cmbPersona.DisplayMember = "Nombre";
            cmbPersona.ValueMember = "IDPERSONA";

        }

        private void BuscarDpi()
        {
            this.dtgIdioma.DataSource = nIdioma.Buscar(this.textBox1.Text);
          
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgIdioma.Rows.Count -1);
        }
      

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }


        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgIdioma.Columns.Count > 0)
                {
                    this.dtgIdioma.Columns[0].Visible = false;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarDpi();
            OcultarColumnas();
        }

        private void dtgIdioma_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgIdioma.CurrentRow != null)
            {
                this.txtId_Idioma.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Id"].Value);
                this.txtConversacion.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Conversacion"].Value);
                this.txtEscritura.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Escritura"].Value);
                this.txtLectura.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Lectura"].Value);
                this.txtDocumento.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Documento"].Value);


                this.tabControl1.SelectedIndex = 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtConversacion.Focus();
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
            this.txtConversacion.Text = string.Empty;
            this.txtDocumento.Text = string.Empty;
            this.txtEscritura.Text = string.Empty;
            this.txtLectura.Text = string.Empty;
            this.cmbIdioma.SelectedIndex = -1;
            this.cmbPersona.SelectedIndex = -1;

        }

        private void Habilitar(bool valor)
        {
            this.cmbIdioma.Enabled = valor;
            this.cmbPersona.Enabled = valor;
            this.txtLectura.ReadOnly = !valor;
            this.txtConversacion.ReadOnly = !valor;
            this.txtDocumento.ReadOnly = !valor;
            this.txtEscritura.ReadOnly = !valor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtLectura.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtConversacion, "Ingrese un Conversacion");
                    errorIcono.SetError(txtLectura, "Ingrese una Lectura");
                    errorIcono.SetError(txtEscritura, "Ingrese un EScrito");
                    errorIcono.SetError(txtDocumento, "Ingrese un Documento");

                }
                else
                {
                    string rpta = "";
                    if (this.IsNuevo)
                    {

                       
                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idIdioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                        string conversacion = txtConversacion.Text;
                        string escritura = txtEscritura.Text;
                        string lectura = txtLectura.Text;
                        string documento = txtDocumento.Text;

                     
                        rpta = nIdioma.Insertar(idPersona, idIdioma, conversacion, escritura, lectura, documento);
                    }
                    else if(this.IsEditar)
                    {
                        //
                        int id_Idioma = Convert.ToInt32(txtId_Idioma.Text);
                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idIdioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                        string conversacion = txtConversacion.Text;
                        string escritura = txtEscritura.Text;
                        string lectura = txtLectura.Text;
                        string documento = txtDocumento.Text;


                        rpta = nIdioma.Actualizar(id_Idioma,idPersona, idIdioma, conversacion, escritura, lectura, documento
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
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtId_Idioma.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtId_Idioma.Text))
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

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
