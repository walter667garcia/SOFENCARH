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
    public partial class frmPuestoNominal : Form
    {
      
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public frmPuestoNominal()
        {
            InitializeComponent();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Enca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Enca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtPuestoNominal.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.txtCodigo.ReadOnly = !valor;
            this.txtPuestoNominal.ReadOnly = !valor;
           
        }

        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
        }

        private void OcultarColumnas()
        {
            this.dtgPuestoFuncional.Columns[0].Visible = false;
          
        }

        private void Mostrar()
        {
            this.dtgPuestoFuncional.DataSource = nPuestoNominal.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgPuestoFuncional.Rows.Count);
        }
        private void BuscarNombre()
        {
            this.dtgPuestoFuncional.DataSource = nPuestoNominal.Buscar(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgPuestoFuncional.Rows.Count);
        }

       
       

        private void frmPuestoNominal_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();

            this.Habilitar(false);
            this.Botones();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPuestoNominal.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtPuestoNominal.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtPuestoNominal, "Ingrese un Puesto");
          
                }
                else
                {
                    string rpta = "";
                    if (this.IsNuevo)
                    {
                        rpta = nPuestoNominal.Insertar(
                            this.txtPuestoNominal.Text.Trim().ToUpper());
                    }
                    else
                    {
                        rpta = nPuestoNominal.Editar(
                            Convert.ToInt32(this.txtCodigo.Text),
                            this.txtPuestoNominal.Text.Trim().ToUpper()
                           
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtCodigo.Text))
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

       

        private void dtgPuestoFuncional_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgPuestoFuncional.CurrentRow != null)
            {
                this.txtCodigo.Text = Convert.ToString(this.dtgPuestoFuncional.CurrentRow.Cells["ID_PUESTO_NOMINAL"].Value);
                this.txtPuestoNominal.Text = Convert.ToString(this.dtgPuestoFuncional.CurrentRow.Cells["PUESTO_NOMINAL"].Value);
                this.tabControl1.SelectedIndex = 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtCodigo.Text = string.Empty;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
    }
    }

