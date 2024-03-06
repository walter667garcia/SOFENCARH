using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Capa_Vista
{
    public partial class frmIdioma2 : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmIdioma2()
        {
            InitializeComponent();

            ConfigurarOrdenTabulacion();
            // Deshabilitar la edición del cuadro de texto
            txtDocumento.Enabled = false;


        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto actual en el cuadro de texto
            string texto = txtLectura.Text;

            // Verificar si el último carácter es un dígito o el símbolo '%'
            if (texto.Length > 0 && !char.IsDigit(texto[texto.Length - 1]) && texto[texto.Length - 1] != '%')
            {
                // Eliminar el último carácter si no es un dígito ni el símbolo '%'
                txtLectura.Text = texto.Substring(0, texto.Length - 1);
            }

            // Eliminar cualquier caracter que no sea dígito
            string conversacionNumerico = Regex.Replace(txtLectura.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (conversacionNumerico.Length > 3)
            {
                conversacionNumerico = conversacionNumerico.Substring(0, 3);
            }

            // Asigna el texto limpio al TextBox
            txtLectura.Text = conversacionNumerico + "%";
            // Coloca el cursor al final del texto
            txtLectura.SelectionStart = txtLectura.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto actual en el cuadro de texto
            string texto = txtEscritura.Text;

            // Verificar si el último carácter es un dígito o el símbolo '%'
            if (texto.Length > 0 && !char.IsDigit(texto[texto.Length - 1]) && texto[texto.Length - 1] != '%')
            {
                // Eliminar el último carácter si no es un dígito ni el símbolo '%'
                txtEscritura.Text = texto.Substring(0, texto.Length - 1);
            }

            // Eliminar cualquier caracter que no sea dígito
            string conversacionNumerico = Regex.Replace(txtEscritura.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (conversacionNumerico.Length > 3)
            {
                conversacionNumerico = conversacionNumerico.Substring(0, 3);
            }

            // Asigna el texto limpio al TextBox
            txtEscritura.Text = conversacionNumerico + "%";
            // Coloca el cursor al final del texto
            txtEscritura.SelectionStart = txtEscritura.Text.Length;
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
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgIdioma.Rows.Count);
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
            this.dtgIdioma.DataSource = nIdioma.Buscar(this.txtBuscar.Text);
          
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgIdioma.Rows.Count);
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
                    errorIcono.SetError(txtEscritura, "Ingrese un Escrito");
                    errorIcono.SetError(txtDocumento, "Ingrese un Documento");
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
                        int idIdioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                        string conversacion = txtConversacion.Text;
                        string escritura = txtEscritura.Text;
                        string lectura = txtLectura.Text;
                        string documento = txtDocumento.Text;

                        rpta = nIdioma.Insertar(idPersona, idIdioma, conversacion, escritura, lectura, documento);
                    }
                    else if (this.IsEditar)
                    {
                        int id_Idioma = Convert.ToInt32(txtId_Idioma.Text);
                        int idPersona = Convert.ToInt32(cmbPersona.SelectedValue);
                        int idIdioma = Convert.ToInt32(cmbIdioma.SelectedValue);
                        string conversacion = txtConversacion.Text;
                        string escritura = txtEscritura.Text;
                        string lectura = txtLectura.Text;
                        string documento = txtDocumento.Text;

                        rpta = nIdioma.Actualizar(id_Idioma, idPersona, idIdioma, conversacion, escritura, lectura, documento);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarDpi();
            OcultarColumnas();
            
        }

        private void btnGuardarHome_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                rpta = nIdioma.Insertar(
                           Convert.ToInt32(this.txtIdHome.Text),
                           Convert.ToInt32(this.cmbIdioma.SelectedValue),
                           this.txtConversacion.Text.Trim().ToUpper(),
                           this.txtEscritura.Text.Trim().ToUpper(),
                           this.txtLectura.Text.Trim().ToUpper(),
                           this.txtDocumento.Text.Trim().ToUpper()

                        );
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Se insertó de forma correcta el registro");
                    Mostrar();
                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dtgIdioma_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgIdioma.CurrentRow != null)
            {
                if (btnNuevo.Enabled != false)
                {
                    string Persona = dtgIdioma.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                    string Idioma = dtgIdioma.CurrentRow.Cells["Idioma"].Value.ToString();
                    int idIdioma = cmbIdioma.FindStringExact(Idioma);
                    cmbIdioma.SelectedIndex = idIdioma;

                    this.txtId_Idioma.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Id"].Value);
                    this.txtConversacion.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Conversacion"].Value);
                    this.txtEscritura.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Escritura"].Value);
                    this.txtLectura.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Lectura"].Value);
                    this.txtDocumento.Text = Convert.ToString(this.dtgIdioma.CurrentRow.Cells["Documento"].Value);
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
            cmbIdioma.TabIndex = 2;
            txtConversacion.TabIndex = 3;
            txtEscritura.TabIndex = 4;
            txtLectura.TabIndex = 5;
            txtDocumento.TabIndex = 6;
        }

        private void txtConversacion_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto actual en el cuadro de texto
            string texto = txtConversacion.Text;

            // Verificar si el último carácter es un dígito o el símbolo '%'
            if (texto.Length > 0 && !char.IsDigit(texto[texto.Length - 1]) && texto[texto.Length - 1] != '%')
            {
                // Eliminar el último carácter si no es un dígito ni el símbolo '%'
                txtConversacion.Text = texto.Substring(0, texto.Length - 1);
            }

            // Eliminar cualquier caracter que no sea dígito
            string conversacionNumerico = Regex.Replace(txtConversacion.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (conversacionNumerico.Length > 3)
            {
                conversacionNumerico = conversacionNumerico.Substring(0, 3);
            }

            // Asigna el texto limpio al TextBox
            txtConversacion.Text = conversacionNumerico + "%";
            // Coloca el cursor al final del texto
            txtConversacion.SelectionStart = txtConversacion.Text.Length;
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgIdioma);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgIdioma);
        }

        private string rutaArchivo; // Variable para almacenar la ruta del archivo


        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = openFileDialog.FileName;

                // Mostrar la ruta del archivo en el cuadro de texto
                txtDocumento.Text = rutaArchivo;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string rutaActual = txtDocumento.Text;

            if (!string.IsNullOrEmpty(rutaActual) && System.IO.File.Exists(rutaActual))
            {
                // Abrir el archivo con el visor predeterminado del sistema
                System.Diagnostics.Process.Start(rutaActual);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un archivo válido o la ruta del archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

