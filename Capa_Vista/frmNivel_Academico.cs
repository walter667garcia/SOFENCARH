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
    public partial class frmNivel_Academico : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmNivel_Academico()
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

            cmbAcademico.DataSource = dataSet.Tables["TYNIVELACADEMICO"];
            cmbAcademico.DisplayMember = "ACADEMICO";
            cmbAcademico.ValueMember = "IDNIVEL_ACADEMICO";



        }
        private void frmNivel_Academico_Load(object sender, EventArgs e)
        {
            this.LlenarComboBoxes();
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
            this.cmbPersona.SelectedIndex = -1;
            this.cmbAcademico.SelectedIndex = -1;
            this.txtEstablecimiento.Text = string.Empty;
  
        }
        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;
            this.cmbAcademico.Enabled = valor;
            this.txtEstablecimiento.Enabled = valor;
     
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtEstablecimiento.Focus();
        }
        private void Mostrar()
        {
            this.dtgNivelAcademico.DataSource = nNivelAcademico.Mostrar();
            OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgNivelAcademico.Rows.Count - 1);
        }
        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgNivelAcademico.Columns.Count > 0)
                {
                    this.dtgNivelAcademico.Columns[0].Visible = false;
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
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try

            {
                DateTime dateA = this.dtmAFecha.Value;
                DateTime dateD = this.dtmAFecha.Value;
                if (string.IsNullOrEmpty(this.txtEstablecimiento.Text) ||
                    string.IsNullOrEmpty(this.txtTitulo.Text) ||
                    string.IsNullOrEmpty(this.txtEspecialidad.Text)
                     )
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtEstablecimiento, "Ingrese una Puesto");
                    


                }
                else
                {
                    string rpta = "";
                    if (this.IsNuevo)
                    {

                        rpta = nNivelAcademico.Insertar(

                    
                        Convert.ToInt32(this.cmbPersona.SelectedValue),
                        Convert.ToInt32(this.cmbAcademico.SelectedValue),
                        this.txtEstablecimiento.Text.Trim().ToLower(),
                        dateA,
                        dateD,
                        this.txtTitulo.Text.Trim().ToLower(),
                        this.txtEspecialidad.Text.Trim().ToLower()
                       
                     
                       );

                    }
                    else if (this.IsEditar)
                    {
                        rpta = nNivelAcademico.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                        Convert.ToInt32(this.cmbPersona.SelectedValue),
                        Convert.ToInt32(this.cmbAcademico.SelectedValue),
                        this.txtEstablecimiento.Text.Trim().ToLower(),
                         dateA,
                        dateD,
                        this.txtTitulo.Text.Trim().ToLower(),
                        this.txtEspecialidad.Text.Trim().ToLower()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();

            this.Limpiar();
            this.Habilitar(false);
            this.txtId.Text = string.Empty;
        }
        private void BuscarPersona()
        {
            this.dtgNivelAcademico.DataSource = nNivelAcademico.Buscar(this.txtBuscar.Text);

            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgNivelAcademico.Rows.Count - 1);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
            OcultarColumnas();
        }

        private void dtgNivelAcademico_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgNivelAcademico.CurrentRow != null)
            {
                this.txtId.Text = Convert.ToString(this.dtgNivelAcademico.CurrentRow.Cells["Id"].Value);
                this.txtEstablecimiento.Text = Convert.ToString(this.dtgNivelAcademico.CurrentRow.Cells["ESTABLECIMIENTO"].Value);
                this.txtTitulo.Text = Convert.ToString(this.dtgNivelAcademico.CurrentRow.Cells["TITULO_OBTENIDO"].Value);
                this.txtEspecialidad.Text = Convert.ToString(this.dtgNivelAcademico.CurrentRow.Cells["ESPECIALIDAD"].Value);

                this.dtmAFecha.Text = Convert.ToString(this.dtgNivelAcademico.CurrentRow.Cells["A_FECHA"].Value);
                this.dtmDFecha.Text = Convert.ToString(this.dtgNivelAcademico.CurrentRow.Cells["DE_FECHA"].Value);


                this.tabControl1.SelectedIndex = 1;
            }
        }
        }
}
