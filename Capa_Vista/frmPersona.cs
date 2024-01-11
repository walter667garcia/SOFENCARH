using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Vista
{
    public partial class frmPersona : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmPersona()
        {
            InitializeComponent();
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void OcultarColumnas()
        {
            try
            {
                // Verificar si hay al menos una columna
                if (this.dtgPersona.Columns.Count > 0)
                {
                    this.dtgPersona.Columns[0].Visible = false;
                    this.dtgPersona.Columns[9].Visible = false;
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

        private void Mostrar()
        {
           
              this.dtgPersona.DataSource = nPersona.MostrarPersonas();
                 this.OcultarColumnas();
            Imagen();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgPersona.Rows.Count);
        }

        private void Imagen()
        {
            DataGridViewImageColumn image = dtgPersona.Columns["Foto"] as DataGridViewImageColumn;
            if (image != null)
            {
                image.ImageLayout = DataGridViewImageCellLayout.Zoom;
                image.DefaultCellStyle.NullValue = null;
            }
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();

            this.Habilitar(false);
            this.Botones();
          this.LlenarComboBoxes();
         

            this.letras(txtPnombre.Text);
        }

        private void LlenarComboBoxes()
        {
            nDatos negocio = new nDatos();
            DataSet dataSet = negocio.CargarDatosPersona();

            // Asignar los datos a los ComboBox específicos
            cmbReligion.DataSource = dataSet.Tables["TYRELIGION"];
            cmbReligion.DisplayMember = "RELIGION";
            cmbReligion.ValueMember = "ID_RELIGION";

            cmbGenero.DataSource = dataSet.Tables["TYGENERO"];
            cmbGenero.DisplayMember = "GENERO";
            cmbGenero.ValueMember = "ID_GENERO";

            cmbEtnia.DataSource = dataSet.Tables["TYETNIA"];
            cmbEtnia.DisplayMember = "ETNIA";
            cmbEtnia.ValueMember = "ID_ETNIA";

            cmbEstado.DataSource = dataSet.Tables["TYESTADOCIVIL"];
            cmbEstado.DisplayMember = "ESTADO_CIVIL";
            cmbEstado.ValueMember = "ID_ESTADO_CIVIL";

            cmbMunicipio.DataSource = dataSet.Tables["TYMUNICIPIO"];
            cmbMunicipio.DisplayMember = "MUNICIPIO";
            cmbMunicipio.ValueMember = "ID_MUNICIPIO";

        }

        private Image imagenActual; // Variable para almacenar la imagen actual del PictureBox
        // Guarda la imagen actual antes de cargar una nueva imagen
        

  
    private void button5_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();

    // Configura el filtro para permitir solo imágenes
    ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";
    DialogResult rs = ofd.ShowDialog();

    if (rs == DialogResult.OK)
    {
                // Guarda la imagen actual antes de cargar una nueva imagen
                imagenActual = pcbFoto.Image;

                // Verifica si el archivo seleccionado es una imagen
                string extension = Path.GetExtension(ofd.FileName).ToLower();
        if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".gif" || extension == ".bmp")
        {
            pcbFoto.Image = Image.FromFile(ofd.FileName);
        }
        else
        {
            // Muestra un mensaje de error si el archivo no es una imagen
            MessageBox.Show("Por favor, selecciona un archivo de imagen válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Restaura la imagen anterior
            pcbFoto.Image = imagenActual;
        }
    }
}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPnombre.Focus();
            LimpiarImagen();
        }
        private void LimpiarImagen()
        {
            pcbFoto.Image = null;
        }
        private void Habilitar(bool valor)
        {
            

            this.txtPnombre.ReadOnly = !valor;
            this.txtSnombre.ReadOnly = !valor;
            this.txtTnombre.ReadOnly = !valor;
            this.txtPapellido.ReadOnly = !valor;
            this.txtSapellido.ReadOnly = !valor;
            this.txtTapellido.ReadOnly = !valor;
            this.txtEdad.ReadOnly = !valor;
            this.txtPretencion.ReadOnly = !valor;
            this.txtNacion.ReadOnly = !valor;
            this.txtNacionalidad.ReadOnly = !valor;
            this.cmbEstado.Enabled = valor;
            this.cmbGenero.Enabled = valor;
            this.cmbEtnia.Enabled = valor;
            this.cmbReligion.Enabled = valor;
            this.cmbMunicipio.Enabled = valor;
            this.btnFoto.Enabled=valor;
            this.dtmFecha.Enabled = valor;
            this.txtLicencia.ReadOnly = !valor;
       
            this.txtDPI.ReadOnly = !valor;
            this.txtIgss.ReadOnly = !valor;
            this.txtNIT.ReadOnly = !valor;
            this.txtPnombre.ReadOnly = !valor;
            this.txtNIT.ReadOnly = !valor;
        }

        private void ReemplazarImagen(PictureBox origen, PictureBox destino)
        {
          
                // Copia la imagen del PictureBox de origen al PictureBox de destino
                origen.Image = new Bitmap(destino.Image);
            
        }
        private void Limpiar()
        {
            this.txtPnombre.Text = string.Empty;
            this.txtSnombre.Text = string.Empty;
            this.txtTnombre.Text = string.Empty;
            this.txtPapellido.Text = string.Empty;
            this.txtSapellido.Text = string.Empty;
            this.txtTapellido.Text = string.Empty;
            this.txtEdad.Text = string.Empty;
            this.txtPretencion.Text = string.Empty;
            this.cmbEstado.SelectedIndex = -1;  
            this.txtNacion.Text = string.Empty;
            this.dtmFecha.Value = DateTime.Today;
            this.cmbGenero.SelectedIndex = -1;  
            this.cmbEtnia.SelectedIndex = -1;  
            this.txtNacionalidad.Text = string.Empty;
            this.cmbReligion.SelectedIndex = -1;  
            this.txtDPI.Text = string.Empty;
            this.cmbMunicipio.SelectedIndex = -1;  
            this.txtIgss.Text = string.Empty;
            this.txtNIT.Text = string.Empty;
            this.txtLicencia.Text = string.Empty;
            this.txtTipoLicencia.Text = string.Empty;
            ReemplazarImagen(pcbFoto, pcbFoto2);

        }
        private void Botones()
        {
            this.btnNuevo.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnGuardar.Enabled = this.IsNuevo || this.IsEditar;
            this.btnEditar.Enabled = !this.IsNuevo && !this.IsEditar;
            this.btnCancelar.Enabled = this.IsNuevo || this.IsEditar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

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
                using (MemoryStream ms = new MemoryStream())
                {
                    pcbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    DateTime date = this.dtmFecha.Value;

                    if (string.IsNullOrEmpty(this.txtDPI.Text) || string.IsNullOrEmpty(this.txtIgss.Text))
                    {
                        MensajeError("Falta ingresar algunos datos Remarcados");
                        errorIcono.SetError(txtPnombre, "Ingrese un Nombre");
                        errorIcono.SetError(txtSapellido, "Ingrese Código Postal");
                    }
                    else
                    {
                        string rpta = "";
                        if (this.IsNuevo)
                        {
                            rpta = nPersona.InsertarPersona(
                                this.txtPnombre.Text.Trim().ToUpper(),
                                this.txtSnombre.Text.Trim().ToUpper(),
                                this.txtTnombre.Text.Trim().ToUpper(),
                                this.txtPapellido.Text.Trim().ToUpper(),
                                this.txtSapellido.Text.Trim().ToUpper(),
                                this.txtTapellido.Text.Trim().ToUpper(),
                                this.txtEdad.Text.Trim().ToUpper(),
                                this.txtPretencion.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbEstado.SelectedValue),
                                this.txtNacion.Text.Trim().ToUpper(),
                                date,
                                Convert.ToInt32(this.cmbGenero.SelectedValue),
                                Convert.ToInt32(this.cmbEtnia.SelectedValue),
                                this.txtNacionalidad.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbReligion.SelectedValue),
                                this.txtDPI.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbMunicipio.SelectedValue),
                                this.txtIgss.Text.Trim().ToUpper(),
                                this.txtNIT.Text.Trim().ToUpper(),
                                ms.ToArray(), // Reemplaza ms.GetBuffer() con ms.ToArray()
                                this.txtLicencia.Text.Trim().ToUpper(),
                                this.txtTipoLicencia.Text.Trim().ToUpper());
                        }
                        else if (this.IsEditar)
                        {
                            byte[] nuevaImagen;
                            using (MemoryStream msNuevaImagen = new MemoryStream())
                            {
                                // Reemplaza pcbNuevaFoto con el PictureBox que contiene la nueva imagen
                                pcbFoto.Image.Save(msNuevaImagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                                nuevaImagen = msNuevaImagen.ToArray();
                            }

                            rpta = nPersona.EditarPersona(
                                Convert.ToInt32(this.txtIdPersona.Text),
                                this.txtPnombre.Text.Trim().ToUpper(),
                                this.txtSnombre.Text.Trim().ToUpper(),
                                this.txtTnombre.Text.Trim().ToUpper(),
                                this.txtPapellido.Text.Trim().ToUpper(),
                                this.txtSapellido.Text.Trim().ToUpper(),
                                this.txtTapellido.Text.Trim().ToUpper(),
                                this.txtEdad.Text.Trim().ToUpper(),
                                this.txtPretencion.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbEstado.SelectedValue),
                                this.txtNacion.Text.Trim().ToUpper(),
                                date,
                                Convert.ToInt32(this.cmbGenero.SelectedValue),
                                Convert.ToInt32(this.cmbEtnia.SelectedValue),
                                this.txtNacionalidad.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbReligion.SelectedValue),
                                this.txtDPI.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbMunicipio.SelectedValue),
                                this.txtIgss.Text.Trim().ToUpper(),
                                this.txtNIT.Text.Trim().ToUpper(),
                                nuevaImagen, // Utiliza la nueva imagen en lugar de ms.ToArray()
                                this.txtLicencia.Text.Trim().ToUpper(),
                                this.txtTipoLicencia.Text.Trim().ToUpper());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // También puedes registrar la excepción en un archivo de registro.
            }
        }

        private void BuscarPersona()
        {
            this.dtgPersona.DataSource = nPersona.Buscar(this.txtBuscar.Text);

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgPersona.Rows.Count - 1);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPersona();
            OcultarColumnas();
        }

        private void dtgPersona_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgPersona.CurrentRow != null)
            {
                this.txtIdPersona.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Id"].Value);
                this.txtPnombre.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["P_NOMBRE"].Value);
                this.txtSnombre.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["S_NOMBRE"].Value);
                this.txtTnombre.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["T_NOMBRE"].Value);
                this.txtPapellido.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["P_APELLIDO"].Value);
                this.txtSapellido.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["S_APELLIDO"].Value);
                this.txtTapellido.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["C_APELLIDO"].Value);
                this.txtEdad.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["EDAD"].Value);
                this.txtPretencion.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["PRETENCION_SALARIO"].Value);
                 this.txtNacion.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["L_NACIMIENTO"].Value);
                   this.txtNacionalidad.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["NACIONALIDAD"].Value);
                   this.txtDPI.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["DPI"].Value);
                  this.txtIgss.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["IGSS"].Value);
                this.txtNIT.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["NIT"].Value);
                byte[] datosBinarios = this.dtgPersona.CurrentRow.Cells["Foto"].Value as byte[];

                if (datosBinarios != null && datosBinarios.Length > 0)
                {
                    // Asignar la imagen al PictureBox directamente desde los datos binarios
                    pcbFoto.Image = Image.FromStream(new MemoryStream(datosBinarios));
                }
                else
                {
                    MessageBox.Show("Los datos binarios de la imagen son nulos o vacíos.");
                }
                this.txtLicencia.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["LICENCIA"].Value);
                this.txtTipoLicencia.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["TIPO_LICENCIA"].Value);
                this.tabMantenimiento.SelectedIndex = 1;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtIdPersona.Text))
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

        private void txtDPI_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string dpiNumerico = Regex.Replace(txtDPI.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (dpiNumerico.Length > 13)
            {
                dpiNumerico = dpiNumerico.Substring(0, 13);
            }

            // Asigna el texto limpio al TextBox
            txtDPI.Text = dpiNumerico;
            // Coloca el cursor al final del texto
            txtDPI.SelectionStart = txtDPI.Text.Length;
        }

        private void txtNIT_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string nitNumero = Regex.Replace(txtNIT.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (nitNumero.Length > 12)
            {
                nitNumero = nitNumero.Substring(0, 12);
            }

            // Asigna el texto limpio al TextBox
            txtNIT.Text = nitNumero;
            // Coloca el cursor al final del texto
            txtNIT.SelectionStart = txtNIT.Text.Length;
        }

        private void txtIgss_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string iggsNumero = Regex.Replace(txtIgss.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (iggsNumero.Length > 12)
            {
                iggsNumero = iggsNumero.Substring(0, 12);
            }

            // Asigna el texto limpio al TextBox
            txtIgss.Text = iggsNumero;
            // Coloca el cursor al final del texto
            txtIgss.SelectionStart = txtIgss.Text.Length;
        }

        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string lcNumero = Regex.Replace(txtLicencia.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (lcNumero.Length > 9)
            {
                lcNumero = lcNumero.Substring(0, 9);
                
            }

            if (lcNumero.Length == 9)
            {
                txtTipoLicencia.Enabled = true;

            }
            else
            {
                txtTipoLicencia.Enabled = false;
            }


            // Asigna el texto limpio al TextBox
            txtLicencia.Text = lcNumero;
            // Coloca el cursor al final del texto
            txtLicencia.SelectionStart = txtLicencia.Text.Length;
        }

        private void txtPretencion_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string Q = Regex.Replace(txtPretencion.Text, @"[^\d]", "");

            // Limita a 9 caracteres
            if (Q.Length > 9)
            {
                Q = Q.Substring(0, 9);
            }

            // Formatea el número como moneda local (Quetzal en Guatemala)
            if (long.TryParse(Q, out long numero))
            {
                txtPretencion.Text = numero.ToString("C0", new CultureInfo("es-GT"));

            }
            else
            {
                txtPretencion.Text = "";  // Si no se puede convertir, se deja en blanco
            }

            // Coloca el cursor al final del texto
            txtPretencion.SelectionStart = txtPretencion.Text.Length;
        }

        private void dtmFecha_ValueChanged(object sender, EventArgs e)
        {
            // Calcula la edad
            DateTime fechaNacimiento = dtmFecha.Value;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Verifica si aún no ha pasado el cumpleaños de este año
            if (DateTime.Today < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            // Asigna la edad al campo correspondiente
            txtEdad.Text = edad.ToString();
        }

        private void txtPnombre_TextChanged(object sender, EventArgs e)
        {
            letras(txtPnombre.Text);
        }

        private void letras(string texto)
        {
            // Verificar si el texto contiene solo letras y espacios en blanco
            if (!Regex.IsMatch(texto, "^[a-zA-ZáéíóúüñÁÉÍÓÚÜÑ ]*$"))
            {
               MessageBox.Show("Solo se permiten letras y espacios en blanco en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSnombre_TextChanged(object sender, EventArgs e)
        {

            letras(txtSnombre.Text);
        }

        private void txtTnombre_TextChanged(object sender, EventArgs e)
        {
            letras(txtTnombre.Text);
        }

        private void txtPapellido_TextChanged(object sender, EventArgs e)
        {
            letras(txtPapellido.Text);
        }

        private void txtSapellido_TextChanged(object sender, EventArgs e)
        {
            letras(txtSapellido.Text);
        }

        private void txtTapellido_TextChanged(object sender, EventArgs e)
        {
            letras(txtTapellido.Text);
        }

        private void txtNacion_TextChanged(object sender, EventArgs e)
        {
            letras(txtNacion.Text);
        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {
            letras(txtNacionalidad.Text);
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtPnombre.Focus();
        }


        private byte[] ObtenerImagenComoBytes(Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                   DateTime date = this.dtmFecha.Value;
                byte[] imagenBytes = pcbFoto.Image != null ? ObtenerImagenComoBytes(pcbFoto.Image) : null;


                if (string.IsNullOrEmpty(this.txtPnombre.Text) 
                        || string.IsNullOrEmpty(this.txtPapellido.Text)
                        || string.IsNullOrEmpty(this.txtNacionalidad.Text)
                        || string.IsNullOrEmpty(this.txtDPI.Text)
                        || string.IsNullOrEmpty(this.txtNIT.Text)
                        || string.IsNullOrEmpty(this.txtIgss.Text)
                        || string.IsNullOrEmpty(this.dtmFecha.Text)
                        || string.IsNullOrEmpty(this.cmbEstado.Text)
                        || string.IsNullOrEmpty(this.cmbGenero.Text)
                        || string.IsNullOrEmpty(this.cmbEtnia.Text)
                        || string.IsNullOrEmpty(this.cmbReligion.Text)
                        || string.IsNullOrEmpty(this.cmbMunicipio.Text)


                        )
                    {
                        MensajeError("Falta ingresar algunos datos Remarcados");
                        errorIcono.SetError(txtPnombre, "Ingrese un Nombre");
                        errorIcono.SetError(txtPapellido, "Ingrese un Apellido");
                        errorIcono.SetError(txtNacionalidad, "Ingrese su Nacionalidad");
                        errorIcono.SetError(txtDPI, "Ingrese su DPI");
                        errorIcono.SetError(txtNIT, "Ingrese su Nit");
                        errorIcono.SetError(txtIgss, "Ingrese su No. IGSS");
                        errorIcono.SetError(dtmFecha, "Ingrese su fecha de Nacimiento");
                        errorIcono.SetError(cmbEstado, "Selecione su estado civil");
                        errorIcono.SetError(cmbGenero, "Selecione su genero");
                        errorIcono.SetError(cmbEtnia, "Selecione su Etnia");
                        errorIcono.SetError(cmbReligion, "Seleciones du religion");
                        errorIcono.SetError(cmbMunicipio, "Selecione su Municipio");
                    }
                    else 
                    {


                        string rpta = "";
                        if (this.IsNuevo)
                        {
                            rpta = nPersona.InsertarPersona(
                                this.txtPnombre.Text.Trim().ToUpper(),
                                this.txtSnombre.Text.Trim().ToUpper(),
                                this.txtTnombre.Text.Trim().ToUpper(),
                                this.txtPapellido.Text.Trim().ToUpper(),
                                this.txtSapellido.Text.Trim().ToUpper(),
                                this.txtTapellido.Text.Trim().ToUpper(),
                                this.txtEdad.Text.Trim().ToUpper(),
                                this.txtPretencion.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbEstado.SelectedValue),
                                this.txtNacion.Text.Trim().ToUpper(),
                                date,
                                Convert.ToInt32(this.cmbGenero.SelectedValue),
                                Convert.ToInt32(this.cmbEtnia.SelectedValue),
                                this.txtNacionalidad.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbReligion.SelectedValue),
                                this.txtDPI.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbMunicipio.SelectedValue),
                                this.txtIgss.Text.Trim().ToUpper(),
                                this.txtNIT.Text.Trim().ToUpper(),
                                imagenBytes,
                                this.txtLicencia.Text.Trim().ToUpper(),
                                this.txtTipoLicencia.Text.Trim().ToUpper());
                        }
                        else if (this.IsEditar)
                        {
                            byte[] nuevaImagen;
                            using (MemoryStream msNuevaImagen = new MemoryStream())
                            {
                                // Reemplaza pcbNuevaFoto con el PictureBox que contiene la nueva imagen
                                pcbFoto.Image.Save(msNuevaImagen, System.Drawing.Imaging.ImageFormat.Jpeg);
                                nuevaImagen = msNuevaImagen.ToArray();
                            }

                            rpta = nPersona.EditarPersona(
                                Convert.ToInt32(this.txtIdPersona.Text),
                                this.txtPnombre.Text.Trim().ToUpper(),
                                this.txtSnombre.Text.Trim().ToUpper(),
                                this.txtTnombre.Text.Trim().ToUpper(),
                                this.txtPapellido.Text.Trim().ToUpper(),
                                this.txtSapellido.Text.Trim().ToUpper(),
                                this.txtTapellido.Text.Trim().ToUpper(),
                                this.txtEdad.Text.Trim().ToUpper(),
                                this.txtPretencion.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbEstado.SelectedValue),
                                this.txtNacion.Text.Trim().ToUpper(),
                                date,
                                Convert.ToInt32(this.cmbGenero.SelectedValue),
                                Convert.ToInt32(this.cmbEtnia.SelectedValue),
                                this.txtNacionalidad.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbReligion.SelectedValue),
                                this.txtDPI.Text.Trim().ToUpper(),
                                Convert.ToInt32(this.cmbMunicipio.SelectedValue),
                                this.txtIgss.Text.Trim().ToUpper(),
                                this.txtNIT.Text.Trim().ToUpper(),
                                nuevaImagen, // Utiliza la nueva imagen en lugar de ms.ToArray()
                                this.txtLicencia.Text.Trim().ToUpper(),
                                this.txtTipoLicencia.Text.Trim().ToUpper());
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

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtIdPersona.Text))
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdPersona.Text = string.Empty;
            this.Habilitar(false);
        }
    }
}
