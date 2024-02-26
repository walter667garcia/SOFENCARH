using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Capa_Vista
{
    public partial class frmLocalizacion : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmLocalizacion()
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

            cmbLocalizacion.DataSource = dataSet.Tables["TyLocalizacion"];
            cmbLocalizacion.DisplayMember = "Descripcion";
            cmbLocalizacion.ValueMember = "IdLOcalizacion";




        }


        public void cargar(string id, string nombre, string nombre1, string nombre2, string nombre3)
        {
            // Establecer valores en los controles correspondientes
           

            // Puedes agregar más lógica de carga si es necesario

            
        }


        private void frmLocalizacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.LlenarComboBoxes();
            this.Habilitar(false);
            this.Botones();
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
            this.cmbLocalizacion.SelectedIndex = -1;
            this.txtLocalizacion.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.cmbLocalizacion.Enabled = valor;
            this.cmbPersona.Enabled = valor;
            this.txtLocalizacion.ReadOnly = !valor;  
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtLocalizacion.Focus();
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
        private void Mostrar()
        {
            this.dtgLocalizacion.DataSource = nLocalizacion.MostrarLocalizaciones();
            OcultarColumnas();
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgLocalizacion.Rows.Count);
        }

        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgLocalizacion.Columns.Count > 0)
                {
                    this.dtgLocalizacion.Columns[0].Visible = false;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtLocalizacion.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtLocalizacion, "Ingrese una Localizacion");
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
                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idLocalizacion = Convert.ToInt32(cmbLocalizacion.SelectedValue);
                        string localizacion = txtLocalizacion.Text;

                        rpta = nLocalizacion.InsertarLocalizacion(idPersona, idLocalizacion, localizacion);
                    }
                    else if (this.IsEditar)
                    {
                        int id = Convert.ToInt32(txtId.Text);
                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idLocalizacion = Convert.ToInt32(cmbLocalizacion.SelectedValue);
                        string localizacion = txtLocalizacion.Text;

                        rpta = nLocalizacion.ActualizarLocalizacion(id, idPersona, idLocalizacion, localizacion);
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
        private void BuscarLocalizacion()
        {
            this.dtgLocalizacion.DataSource = nLocalizacion.BuscarLocalizacion(this.txtBuscar.Text);
            lbltotal.Text = "Total de Registros: " + Convert.ToString(dtgLocalizacion.Rows.Count);

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarLocalizacion();
            OcultarColumnas();
        }

       

       

        private void btnGuardarHome_Click(object sender, EventArgs e)
        {
        }

        private void dtgLocalizacion_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgLocalizacion.CurrentRow != null)
            {
                if (btnNuevo.Enabled != false)
                {
                    string Persona = dtgLocalizacion.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex= idPersona;

                    string Localizacion = this.dtgLocalizacion.CurrentRow.Cells["Descripcion"].Value.ToString();
                    int idLocalizacion = cmbLocalizacion.FindStringExact(Localizacion);
                    cmbLocalizacion.SelectedIndex = idLocalizacion;

                    this.txtId.Text = Convert.ToString(this.dtgLocalizacion.CurrentRow.Cells["id"].Value);
                    this.txtLocalizacion.Text = Convert.ToString(this.dtgLocalizacion.CurrentRow.Cells["Localizacion"].Value);
                }
                else
                {
                    MessageBox.Show("No puede editar y crear un nuevo registro a la vez");
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
            cmbLocalizacion.TabIndex = 2;
            txtLocalizacion.TabIndex = 3;
        }

        private void txtLocalizacion_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtLocalizacion.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtLocalizacion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtLocalizacion.SelectionStart = textoValidado.Length;
            }
        }

        private string ValidarTexto(string texto)
        {
            // Patrón para filtrar letras (mayúsculas y minúsculas), números, espacios, puntos, guiones, comas y arrobas.
            string patron = "[a-zA-Z0-9áéíóúÁÉÍÓÚ-ñ .,@-]";

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
            ExportarDataGridViewAExcel(dtgLocalizacion);
        }

        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
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
