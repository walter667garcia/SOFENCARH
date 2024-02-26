using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Capa_Vista
{
    public partial class frmSocio_Economico : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmSocio_Economico()
        {
            InitializeComponent();
            ConfigurarOrdenTabulacion();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtDetalleAgrupacion.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtDetalleAgrupacion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtDetalleAgrupacion.SelectionStart = textoValidado.Length;
            }

        }
        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
            cmbPersona.DisplayMember = "Nombre";
            cmbPersona.ValueMember = "IDPERSONA";

            cmbVehiculo.DataSource = dataSet.Tables["TYVEHICULO"];
            cmbVehiculo.DisplayMember = "VEHICULO";
            cmbVehiculo.ValueMember = "IDVEHICULO";

            cmbVivienda.DataSource = dataSet.Tables["TYVIVIENDA"];
            cmbVivienda.DisplayMember = "VIVIENDA";
            cmbVivienda.ValueMember = "IdVIVIENDA";

            cmbAgrupacion.DataSource = dataSet.Tables["TYAGRUPACION"];
            cmbAgrupacion.DisplayMember = "AGRUPACION";
            cmbAgrupacion.ValueMember = "IDAGRUPACION";


        }
        private void Mostrar()
        {

            this.dtgSocioEconomico.DataSource = nSocioEconomico.MostrarSocioEconomico();
            this.OcultarColumnas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgSocioEconomico.Rows.Count);
        }
        private void frmSocio_Economico_Load(object sender, EventArgs e)
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
            this.dtgSocioEconomico.DataSource = nSocioEconomico.BuscarSocioEconomico(this.txtBuscar.Text);

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgSocioEconomico.Rows.Count - 1);
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
        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
        }

        private void Limpiar()
        {
            this.cmbAgrupacion.SelectedIndex = -1;
            this.txtDetalleAgrupacion.Text = string.Empty;
            this.txtDependencias.Text = string.Empty;
            this.txtDetalleDependencias.Text = string.Empty;
            this.cmbVivienda.SelectedIndex = -1;
            this.txtPagoVivienda.Text = string.Empty;
            this.cmbFlagDeuda.Text = string.Empty;
            this.txtMontoDeuda.Text = string.Empty;
            this.txtMotivoDeuda.Text = string.Empty;
            this.cmbFlagOtrosIngresos.SelectedIndex = -1;
            this.txtMontoOtrosIngresos.Text = string.Empty;
            this.txtFuenteOtrosIngresos.Text = string.Empty;
            this.cmbVehiculo.SelectedIndex = -1;
            this.txtTipoVehiculo.Text = string.Empty;
            this.txtPlacaVehiculo.Text = string.Empty;
            this.txtModeloVehiculo.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;
            this.cmbAgrupacion.Enabled = valor;
            this.txtDetalleAgrupacion.ReadOnly = !valor;
            this.txtDependencias.ReadOnly = !valor;
            this.txtDetalleDependencias.ReadOnly = !valor;

            this.cmbVivienda.Enabled = valor;
            this.txtPagoVivienda.ReadOnly = !valor;
            this.cmbFlagDeuda.Enabled = valor;
            this.txtMontoDeuda.ReadOnly = !valor;
            this.txtMotivoDeuda.ReadOnly = !valor;
            this.cmbFlagOtrosIngresos.Enabled = valor;
            this.txtMontoOtrosIngresos.ReadOnly = !valor;
            this.txtFuenteOtrosIngresos.ReadOnly = !valor;
            this.cmbVehiculo.Enabled = valor;
            this.txtTipoVehiculo.ReadOnly = !valor;
            this.txtPlacaVehiculo.ReadOnly = !valor;
            this.txtModeloVehiculo.ReadOnly = !valor;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtDetalleAgrupacion.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtDetalleAgrupacion, "Ingrese un detalle de agrupación");
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
                        rpta = nSocioEconomico.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            Convert.ToInt32(this.cmbAgrupacion.SelectedValue),
                            this.txtDetalleAgrupacion.Text.Trim().ToUpper(),
                            this.txtDependencias.Text.Trim().ToUpper(),
                            this.txtDetalleDependencias.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.cmbVivienda.SelectedValue),
                            this.txtPagoVivienda.Text.Trim().ToUpper(),
                            this.cmbFlagDeuda.Text.Trim().ToLower(),
                            this.txtMontoDeuda.Text.Trim().ToUpper(),
                            this.txtMotivoDeuda.Text.Trim().ToUpper(),
                            this.cmbFlagOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtMontoOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtFuenteOtrosIngresos.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.cmbVehiculo.SelectedValue),
                            this.txtTipoVehiculo.Text.Trim().ToUpper(),
                            this.txtPlacaVehiculo.Text.Trim().ToUpper(),
                            this.txtModeloVehiculo.Text.Trim().ToUpper());
                    }
                    else if (this.IsEditar)
                    {
                        rpta = nSocioEconomico.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            Convert.ToInt32(this.cmbAgrupacion.SelectedValue),
                            this.txtDetalleAgrupacion.Text.Trim().ToUpper(),
                            this.txtDependencias.Text.Trim().ToUpper(),
                            this.txtDetalleDependencias.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.cmbVivienda.SelectedValue),
                            this.txtPagoVivienda.Text.Trim().ToUpper(),
                            this.cmbFlagDeuda.Text.Trim().ToLower(),
                            this.txtMontoDeuda.Text.Trim().ToUpper(),
                            this.txtMotivoDeuda.Text.Trim().ToUpper(),
                            this.cmbFlagOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtMontoOtrosIngresos.Text.Trim().ToUpper(),
                            this.txtFuenteOtrosIngresos.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.cmbVehiculo.SelectedValue),
                            this.txtTipoVehiculo.Text.Trim().ToUpper(),
                            this.txtPlacaVehiculo.Text.Trim().ToUpper(),
                            this.txtModeloVehiculo.Text.Trim().ToUpper());
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

      

        private void txtPagoVivienda_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtPagoVivienda.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtPagoVivienda.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtPagoVivienda.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtPagoVivienda.SelectionStart = txtPagoVivienda.Text.Length;
        }

        private void txtMontoDeuda_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtMontoDeuda.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtMontoDeuda.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtMontoDeuda.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtMontoDeuda.SelectionStart = txtMontoDeuda.Text.Length;
        }

        private void txtMontoOtrosIngresos_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtMontoOtrosIngresos.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtMontoOtrosIngresos.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtMontoOtrosIngresos.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtMontoOtrosIngresos.SelectionStart = txtMontoOtrosIngresos.Text.Length;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
            OcultarColumnas();
           
        }

        private void dtgSocioEconomico_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgSocioEconomico.CurrentRow != null)
            {
                if (btnNuevo.Enabled != false)
                {
                    string Persona = dtgSocioEconomico.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                    string Agrupacion = dtgSocioEconomico.CurrentRow.Cells["AGRUPACION"].Value.ToString();
                    int idAgrupacion = cmbAgrupacion.FindStringExact(Agrupacion);
                    cmbAgrupacion.SelectedIndex = idAgrupacion;

                    string Vivienda = dtgSocioEconomico.CurrentRow.Cells["VIVIENDA"].Value.ToString();
                    int idVivienda = cmbVivienda.FindStringExact(Vivienda);
                    cmbVivienda.SelectedIndex = idVivienda;

                    string Vehiculo = dtgSocioEconomico.CurrentRow.Cells["VEHICULO"].Value.ToString();
                    int idVehiculo = cmbVehiculo.FindStringExact(Vehiculo);
                    cmbVehiculo.SelectedIndex = idVehiculo;


                    this.txtDetalleAgrupacion.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["DETALLE_AGRUPACION"].Value);
                    this.txtDependencias.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["DEPENDIENTES"].Value);
                    this.txtDetalleDependencias.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["DETALLE_DEPENDIENTES"].Value);
                    this.txtPagoVivienda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["PAGO_VIVIENDA"].Value);
                    this.cmbFlagDeuda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["FLAG_DEUDAS"].Value);
                    this.txtMontoDeuda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["MONTO_DEUDA"].Value);
                    this.txtMotivoDeuda.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["MOTIVO_DEUDA"].Value);
                    this.cmbFlagOtrosIngresos.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["FLAG_OTROS_INGRESOS"].Value);
                    this.txtMontoOtrosIngresos.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["MONTO_OTROS_INGRESOS"].Value);
                    this.txtFuenteOtrosIngresos.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["FUENTES_OTROS_INGRESOS"].Value);
                    this.txtTipoVehiculo.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["TIPO_VEHICULO"].Value);
                    this.txtPlacaVehiculo.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["Modelo"].Value);
                    this.txtModeloVehiculo.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["Placa"].Value);
                    this.txtId.Text = Convert.ToString(this.dtgSocioEconomico.CurrentRow.Cells["id"].Value);
                }
                else
                {
                    MessageBox.Show("No puede editar y crear un nuevo registro a la vez");
                }



            }
        }

        private void ConfigurarOrdenTabulacion()
        {
            // Establecer el orden de tabulación para los TextBox
            cmbPersona.TabIndex = 1;
            cmbAgrupacion.TabIndex = 2;
            txtDetalleAgrupacion.TabIndex = 3;
            txtDependencias.TabIndex = 4;
            txtDetalleDependencias.TabIndex = 5;
            cmbVivienda.TabIndex = 6;
            txtPagoVivienda.TabIndex = 7;
            cmbFlagDeuda.TabIndex = 8;
            txtMontoDeuda.TabIndex = 9;
            txtMotivoDeuda.TabIndex = 10;
            cmbFlagOtrosIngresos.TabIndex = 11;
            txtFuenteOtrosIngresos.TabIndex = 12;
            txtMontoOtrosIngresos.TabIndex = 13;
            cmbVehiculo.TabIndex = 14;
            txtTipoVehiculo.TabIndex = 15;
            txtPlacaVehiculo.TabIndex = 16;
            txtModeloVehiculo.TabIndex = 17;
            btnGuardar.TabIndex = 18;
            btnexcel.TabIndex = 19;


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

        private void txtDependencias_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtDependencias.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtDependencias.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtDependencias.SelectionStart = textoValidado.Length;
            }
        }

        private void txtDetalleDependencias_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtDetalleDependencias.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtDetalleDependencias.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtDetalleDependencias.SelectionStart = textoValidado.Length;
            }
        }

        private void txtMotivoDeuda_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtMotivoDeuda.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtMotivoDeuda.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtMotivoDeuda.SelectionStart = textoValidado.Length;
            }
        }

        private void txtFuenteOtrosIngresos_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtFuenteOtrosIngresos.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtFuenteOtrosIngresos.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtFuenteOtrosIngresos.SelectionStart = textoValidado.Length;
            }
        }

        private void txtTipoVehiculo_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtTipoVehiculo.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtTipoVehiculo.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtTipoVehiculo.SelectionStart = textoValidado.Length;
            }
        }

        private void txtModeloVehiculo_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string ModeloVehiculoNumerico = Regex.Replace(txtModeloVehiculo.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (ModeloVehiculoNumerico.Length > 4)
            {
                ModeloVehiculoNumerico = ModeloVehiculoNumerico.Substring(0, 4);
            }

            // Asigna el texto limpio al TextBox
            txtModeloVehiculo.Text = ModeloVehiculoNumerico;
            // Coloca el cursor al final del texto
            txtModeloVehiculo.SelectionStart = txtModeloVehiculo.Text.Length;
        }

        private void cmbFlagDeuda_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbFlagDeuda.SelectedItem.ToString() == "Si")
              {
                txtMontoDeuda.Enabled = true;
                txtMotivoDeuda.Enabled = true;

              }
            else
             {
                txtMontoDeuda.Text = "0";
                txtMontoDeuda.Enabled = false;
                txtMotivoDeuda.Text = "----";
                txtMotivoDeuda.Enabled = false;
             }
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cmbVehiculo.SelectedIndex != -1)
            {
                txtTipoVehiculo.Enabled = true;
                txtPlacaVehiculo.Enabled = true;
                txtModeloVehiculo.Enabled = true;
            }
           else
            {

                txtTipoVehiculo.Enabled = false;
                txtPlacaVehiculo.Enabled = false;
                txtModeloVehiculo.Enabled = false;

            }
            
               
        }

        private void txtPlacaVehiculo_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPlacaVehiculo.Text;
            string textoValidado = ValidarTexto1(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPlacaVehiculo.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPlacaVehiculo.SelectionStart = textoValidado.Length;
            }

        }

        private string ValidarTexto1(string texto)
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

        private void txtFlagOtrosIngresos_TextChanged(object sender, EventArgs e)
        {

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
            ExportarDataGridViewAExcel(dtgSocioEconomico);
        }

        private void cmbFlagOtrosIngresos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFlagOtrosIngresos.SelectedItem != null && cmbFlagOtrosIngresos.SelectedItem.ToString() == "Si")
            {
                txtFuenteOtrosIngresos.Enabled = true;
                txtMontoOtrosIngresos.Enabled = true;
            }
            else
            {
                txtFuenteOtrosIngresos.Text = "----";
                txtFuenteOtrosIngresos.Enabled = false;
                txtMontoOtrosIngresos.Text = "0";
                txtMontoOtrosIngresos.Enabled = false;
            }
        }


        private void cmbAgrupacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAgrupacion.SelectedIndex != -1)
            {
                txtDetalleAgrupacion.Enabled = true;
                
            }
            else
            {

                txtDetalleAgrupacion.Enabled = false;
               
            }
        }

        private void cmbVivienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVivienda.SelectedIndex != -1)
            {
                txtPagoVivienda.Enabled = true;

            }
            else
            {
                txtPagoVivienda.Text = "0";
                txtPagoVivienda.Enabled = false;

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
