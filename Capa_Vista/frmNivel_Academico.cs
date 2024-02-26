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
using ClosedXML.Excel;

namespace Capa_Vista
{
    public partial class frmNivel_Academico : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmNivel_Academico()
        {
            InitializeComponent();
            dtmDFecha.Format = DateTimePickerFormat.Custom;
            dtmDFecha.CustomFormat = "dd/MM/yyyy";
            dtmDFecha.KeyPress += dtmDFecha_KeyPress;
            dtmAFecha.Format = DateTimePickerFormat.Custom;
            dtmAFecha.CustomFormat = "dd/MM/yyyy";
            dtmAFecha.KeyPress += dtmAFecha_KeyPress;

            ConfigurarOrdenTabulacion();
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
            this.cmbAcademico.SelectedIndex = -1;
            this.txtEstablecimiento.Text = string.Empty;
            this.txtEspecialidad.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.dtmAFecha.Text = string.Empty;
            this.dtmDFecha.Text = string.Empty;

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
                DateTime dateD = this.dtmDFecha.Value;
                DateTime dateA = this.dtmAFecha.Value;

                if (string.IsNullOrEmpty(this.txtEstablecimiento.Text) ||
                    string.IsNullOrEmpty(this.txtTitulo.Text) ||
                    string.IsNullOrEmpty(this.txtEspecialidad.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtEstablecimiento, "Ingrese una Puesto");
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
                        rpta = nNivelAcademico.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            Convert.ToInt32(this.cmbAcademico.SelectedValue),
                            this.txtEstablecimiento.Text.Trim().ToLower(),
                            dateD,
                            dateA,
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
                            dateD,
                            dateA,
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
            label9.Text = "Total de Registros: " + Convert.ToString(dtgNivelAcademico.Rows.Count);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
            OcultarColumnas();
        }

        private void dtgNivelAcademico_DoubleClick(object sender, EventArgs e)
        {
            if (dtgNivelAcademico.CurrentRow != null)
            {
                if(btnNuevo.Enabled != false)
                {
                    var datos = dtgNivelAcademico.CurrentRow.Cells;

                    string Persona = datos["Persona"].Value?.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                    string Educacion = datos["Academico"].Value?.ToString();
                    int idEducacion = cmbAcademico.FindStringExact(Educacion);
                    cmbAcademico.SelectedIndex = idEducacion;

                   txtId.Text = datos["Id"].Value?.ToString();
                   txtEstablecimiento.Text = datos["ESTABLECIMIENTO"].Value?.ToString();
                   txtTitulo.Text = datos["TITULO_OBTENIDO"].Value?.ToString();
                   txtEspecialidad.Text = datos["ESPECIALIDAD"].Value?.ToString();
                   dtmAFecha.Text = datos["A_FECHA"].Value?.ToString();
                   dtmDFecha.Text = datos["DE_FECHA"].Value?.ToString();
                }
                else
                {
                    MessageBox.Show("No puede editar y crear un nuevo registro a la vez");

                }

            }
        }

        private void dtmDFecha_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtmAFecha_KeyPress(object sender, KeyPressEventArgs e)
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
            cmbAcademico.TabIndex = 2;
            txtEstablecimiento.TabIndex = 3;
            dtmDFecha.TabIndex = 4;
            dtmAFecha.TabIndex = 5;
            txtTitulo.TabIndex = 6;
            txtEspecialidad.TabIndex = 7;
          

        }

        private void txtEstablecimiento_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtEstablecimiento.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtEstablecimiento.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtEstablecimiento.SelectionStart = textoValidado.Length;
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

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtTitulo.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtTitulo.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtTitulo.SelectionStart = textoValidado.Length;
            }
        }

        private void txtEspecialidad_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtEspecialidad.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtEspecialidad.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtEspecialidad.SelectionStart = textoValidado.Length;
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
            ExportarDataGridViewAExcel(dtgNivelAcademico);
        }

        private void label9_Click(object sender, EventArgs e)
        {

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
