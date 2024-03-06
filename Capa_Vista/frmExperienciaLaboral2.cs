﻿using Capa_Negocio;
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
    public partial class frmExperienciaLaboral2 : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmExperienciaLaboral2()
        {
            InitializeComponent();
            dtmFechaIngreso.Format = DateTimePickerFormat.Custom;
            dtmFechaIngreso.CustomFormat = "dd/MM/yyyy";

            dtmFechaIngreso.KeyPress += dtmFechaIngreso_KeyPress;

            dtmFechaRetiro.Format = DateTimePickerFormat.Custom;
            dtmFechaRetiro.CustomFormat = "dd/MM/yyyy";

            dtmFechaRetiro.KeyPress += dtmFechaRetiro_KeyPress;

            ConfigurarOrdenTabulacion();
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
            this.txtEmpresa.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtJefe.Text = string.Empty;
            this.txtPuesto.Text = string.Empty;
            this.txtSalario.Text = string.Empty;
            this.dtmFechaIngreso.Text = string.Empty;
            this.dtmFechaRetiro.Text = string.Empty;
            this.cmbreferencia.Text = string.Empty;
            this.txtMotivo.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;



        }
        private void Habilitar(bool valor)
        {
            this.cmbPersona.Enabled = valor;
           
            this.txtEmpresa.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtJefe.ReadOnly = !valor;
            this.txtPuesto.ReadOnly = !valor;
            this.txtSalario.ReadOnly = !valor;
            this.txtMotivo.ReadOnly = !valor;
            this.dtmFechaIngreso.Enabled = valor;
            this.dtmFechaRetiro.Enabled = valor;
            this.cmbreferencia.Enabled = valor;
            this.txtDescripcion.ReadOnly = !valor;

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.cmbPersona.Focus();
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




        private void BuscarEXperiencia()
        {
            this.dtgExperienciaLaboral.DataSource = nExperienciaLaboral.Buscar(this.txtBuscar.Text);
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgExperienciaLaboral.Rows.Count);
        }
      
        private void Mostrar()
        {
            this.dtgExperienciaLaboral.DataSource = nExperienciaLaboral.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgExperienciaLaboral.Rows.Count);
        }
        private void OcultarColumnas()
        {
            this.dtgExperienciaLaboral.Columns[0].Visible = false;
        }

        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosRhIdiomas();

            cmbPersona.DataSource = dataSet.Tables["RHPERSONA"];
            cmbPersona.DisplayMember = "Nombre";
            cmbPersona.ValueMember = "IDPERSONA";

            

        }
        private void frmExperienciaLaboral_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.LlenarComboBoxes();
            this.Habilitar(false);
            this.Botones();
            this.Mostrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaIngreso = this.dtmFechaIngreso.Value;
                DateTime fechaRetiro = this.dtmFechaRetiro.Value;

                if (string.IsNullOrEmpty(this.txtEmpresa.Text))
                {
                    MensajeError("Falta ingresar algunos datos Remarcados");
                    errorIcono.SetError(txtEmpresa, "Ingrese una Empresa");
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
                        rpta = nExperienciaLaboral.Insertar(
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.txtEmpresa.Text.Trim().ToUpper(),
                            this.txtTelefono.Text.Trim().ToUpper(),
                            this.txtJefe.Text.Trim().ToUpper(),
                            this.txtPuesto.Text.Trim().ToUpper(),
                            this.txtSalario.Text.Trim().ToUpper(),
                            fechaIngreso,
                            fechaRetiro,
                            this.txtMotivo.Text.Trim().ToUpper(),
                            this.cmbreferencia.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper()
                        );
                    }
                    else
                    {
                        rpta = nExperienciaLaboral.Actualizar(
                            Convert.ToInt32(this.txtId.Text),
                            Convert.ToInt32(this.cmbPersona.SelectedValue),
                            this.txtEmpresa.Text.Trim().ToUpper(),
                            this.txtTelefono.Text.Trim().ToUpper(),
                            this.txtJefe.Text.Trim().ToUpper(),
                            this.txtPuesto.Text.Trim().ToUpper(),
                            this.txtSalario.Text.Trim().ToUpper(),
                            fechaIngreso,
                            fechaRetiro,
                            this.txtMotivo.Text.Trim().ToUpper(),
                            this.cmbreferencia.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper()
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


        private void dtmFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
                
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEXperiencia();
           
        }

        private void dtgExperienciaLaboral_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgExperienciaLaboral.CurrentRow != null)
            {
                if(btnNuevo.Enabled != false)
                {
                    string Persona = dtgExperienciaLaboral.CurrentRow.Cells["Persona"].Value.ToString();
                    int idPersona = cmbPersona.FindStringExact(Persona);
                    cmbPersona.SelectedIndex = idPersona;

                this.txtId.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["ID"].Value);

                this.txtEmpresa.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["EMPRESA"].Value);
                this.dtmFechaIngreso.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["FECHA_INGRESO"].Value);
                this.dtmFechaRetiro.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["FECHA_RETIRO"].Value);
                this.txtTelefono.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["TELEFONO"].Value);
                this.txtJefe.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["JEFE"].Value);
                this.txtPuesto.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["PUESTO"].Value);
                this.txtSalario.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["SALARIO"].Value);
                this.txtMotivo.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["MOTIVO_RETIRO"].Value);
                this.cmbreferencia.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["REFERENCIAS"].Value);
                this.txtDescripcion.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["DESCRIPCION"].Value);
                this.dtmFechaIngreso.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["FECHA_INGRESO"].Value);
                this.dtmFechaRetiro.Text = Convert.ToString(this.dtgExperienciaLaboral.CurrentRow.Cells["FECHA_RETIRO"].Value);
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

        private void dtmFechaIngreso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtmFechaRetiro_KeyPress(object sender, KeyPressEventArgs e)
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
            txtEmpresa.TabIndex = 2;
            txtTelefono.TabIndex = 3;
            txtJefe.TabIndex = 4;
            txtPuesto.TabIndex = 5;
            txtSalario.TabIndex = 6;
            dtmFechaIngreso.TabIndex = 7;
            dtmFechaRetiro.TabIndex = 8;
            txtMotivo.TabIndex = 9;
            cmbreferencia.TabIndex = 10;
            txtDescripcion.TabIndex = 11;
            btnexcel.TabIndex = 12;
        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtEmpresa.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtEmpresa.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtEmpresa.SelectionStart = textoValidado.Length;
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

        private void txtJefe_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtJefe.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtJefe.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtJefe.SelectionStart = textoValidado.Length;
            }
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

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtMotivo.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtMotivo.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtMotivo.SelectionStart = textoValidado.Length;
            }
        }


        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtDescripcion.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtDescripcion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtDescripcion.SelectionStart = textoValidado.Length;
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
            ExportarDataGridViewAExcel(dtgExperienciaLaboral);
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