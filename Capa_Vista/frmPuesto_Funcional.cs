using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Capa_Vista
{
    public partial class frmPuesto_Funcional : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmPuesto_Funcional()
        {
            InitializeComponent();

            ConfigurarOrdenTabulacion();
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
            cmbRenglon.DisplayMember = "ABRIATURA";
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDpi();
            OcultarColumnas();
        }

       

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtSalario.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtSalario.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtSalario.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtSalario.SelectionStart = txtSalario.Text.Length;
        }

        private void dtgPuesto_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgPuesto.CurrentRow != null)
            {
                if (btnNuevo.Enabled != false)
                {


                    string Seccion = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["Seccion"].Value);
                    int idSeccion = cmbSeccion.FindStringExact(Seccion);
                    cmbSeccion.SelectedIndex = idSeccion;


                    string Funcional = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["P_Nominal"].Value);
                    int idFuncional = cmbPuesto.FindStringExact(Funcional);
                    cmbPuesto.SelectedIndex = idFuncional;

                    string Renglon = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["ABREVIATURA"].Value);
                    int idRenglon = cmbRenglon.FindStringExact(Renglon);
                    cmbRenglon.SelectedIndex = idRenglon;

                    string Cordinacion = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["P_Nominal"].Value);
                    int idcordinacion = cmbcoordinacion.FindStringExact(Cordinacion);
                    cmbcoordinacion.SelectedIndex = idcordinacion;

                    this.txtId.Text = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["id"].Value);
                    this.txtPuesto.Text = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["Puesto"].Value);
                    this.txtSalario.Text = Convert.ToString(this.dtgPuesto.CurrentRow.Cells["SALARIO_BASE"].Value);
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
            txtPuesto.TabIndex = 1;
            cmbRenglon.TabIndex = 2;
            cmbPuesto.TabIndex = 3;
            cmbcoordinacion.TabIndex = 4;
            cmbSeccion.TabIndex = 5;
            txtSalario.TabIndex = 6;
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


        private string ValidarTexto(string texto)
        {
            // Filtra letras (mayúsculas y minúsculas), espacios y puntos.
            string patron = "[a-zA-Z0-9áéíóúÁÉÍÓÚ-ñ ]";

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

        private void cmbcoordinacion_SelectedIndexChanged(object sender, EventArgs e)
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
            ExportarDataGridViewAExcel(dtgPuesto);
        }

        private void cmbRenglon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
