using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class frmFisicoBiologico : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmFisicoBiologico()
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

           

        }
        
         private void Mostrar()
        {

            this.dtgBiologicos.DataSource = nFisicoBiologico.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgBiologicos.Rows.Count);
        }
        private void frmFisicoBiologico_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();

            this.Habilitar(false);
            this.Botones();
            this.LlenarComboBoxes();
        }
        private void BuscarPersona()
        {
            this.dtgBiologicos.DataSource = nFisicoBiologico.Buscar(this.txtBuscar.Text);

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgBiologicos.Rows.Count - 1);
        }
        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgBiologicos.Columns.Count > 0)
                {
                    this.dtgBiologicos.Columns[0].Visible = false;
                   
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
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
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
            this.cmbPersona.SelectedIndex = -1;
            this.txtEnfermedad.Text = string.Empty;
            this.txtDiabetes.Text = string.Empty;
            this.txtAccidente.Text = string.Empty;
            this.txtOperacion.Text = string.Empty;
            this.txtAlergias.Text = string.Empty;
            this.txtTratamiento.Text = string.Empty;
            this.txtEspecifique.Text = string.Empty;
            this.txtLentes.Text = string.Empty;
            this.txtAuditivo.Text = string.Empty;
            this.txtDiscapacidad.Text = string.Empty;
            this.txtDrogas.Text = string.Empty;
            this.txtAlcohol.Text = string.Empty;
            this.txtFuma.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtEstatura.Text = string.Empty;
            this.txtSangre.Text = string.Empty;
            this.txtPasatienpo.Text = string.Empty;
            this.txtDeporte.Text = string.Empty;

        }

        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;

            this.txtEnfermedad.ReadOnly = !valor;
            this.txtDiabetes.ReadOnly = !valor;
            this.txtAccidente.ReadOnly = !valor;
            this.txtOperacion.ReadOnly = !valor;
            this.txtAlergias.ReadOnly = !valor;
            this.txtTratamiento.ReadOnly = !valor;
            this.txtEspecifique.ReadOnly = !valor;
            this.txtLentes.ReadOnly = !valor;
            this.txtAuditivo.ReadOnly = !valor;
            this.txtDiscapacidad.ReadOnly = !valor;
            this.txtDrogas.ReadOnly = !valor;
            this.txtAlcohol.ReadOnly = !valor;
            this.txtFuma.ReadOnly = !valor;
            this.txtPeso.ReadOnly = !valor;
            this.txtEstatura.ReadOnly = !valor;
            this.txtSangre.ReadOnly = !valor;
            this.txtPasatienpo.ReadOnly = !valor;
            this.txtDeporte.ReadOnly = !valor;


        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtId.Text = string.Empty;
            this.Habilitar(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.cmbPersona.Focus();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
            
                if (string.IsNullOrEmpty(this.cmbPersona.Text)
                        || string.IsNullOrEmpty(this.txtDiabetes.Text)
                        

                        )
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(cmbPersona, "Ingrese un Nombre");
                    errorIcono.SetError(txtDiabetes, "Si tienes diabetes pon si");
                    
                }
                else
                {


                    string rpta = "";
                    if (this.IsNuevo)
                    {
                        rpta = nFisicoBiologico.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.txtEnfermedad.Text.Trim().ToUpper(),
                            this.txtDiabetes.Text.Trim().ToUpper(),
                            this.txtAccidente.Text.Trim().ToUpper(),
                            this.txtOperacion.Text.Trim().ToUpper(),
                            this.txtAlergias.Text.Trim().ToUpper(),
                            this.txtTratamiento.Text.Trim().ToUpper(),
                            this.txtEspecifique.Text.Trim().ToUpper(),
                            this.txtLentes.Text.Trim().ToUpper(),
                            this.txtAuditivo.Text.Trim().ToUpper(),
                            this.txtDiscapacidad.Text.Trim().ToUpper(),
                            this.txtDrogas.Text.Trim().ToUpper(),
                            this.txtAlcohol.Text.Trim().ToUpper(),
                            this.txtFuma.Text.Trim().ToUpper(),
                            this.txtPeso.Text.Trim().ToUpper(),
                            this.txtEstatura.Text.Trim().ToUpper(),
                            this.txtSangre.Text.Trim().ToUpper(),
                            this.txtPasatienpo.Text.Trim().ToUpper(),
                            this.txtDeporte.Text.Trim().ToUpper()
                          );
                    }
                    else if (this.IsEditar)
                    {
                       

                        rpta = nFisicoBiologico.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                             Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.txtEnfermedad.Text.Trim().ToUpper(),
                            this.txtDiabetes.Text.Trim().ToUpper(),
                            this.txtAccidente.Text.Trim().ToUpper(),
                            this.txtOperacion.Text.Trim().ToUpper(),
                            this.txtAlergias.Text.Trim().ToUpper(),
                            this.txtTratamiento.Text.Trim().ToUpper(),
                            this.txtEspecifique.Text.Trim().ToUpper(),
                            this.txtLentes.Text.Trim().ToUpper(),
                            this.txtAuditivo.Text.Trim().ToUpper(),
                            this.txtDiscapacidad.Text.Trim().ToUpper(),
                            this.txtDrogas.Text.Trim().ToUpper(),
                            this.txtAlcohol.Text.Trim().ToUpper(),
                            this.txtFuma.Text.Trim().ToUpper(),
                            this.txtPeso.Text.Trim().ToUpper(),
                            this.txtEstatura.Text.Trim().ToUpper(),
                            this.txtSangre.Text.Trim().ToUpper(),
                            this.txtPasatienpo.Text.Trim().ToUpper(),
                            this.txtDeporte.Text.Trim().ToUpper()

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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // También puedes registrar la excepción en un archivo de registro.
            }
        }

        private void dtgBiologicos_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgBiologicos.CurrentRow != null)
            {
                this.txtEnfermedad.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ENFERMEDAD"].Value);
                this.txtDiabetes.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DIABETES"].Value);
                this.txtAccidente.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ACCIDENTE"].Value);
                this.txtOperacion.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["OPERACION"].Value);
                this.txtAlergias.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ALERGIAS"].Value);
                this.txtTratamiento.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["TRATAMIENTO"].Value);
                this.txtEspecifique.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ESPECIFIQUE"].Value);
                this.txtLentes.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["LENTES"].Value);
                this.txtAuditivo.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["AUDITIVO"].Value);
                this.txtDiscapacidad.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DISCAPACIDAD"].Value);
                this.txtDrogas.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DROGAS"].Value);
                this.txtAlcohol.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ALCOHOL"].Value);
                this.txtFuma.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["FUMA"].Value);
                this.txtPeso.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["PESO"].Value);
                this.txtEstatura.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ESTATURA"].Value);
                this.txtSangre.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["SANGRE"].Value);
                this.txtPasatienpo.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["PASATIEMPOS"].Value);
                this.txtDeporte.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DEPORTES"].Value);
                this.txtId.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["IDFISICABIO"].Value);

                this.tabFisicoBiologico .SelectedIndex = 1;
            }
        }
    }
}
