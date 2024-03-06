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
    public partial class frmFisicoBiologico2 : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmFisicoBiologico2()
        {
            InitializeComponent();

            ConfigurarOrdenTabulacion();
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
       
        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
        }
        private void Limpiar()
        {
            
            this.cmbEmfermedad.Text = string.Empty;
            this.cmbDiabetes.Text = string.Empty;
            this.txtAccidente.Text = string.Empty;
            this.txtOperacion.Text = string.Empty;
            this.txtAlergias.Text = string.Empty;
            this.cmbtratamiento.Text = string.Empty;
            this.txtEspecifique.Text = string.Empty;
            this.cmblentes.Text = string.Empty;
            this.cmbauditivo.Text = string.Empty;
            this.txtDiscapacidad.Text = string.Empty;
            this.cmbdrogas.Text = string.Empty;
            this.cmbalcohol.Text = string.Empty;
            this.cmbfuma.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtEstatura.Text = string.Empty;
            this.cmbsangre.Text = string.Empty;
            this.txtPasatienpo.Text = string.Empty;
            this.txtDeporte.Text = string.Empty;

        }

        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;

            this.cmbEmfermedad.Enabled = valor;
            this.cmbDiabetes.Enabled = valor;
            this.txtAccidente.ReadOnly = !valor;
            this.txtOperacion.ReadOnly = !valor;
            this.txtAlergias.ReadOnly = !valor;
            this.cmbtratamiento.Enabled = valor;
            this.txtEspecifique.ReadOnly = !valor;
            this.cmblentes.Enabled = valor;
            this.cmbauditivo.Enabled = valor;
            this.txtDiscapacidad.ReadOnly = !valor;
            this.cmbdrogas.Enabled = valor;
            this.cmbalcohol.Enabled = valor;
            this.cmbfuma.Enabled = valor;
            this.txtPeso.ReadOnly = !valor;
            this.txtEstatura.ReadOnly = !valor;
            this.cmbsangre.Enabled = valor;
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
                if (string.IsNullOrEmpty(this.cmbDiabetes.Text) || string.IsNullOrEmpty(this.cmbDiabetes.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(cmbPersona, "Ingrese un Nombre");
                    errorIcono.SetError(cmbDiabetes, "Si tienes diabetes, indica si");

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
                        rpta = nFisicoBiologico.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.cmbEmfermedad.Text.Trim().ToUpper(),
                            this.cmbDiabetes.Text.Trim().ToUpper(),
                            this.txtAccidente.Text.Trim().ToUpper(),
                            this.txtOperacion.Text.Trim().ToUpper(),
                            this.txtAlergias.Text.Trim().ToUpper(),
                            this.cmbtratamiento.Text.Trim().ToUpper(),
                            this.txtEspecifique.Text.Trim().ToUpper(),
                            this.cmblentes.Text.Trim().ToUpper(),
                            this.cmbauditivo.Text.Trim().ToUpper(),
                            this.txtDiscapacidad.Text.Trim().ToUpper(),
                            this.cmbdrogas.Text.Trim().ToUpper(),
                            this.cmbalcohol.Text.Trim().ToUpper(),
                            this.cmbfuma.Text.Trim().ToUpper(),
                            this.txtPeso.Text.Trim().ToUpper(),
                            this.txtEstatura.Text.Trim().ToUpper(),
                            this.cmbsangre.Text.Trim().ToUpper(),
                            this.txtPasatienpo.Text.Trim().ToUpper(),
                            this.txtDeporte.Text.Trim().ToUpper()
                        );
                    }
                    else if (this.IsEditar)
                    {
                        rpta = nFisicoBiologico.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.cmbEmfermedad.Text.Trim().ToUpper(),
                            this.cmbDiabetes.Text.Trim().ToUpper(),
                            this.txtAccidente.Text.Trim().ToUpper(),
                            this.txtOperacion.Text.Trim().ToUpper(),
                            this.txtAlergias.Text.Trim().ToUpper(),
                            this.cmbtratamiento.Text.Trim().ToUpper(),
                            this.txtEspecifique.Text.Trim().ToUpper(),
                            this.cmblentes.Text.Trim().ToUpper(),
                            this.cmbauditivo.Text.Trim().ToUpper(),
                            this.txtDiscapacidad.Text.Trim().ToUpper(),
                            this.cmbdrogas.Text.Trim().ToUpper(),
                            this.cmbalcohol.Text.Trim().ToUpper(),
                            this.cmbfuma.Text.Trim().ToUpper(),
                            this.txtPeso.Text.Trim().ToUpper(),
                            this.txtEstatura.Text.Trim().ToUpper(),
                            this.cmbsangre.Text.Trim().ToUpper(),
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
            OcultarColumnas();
            
        }

        private void dtgBiologicos_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgBiologicos.CurrentRow != null)
            {
                if (btnNuevo.Enabled != false)
                {
                    string Persona = dtgBiologicos.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                    this.cmbEmfermedad.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ENFERMEDAD"].Value);
                    this.cmbDiabetes.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DIABETES"].Value);
                    this.txtAccidente.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ACCIDENTE"].Value);
                    this.txtOperacion.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["OPERACION"].Value);
                    this.txtAlergias.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ALERGIAS"].Value);
                    this.cmbtratamiento.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["TRATAMIENTO"].Value);
                    this.txtEspecifique.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ESPECIFIQUE"].Value);
                    this.cmblentes.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["LENTES"].Value);
                    this.cmbauditivo.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["AUDITIVO"].Value);
                    this.txtDiscapacidad.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DISCAPACIDAD"].Value);
                    this.cmbdrogas.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DROGAS"].Value);
                    this.cmbalcohol.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ALCOHOL"].Value);
                    this.cmbfuma.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["FUMA"].Value);
                    this.txtPeso.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["PESO"].Value);
                    this.txtEstatura.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["ESTATURA"].Value);
                    this.cmbsangre.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["SANGRE"].Value);
                    this.txtPasatienpo.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["PASATIEMPOS"].Value);
                    this.txtDeporte.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["DEPORTES"].Value);
                    this.txtId.Text = Convert.ToString(this.dtgBiologicos.CurrentRow.Cells["IDFISICABIO"].Value);
                }
                else
                {
                    MessageBox.Show("NO puede editar este registro porque esta selecionado uno registro");
                }
            }
        }

        private void tabInicio_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarOrdenTabulacion()
        {
            // Establecer el orden de tabulación para los TextBox
            cmbPersona.TabIndex = 1;
            cmbEmfermedad.TabIndex = 2;
            cmbDiabetes.TabIndex = 3;
            txtAccidente.TabIndex = 4;
            txtOperacion.TabIndex = 5;
            txtAlergias.TabIndex = 6;
            cmbtratamiento.TabIndex = 7;
            txtEspecifique.TabIndex = 8;
            cmblentes.TabIndex = 9;
            cmbauditivo.TabIndex = 10;
            txtDiscapacidad.TabIndex = 11;
            cmbdrogas.TabIndex = 12;
            cmbalcohol.TabIndex = 13;
            cmbfuma.TabIndex = 14;
            txtPeso.TabIndex = 15;
            txtEstatura.TabIndex = 16;
            cmbsangre.TabIndex = 17;
            txtPasatienpo.TabIndex = 18;
            txtDeporte.TabIndex = 19;
            btnGuardar.TabIndex = 20;
            btnexcel.TabIndex = 21;

        }

        private void txtPasatienpo_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPasatienpo.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPasatienpo.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPasatienpo.SelectionStart = textoValidado.Length;
            }
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

       

        private void txtAccidente_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtAccidente.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtAccidente.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtAccidente.SelectionStart = textoValidado.Length;
            }
        }

        private void txtOperacion_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtOperacion.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtOperacion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtOperacion.SelectionStart = textoValidado.Length;
            }
        }

        private void txtAlergias_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtAlergias.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtAlergias.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtAlergias.SelectionStart = textoValidado.Length;
            }
        }

        

        private void txtEspecifique_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtEspecifique.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtEspecifique.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtEspecifique.SelectionStart = textoValidado.Length;
            }
        }

      

        

        private void txtDiscapacidad_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtDiscapacidad.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtDiscapacidad.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtDiscapacidad.SelectionStart = textoValidado.Length;
            }
        }

       

       

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ValidarPeso(txtPeso);
        }

        private void ValidarPeso(TextBox textBox)
        {
            string textoOriginal = textBox.Text;

            // Limpiar el texto de cualquier carácter no permitido y mantener solo números.
            string textoNumerico = LimpiarNoNumericos(textoOriginal);

            // Limitar a tres caracteres numéricos.
            if (textoNumerico.Length > 3)
            {
                textoNumerico = textoNumerico.Substring(0, 3);
            }

            // Agregar "LBS" al final del texto.
            string textoFinal = textoNumerico + " LBS";

            // Actualizar el TextBox solo si ha habido un cambio.
            if (textoOriginal != textoFinal)
            {
                textBox.Text = textoFinal;
                // Establecer el cursor al final del texto.
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private string LimpiarNoNumericos(string texto)
        {
            // Eliminar caracteres no numéricos.
            string patron = @"[^\d]";
            return System.Text.RegularExpressions.Regex.Replace(texto, patron, "");
        }




        private void txtDeporte_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtDeporte.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtDeporte.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtDeporte.SelectionStart = textoValidado.Length;
            }
        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {
            ValidarEstatura(txtEstatura);
        }

        private void ValidarEstatura(TextBox textBox)
        {
            string textoOriginal = textBox.Text;

            // Limpiar el texto de cualquier carácter no permitido y mantener solo números.
            string textoNumerico = LimpiarNoNumericos1(textoOriginal);

            // Limitar a tres caracteres numéricos.
            if (textoNumerico.Length > 3)
            {
                textoNumerico = textoNumerico.Substring(0, 3);
            }

            // Agregar "MTS" al final del texto.
            string textoFinal = textoNumerico + " MTS";

            // Insertar un punto después del primer número y dos números después del punto.
            if (textoNumerico.Length >= 1)
            {
                textoFinal = textoFinal.Insert(1, ".");
            }

            // Actualizar el TextBox solo si ha habido un cambio.
            if (textoOriginal != textoFinal)
            {
                textBox.Text = textoFinal;
                // Establecer el cursor al final del texto.
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private string LimpiarNoNumericos1(string texto)
        {
            // Eliminar caracteres no numéricos.
            string patron = @"[^\d]";
            return System.Text.RegularExpressions.Regex.Replace(texto, patron, "");
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
            ExportarDataGridViewAExcel(dtgBiologicos);
        }

        private void cmbEmfermedad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDiabetes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtratamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbtratamiento.SelectedItem.ToString() == "Si")
            {
                txtEspecifique.Enabled = true;

            }
            else
            {
                txtEspecifique.Text = "-------";
                txtEspecifique.Enabled = false;
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
