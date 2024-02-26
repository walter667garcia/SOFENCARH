using Capa_Negocio;
using Microsoft.Ajax.Utilities;
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
    public partial class frmDatosAdicionales : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmDatosAdicionales()
        {
            InitializeComponent();

            ConfigurarOrdenTabulacion();
        }

        public void Buscar()
        {
            this.dtgDatosAdicionales.DataSource = nDatosAdicionales.Buscar(this.txtBuscar.Text);
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgDatosAdicionales.Rows.Count);

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
            this.txtId.Text = string.Empty;
            this.txtEmergencia.Text = string.Empty;
            this.txtParentesco.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        }

        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;
            this.txtEmergencia.ReadOnly = !valor;
            this.txtParentesco.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
     
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtId.Text = string.Empty;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtId.Focus();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema ENCA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
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


        private void OcultarColumnas()
        {
            this.dtgDatosAdicionales.Columns[0].Visible = false;
        }
        private void Mostrar()
        {
            this.dtgDatosAdicionales.DataSource = nDatosAdicionales.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgDatosAdicionales.Rows.Count);
        }

        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

           cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
           cmbPersona.DisplayMember = "Nombre";
           cmbPersona.ValueMember = "IDPERSONA";

           

        }
        private void frmDatosAdicionales_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.LlenarComboBoxes();
            this.Habilitar(false);
            this.Botones();
            this.Mostrar();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtEmergencia.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtEmergencia, "Ingrese un nombre");
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
                        rpta = nDatosAdicionales.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.txtEmergencia.Text.Trim().ToUpper(),
                            this.txtParentesco.Text.Trim().ToUpper(),
                            this.txtTelefono.Text.Trim().ToUpper()
                        );
                    }
                    else
                    {
                        rpta = nDatosAdicionales.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.txtEmergencia.Text.Trim().ToUpper(),
                            this.txtParentesco.Text.Trim().ToUpper(),
                            this.txtTelefono.Text.Trim().ToUpper()
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

        
        private void btnGuardarHome_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                rpta = nDatosAdicionales.Insertar(
                           Convert.ToInt32(this.txtIdHome.Text),
                           this.txtEmergencia.Text.Trim().ToUpper(),
                           this.txtParentesco.Text.Trim().ToUpper(),
                           this.txtTelefono.Text.Trim().ToUpper()
                        );
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk( "Se insertó de forma correcta el registro" );
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


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
                Buscar();
        }

        private void dtgDatosAdicionales_DoubleClick(object sender, EventArgs e)
        {
    
            if (this.dtgDatosAdicionales.CurrentRow != null)
            {
                if(btnNuevo.Enabled != false)
                {


                    string Persona = dtgDatosAdicionales.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                    this.txtId.Text = Convert.ToString(this.dtgDatosAdicionales.CurrentRow.Cells["IDDATOSADI"].Value);
                this.txtEmergencia.Text = Convert.ToString(this.dtgDatosAdicionales.CurrentRow.Cells["EMERGENCIAS"].Value);
                this.txtParentesco.Text = Convert.ToString(this.dtgDatosAdicionales.CurrentRow.Cells["PARENTESCO"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dtgDatosAdicionales.CurrentRow.Cells["TELEFONO"].Value);
           
                
                }
                else
                {
                    MessageBox.Show("No puede editar y crear un nuevo registro a la vez");
                }
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string TelefonoNumerico = Regex.Replace(txtTelefono.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (TelefonoNumerico.Length > 8)
            {
                TelefonoNumerico = TelefonoNumerico.Substring(0, 8);
            }

            // Asigna el texto limpio al TextBox
            txtTelefono.Text = TelefonoNumerico;
            // Coloca el cursor al final del texto
            txtTelefono.SelectionStart = txtTelefono.Text.Length;

        }


        private void ConfigurarOrdenTabulacion()
        {
            // Establecer el orden de tabulación para los TextBox
            cmbPersona.TabIndex = 0;
            txtEmergencia.TabIndex = 1;
            txtParentesco.TabIndex = 2;
            txtTelefono.TabIndex = 3;
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

        private void txtEmergencia_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtEmergencia.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtEmergencia.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtEmergencia.SelectionStart = textoValidado.Length;
            }
        }

        private void txtParentesco_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtParentesco.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtParentesco.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtParentesco.SelectionStart = textoValidado.Length;
            }
        }

        private void lbpersona_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
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
            ExportarDataGridViewAExcel(dtgDatosAdicionales);
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
