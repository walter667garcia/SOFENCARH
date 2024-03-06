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
using ClosedXML.Excel;

namespace Capa_Vista
{
    public partial class frmOtrosDatos2 : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmOtrosDatos2()
        {
            InitializeComponent();

            dtmFechaT.Format = DateTimePickerFormat.Custom;
            dtmFechaT.CustomFormat = "dd/MM/yyyy";

            dtmFechaT.KeyPress += dtmFechaT_KeyPress;
            dtmFechasS.Format = DateTimePickerFormat.Custom;
            dtmFechasS.CustomFormat = "dd/MM/yyyy";
            dtmFechasS.KeyPress += dtmFechasS_KeyPress;

            ConfigurarOrdenTabulacion();
        }

        private void Habilitar(bool valor)
        {

            this.cmbPersona.Enabled = valor;
            this.cmbTrabajoEnca.Enabled = valor;
            this.dtmFechaT.Enabled = valor;
            this.txtPuesto.ReadOnly = !valor;
            this.cmbSolicitudEnca.Enabled = valor;
            this.dtmFechasS.Enabled = valor;

            this.txtPlaza.ReadOnly = !valor;
            this.cmbDisponibilidad.Enabled = valor;
            this.txtFamilliaEnca.ReadOnly = !valor;
            this.txtFamiliaEncaActual.ReadOnly = !valor;
            this.txtxEncaRelacion.ReadOnly = !valor;
            this.txtPustoConocido.ReadOnly = !valor;
            this.cmbPlazaVacante.Enabled = valor;
            
           
               }
        private void Limpiar()
        {
            this.cmbTrabajoEnca.Text = string.Empty;
            this.dtmFechaT.Value = DateTime.Today;
            this.txtPuesto.Text = string.Empty;
            this.cmbSolicitudEnca.Text = string.Empty;
            this.dtmFechasS.Value = DateTime.Today;
            this.txtPlaza.Text = string.Empty;
            this.cmbDisponibilidad.Text = string.Empty;
            this.txtFamilliaEnca.Text = string.Empty;
            this.txtFamiliaEncaActual.Text = string.Empty;
            this.txtxEncaRelacion.Text = string.Empty;
            this.cmbPlazaVacante.Text = string.Empty;
            this.txtPustoConocido.Text = string.Empty;

        }
        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
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
        private void Mostrar()
        {

            this.dtgOtrosDatos.DataSource = nOtrosDatos.Mostar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgOtrosDatos.Rows.Count);
        }

        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgOtrosDatos.Columns.Count > 0)
                {
                    this.dtgOtrosDatos.Columns[0].Visible = false;
                   
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtId.Text = string.Empty;
            this.Habilitar(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cmbPersona.Text))
            {
                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas realizar la actualización?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.IsEditar = true;
                    this.Botones();
                    this.Habilitar(true);
                }
                // Si el usuario elige "No", no se realiza la actualización
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
                DateTime fechat = this.dtmFechaT.Value;
                DateTime fechaS = this.dtmFechasS.Value;

                if (string.IsNullOrEmpty(this.txtFamilliaEnca.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(cmbPersona, "Ingrese un Nombre");
                }
                else
                {
                    if (this.IsEditar)
                    {
                        // Preguntar al usuario si desea realizar la actualización
                        DialogResult result = MessageBox.Show("¿Desea actualizar el registro?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            return; // No realizar la actualización
                        }
                    }

                    string rpta = "";
                    if (this.IsNuevo)
                    {
                        rpta = nOtrosDatos.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.cmbTrabajoEnca.Text.Trim().ToUpper(),
                            fechat,
                            this.txtPuesto.Text.Trim().ToUpper(),
                            this.cmbSolicitudEnca.Text.Trim().ToUpper(),
                            fechaS,
                            this.txtPlaza.Text.Trim().ToUpper(),
                            this.cmbDisponibilidad.Text.Trim().ToUpper(),
                            this.txtFamilliaEnca.Text.Trim().ToUpper(),
                            this.txtFamiliaEncaActual.Text.Trim().ToUpper(),
                            this.txtxEncaRelacion.Text.Trim().ToUpper(),
                            this.txtPustoConocido.Text.Trim().ToUpper(),
                            this.cmbPlazaVacante.Text.Trim().ToUpper()
                        );
                    }
                    else if (this.IsEditar)
                    {
                        rpta = nOtrosDatos.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.cmbTrabajoEnca.Text.Trim().ToUpper(),
                            fechat,
                            this.txtPuesto.Text.Trim().ToUpper(),
                            this.cmbSolicitudEnca.Text.Trim().ToUpper(),
                            fechaS,
                            this.txtPlaza.Text.Trim().ToUpper(),
                            this.cmbDisponibilidad.Text.Trim().ToUpper(),
                            this.txtFamilliaEnca.Text.Trim().ToUpper(),
                            this.txtFamiliaEncaActual.Text.Trim().ToUpper(),
                            this.txtxEncaRelacion.Text.Trim().ToUpper(),
                            this.txtPustoConocido.Text.Trim().ToUpper(),
                            this.cmbPlazaVacante.Text.Trim().ToUpper()
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
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
            cmbPersona.DisplayMember = "Nombre";
            cmbPersona.ValueMember = "IDPERSONA";


        }
        private void frmOtrosDatos_Load(object sender, EventArgs e)
        {

            this.Top = 0;
            this.Left = 0;

            this.Mostrar();

            this.Habilitar(false);
            this.Botones();
            this.LlenarComboBoxes();
        }

     

        private void BuscarOtrosDatos()
        {
            this.dtgOtrosDatos.DataSource = nOtrosDatos.Buscar(this.txtBuscar.Text);
            OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgOtrosDatos.Rows.Count - 1);
        }
        

        private void tabMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
            BuscarOtrosDatos();
        }

        private void dtgOtrosDatos_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgOtrosDatos.CurrentRow != null)
            {
                if(btnNuevo.Enabled != false)
                {
                    string Persona = dtgOtrosDatos.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                    this.txtId.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["ID"].Value);
                    this.cmbTrabajoEnca.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["TrabajoEnca"].Value);
                    this.dtmFechaT.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["FechaT"].Value);
                    this.txtPuesto.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Puesto"].Value);
                    this.cmbSolicitudEnca.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["SolicitudEnca"].Value);
                    this.dtmFechasS.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["FechaS"].Value);
                    this.txtPlaza.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Plaza"].Value);
                    this.cmbDisponibilidad.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Disponibilidad"].Value);
                    this.txtFamilliaEnca.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Familiar_Enca"].Value);
                    this.txtFamiliaEncaActual.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Familiar_Enca1"].Value);
                    this.txtxEncaRelacion.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Enca_Relacion"].Value);
                    this.txtPustoConocido.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Puesto1"].Value);
                    this.cmbPlazaVacante.Text = Convert.ToString(this.dtgOtrosDatos.CurrentRow.Cells["Plaza_Vacante"].Value);
                }
                else
                {
                    MessageBox.Show("No puede editar y crear un nuevo registro a la vez");
                }
            }
        }

        private void dtmFechaT_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dtmFechasS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ConfigurarOrdenTabulacion()
        {
            // Establecer el orden de tabulación para los TextBox
            cmbPersona.TabIndex = 1;
            cmbTrabajoEnca.TabIndex = 2;
            dtmFechaT.TabIndex = 3;
            txtPuesto.TabIndex = 4;
            dtmFechasS.TabIndex = 6;
            cmbSolicitudEnca.TabIndex = 5;
            txtPlaza.TabIndex = 7;
            cmbDisponibilidad.TabIndex = 8;
            cmbPlazaVacante.TabIndex = 13;
            txtFamilliaEnca.TabIndex = 9;
            txtFamiliaEncaActual.TabIndex = 10;
            txtxEncaRelacion.TabIndex = 11;
            txtPustoConocido.TabIndex = 12;
            btnGuardar.TabIndex = 13;

        }

        private string ValidarTexto(string texto)
        {
            // Filtra letras (mayúsculas y minúsculas), espacios y puntos.
            string patron = "[a-zA-Z0-9áéíóúÁÉÍÓÚ-ñ -.,+]";

            StringBuilder textoValidado = new StringBuilder();

            foreach (char caracter in texto)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(caracter.ToString(), patron))
                {
                    textoValidado.Append(caracter);
                }
            }

            return textoValidado.ToString();
        }

        private string ValidarTexto1(string texto)
        {
            // Patrón para filtrar letras (mayúsculas y minúsculas), números, espacios, puntos, guiones, comas y arrobas.
            string patron = "[a-zA-Z0-9áéíóúÁÉÍÓÚ-ñ -.,+]";

            StringBuilder textoValidado = new StringBuilder();

            foreach (char caracter in texto)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(caracter.ToString(), patron))
                {
                    textoValidado.Append(caracter);
                }
            }

            return textoValidado.ToString();
        }

        private void txtPuesto_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPuesto.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPuesto.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPuesto.SelectionStart = textoValidado.Length;
            }
        }

        private void txtPlaza_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPlaza.Text;
            string textoValidado = ValidarTexto1(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPlaza.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPlaza.SelectionStart = textoValidado.Length;
            }
        }

        private void txtFamilliaEnca_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtFamilliaEnca.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtFamilliaEnca.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtFamilliaEnca.SelectionStart = textoValidado.Length;
            }
        }

        private void txtFamiliaEncaActual_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtFamiliaEncaActual.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtFamiliaEncaActual.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtFamiliaEncaActual.SelectionStart = textoValidado.Length;
            }
        }

        private void txtxEncaRelacion_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtxEncaRelacion.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtxEncaRelacion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtxEncaRelacion.SelectionStart = textoValidado.Length;
            }
        }

        private void txtPustoConocido_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPustoConocido.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPustoConocido.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPustoConocido.SelectionStart = textoValidado.Length;
            }
        }

        private void ExportarDataGridViewAExcel(DataGridView dataGridView)
        {
            // Verificar si hay datos en el DataGridView
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crear un nuevo libro de Excel
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Hoja1");

            // Agregar los encabezados de columnas
            for (int i = 1; i <= dataGridView.Columns.Count; i++)
            {
                worksheet.Cell(1, i).Value = dataGridView.Columns[i - 1].HeaderText;
            }

            // Agregar los datos de las filas
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            // Guardar el archivo de Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "ArchivoExcel.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("El archivo Excel se ha exportado correctamente.", "Exportar a Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgOtrosDatos);
        }

        private void cmbTrabajoEnca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrabajoEnca.SelectedItem.ToString() == "Si")
            {
               
                txtPuesto.Enabled = true;
            }
            else
            {
               
                txtPuesto.Text = "--------";
                txtPuesto.Enabled = false;
            }
        }

        private void cmbSolicitudEnca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSolicitudEnca.SelectedItem.ToString() == "Si")
            {
               
                txtPlaza.Enabled = true;

            }
            else
            {
                
                txtPlaza.Text = "--------";
                txtPlaza.Enabled = false;
            }
        }

        private string valorCmbPersona = "";

        public void cargar(string persona, string nombre)
        {
            this.cmbPersona.Text = nombre;
            this.cmbPersona.Enabled = false;
            this.txtIdHome.Text = persona;

            valorCmbPersona = this.cmbPersona.Text;
        }
    }
}
