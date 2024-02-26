using Capa_Negocio;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;

namespace Capa_Vista
{
    public partial class frmPersona : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmPersona()
        {
            InitializeComponent();
            dtmFecha.Format = DateTimePickerFormat.Custom;
            dtmFecha.CustomFormat = "dd/MM/yyyy";

            dtmFecha.KeyPress += dtmFecha_KeyPress;

            ConfigurarOrdenTabulacion();


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
                    //this.dtgPersona.Columns[9].Visible = false;
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
            this.BuscarMunicipio();


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

           // cmbMunicipio.DataSource = dataSet.Tables["TYMUNICIPIO"];
            //cmbMunicipio.DisplayMember = "MUNICIPIO";
            //cmbMunicipio.ValueMember = "ID_MUNICIPIO";

            cmbDepartamento.DataSource = dataSet.Tables["TYDEPARTAMENTO"];
            cmbDepartamento.DisplayMember = "DEPARTAMENTO";
            cmbDepartamento.ValueMember = "ID_DEPARTAMENTO";

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
                    try
                    {
                        // Verifica el tamaño de la imagen antes de cargarla
                        FileInfo fileInfo = new FileInfo(ofd.FileName);
                        long fileSize = fileInfo.Length; // Tamaño del archivo en bytes

                        // Define el tamaño máximo permitido (en bytes)
                        long maxSize = 10 * 1024 * 1024; // 10 MB como ejemplo, ajusta según tus necesidades

                        if (fileSize > maxSize)
                        {
                            MessageBox.Show("El tamaño de la imagen es demasiado grande. Por favor, selecciona una imagen más pequeña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Sale de la función sin cargar la imagen
                        }

                        // Carga la imagen si pasa todas las verificaciones
                        pcbFoto.Image = Image.FromFile(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Restaura la imagen anterior
                        pcbFoto.Image = imagenActual;
                    }
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
            this.cmbDepartamento.Text = string.Empty;
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
                                this.txtTipoLicencia.Text.Trim().ToUpper(),
                                this.cmbDepartamento.Text.Trim().ToUpper());
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
                                this.txtTipoLicencia.Text.Trim().ToUpper(),
                                this.cmbDepartamento.Text.Trim().ToUpper());
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

        private DataSet municipio;
        private void BuscarMunicipio()
        {
                cmbMunicipio.DataSource = nPersona.BuscarMunicipio(cmbDepartamento.SelectedValue.ToString());
                cmbMunicipio.DisplayMember = "MUNICIPIO";
                cmbMunicipio.ValueMember = "ID_MUNICIPIO";
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
                if(btnNuevo.Enabled != false)
                {

                    DataTable dataSet = nPersona.BuscarDepartamento(dtgPersona.CurrentRow.Cells["MUNICIPIO"].Value.ToString());
                    string nombreDepartamento = dataSet.Rows[0]["DEPARTAMENTO"].ToString();
                    int idDepartamento = cmbDepartamento.FindStringExact(nombreDepartamento);
                    cmbDepartamento.SelectedIndex = idDepartamento;

                    string Etnia = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Etnia"].Value);
                int idEtnia = cmbEtnia.FindStringExact(Etnia);
                cmbEtnia.SelectedIndex = idEtnia;
                

                string Genero = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Genero"].Value);
                int idGenero = cmbGenero.FindStringExact(Genero);
                cmbGenero.SelectedIndex = idGenero;

                string Estado = Convert.ToString(this.dtgPersona.CurrentRow.Cells["ESTADO_CIVIL"].Value);
                int idestadocivil = cmbEstado.FindString(Estado);
                cmbEstado.SelectedIndex = idestadocivil;

                string Municipio = this.dtgPersona.CurrentRow.Cells["MUNICIPIO"].Value.ToString();
                int idMunicipio = cmbMunicipio.FindString(Municipio);
                cmbMunicipio.SelectedIndex = idMunicipio;

                string Religion = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Religión"].Value);
                int idReligion = cmbReligion.FindStringExact(Religion);
                cmbReligion.SelectedIndex = idReligion;


                this.txtIdPersona.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Id"].Value);
                this.txtPnombre.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_NOMBRE"].Value);
                this.txtSnombre.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_NOMBRE"].Value);
                this.txtTnombre.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Tercer_NOMBRE"].Value);
                this.txtPapellido.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_APELLIDO"].Value);
                this.txtSapellido.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_APELLIDO"].Value);
                this.txtTapellido.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["APELLIDO_casada"].Value);
                this.txtEdad.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["EDAD"].Value);
                this.txtNacion.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Lugar_NACIMIENTO"].Value);
                this.txtNacionalidad.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["NACIONALIDAD"].Value);
                this.txtDPI.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["DPI"].Value);
                this.dtmFecha.Text = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Fecha_NACIMIENTO"].Value);
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
                else
                {
                    MessageBox.Show("No puede editar y crear un nuevo registro a la vez");
                }
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


        private void txtLicencia_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string lcNumero = Regex.Replace(txtLicencia.Text, @"[^\d]", "");

            // Limita  13 caracteres
            if (lcNumero.Length > 13)
            {
                lcNumero = lcNumero.Substring(0, 13);

            }

            if (lcNumero.Length <= 13)
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
                                this.txtTipoLicencia.Text.Trim().ToUpper(),
                                this.cmbDepartamento.Text.Trim().ToUpper());

                                this.MensajeOk(this.IsNuevo ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    }
                    else if (this.IsEditar)
                    {
                        // Mostrar un cuadro de diálogo de confirmación
                        DialogResult result = MessageBox.Show("¿Estás seguro de ingresar la nueva actualización?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        byte[] nuevaImagen;

                        if (result == DialogResult.Yes)
                        {
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
                                this.txtTipoLicencia.Text.Trim().ToUpper(),
                                this.cmbDepartamento.Text.Trim().ToUpper());

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se actualizó de forma correcta el registro");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                        else
                        {
                            // El usuario ha seleccionado "No", por lo tanto, no se realiza la actualización
                            this.Limpiar(false); // Limpia los campos o realiza acciones necesarias al cancelar la actualización
                        }
                    }

                    // Resto del código para manejar la lógica después de la actualización o cancelación
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
               
            }
        }

        private void Limpiar(bool v)
        {
            throw new NotImplementedException();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtIdPersona.Text))
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdPersona.Text = string.Empty;
            this.Habilitar(false);
        }

        private void cmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMunicipio.DataSource = nPersona.BuscarMunicipio(cmbDepartamento.SelectedValue.ToString());
            cmbMunicipio.DisplayMember = "MUNICIPIO";
            cmbMunicipio.ValueMember = "ID_MUNICIPIO";


        }

       
        private void dtmFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar=='/')
            {
                e.Handled = false;
            }
            else {
                e.Handled = true; 
            }
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

        private void txtNIT_TextChanged(object sender, EventArgs e)
        {
            // Obtener la posición actual del cursor
            int cursorPosition = txtNIT.SelectionStart;

            // Obtener el texto actual en el cuadro de texto
            string texto = txtNIT.Text;

            // Verificar la longitud del texto y truncarlo si excede los 15 caracteres
            if (texto.Length > 12)
            {
                txtNIT.Text = texto.Substring(0, 12);
                // Mantener la posición del cursor dentro del rango válido
                txtNIT.SelectionStart = 12;
            }

            // Verificar cada carácter en el texto
            foreach (char caracter in texto)
            {
                // Permitir números del 0 al 9, el signo "-" y la letra "K" mayúscula
                if (!(char.IsDigit(caracter) && caracter >= '0' && caracter <= '9') &&
                    caracter != '-' &&
                    caracter != 'K')
                {
                    // Eliminar el carácter no permitido
                    txtNIT.Text = txtNIT.Text.Replace(caracter.ToString(), "");
                }
            }

            // Restaurar la posición del cursor
            txtNIT.SelectionStart = cursorPosition;
        }

        


        private void menuclick(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void ConfigurarDataGridView()
        {
            // Configura el DataGridView
            dtgPersona.AllowUserToAddRows = false;
            dtgPersona.AllowUserToDeleteRows = false;
            dtgPersona.ReadOnly = true;

            // Agrega la fila de separación visual
            DataGridViewRow separador = new DataGridViewRow();
            separador.Height = 50; // Ajusta la altura según tus necesidades
            separador.DefaultCellStyle.BackColor = Color.Gray; // Color del separador
            dtgPersona.Rows.Add(separador);
        }


        private void dtgPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Suponiendo que la primera columna es la que contiene el nombre
            if (e.ColumnIndex == 0) // Modifica según la columna que estás utilizando
            {
                // Obtiene el valor actual de la celda
                string valorActual = dtgPersona.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Capitaliza la primera letra y convierte el resto a minúsculas
                string nuevoValor = CapitalizarPrimeraLetra(valorActual);

                // Establece el nuevo valor en la celda
                dtgPersona.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nuevoValor;
            }
        }


        private string CapitalizarPrimeraLetra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }

            // Convierte el primer carácter a mayúscula y el resto a minúsculas
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }


        private void ConfigurarOrdenTabulacion()
        {
            // Establecer el orden de tabulación para los TextBox
            txtPnombre.TabIndex = 1;
            txtSnombre.TabIndex = 2;
            txtTnombre.TabIndex = 3;
            txtPapellido.TabIndex = 4;
            txtSapellido.TabIndex = 5;
            txtTapellido.TabIndex = 6;
            txtDPI.TabIndex = 7;
            cmbGenero.TabIndex = 8;
            cmbEtnia.TabIndex = 9;
            cmbEstado.TabIndex = 10;
            dtmFecha.TabIndex = 11;
            cmbDepartamento.TabIndex = 12;
            cmbMunicipio.TabIndex = 13;
            txtNacion.TabIndex = 14;
            txtNacionalidad.TabIndex = 15;
            txtNIT.TabIndex = 16;
            txtIgss.TabIndex = 17;
            cmbReligion.TabIndex = 18;
            txtLicencia.TabIndex = 19;
            txtTipoLicencia.TabIndex = 20;
            btnFoto.TabIndex = 20;

        }

        private void txtPretencionSalarial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoLicencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void dtgPersona_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                var hti = dtgPersona.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    dtgPersona.Rows[hti.RowIndex].Selected = true;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = dtgPersona.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Ubicacion").Name = "Ubicacion" + posicion;
                    menu.Items.Add("Familia").Name = "Familia" + posicion;
                    menu.Items.Add("Estudios").Name = "Estudios" + posicion;
                    menu.Items.Add("Idiomas").Name = "Idiomas" + posicion;
                    menu.Items.Add("Experiencia Laboral").Name = "Experiencia Laboral" + posicion;
                    menu.Items.Add("Socio Economico").Name = "Socio Economico" + posicion;
                    menu.Items.Add("Fisico Biologico").Name = "Fisico Biologico" + posicion;
                    menu.Items.Add("Referencia Laboral").Name = "Referencia Laboral" + posicion;
                    menu.Items.Add("Referencia Personal").Name = "Referencia Personal" + posicion;
                    menu.Items.Add("Otros Datos").Name = "Otros Datos" + posicion;
                    menu.Items.Add("Datos Adicionales").Name = "Datos Adicionales" + posicion;
                }
                menu.Show(dtgPersona, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick1);
            }
        }

      

        private void menuclick1(object sender, ToolStripItemClickedEventArgs e)
        {
            string id = e.ClickedItem.Name.ToString();
            if (id.Contains("Ubicacion"))
            {
                id = id.Replace("Ubicacion", "");
                frmLocalizacion Obj = new frmLocalizacion();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }

            if (id.Contains("Familia"))
            {
                id = id.Replace("Familia", "");
                frmFamilia Obj = new frmFamilia();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }

            if (id.Contains("Estudios"))
            {
                id = id.Replace("Estudios", "");
                frmNivel_Academico Obj = new frmNivel_Academico();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }

            if (id.Contains("Idiomas"))
            {
                id = id.Replace("Idiomas", "");
                frmIdioma Obj = new frmIdioma();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }


            if (id.Contains("Experiencia Laboral"))
            {
                id = id.Replace("Experiencia Laboral", "");
                frmExperienciaLaboral Obj = new frmExperienciaLaboral();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }

            if (id.Contains("Socio Economico"))
            {
                id = id.Replace("Socio Economico", "");
                frmSocio_Economico Obj = new frmSocio_Economico();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }

            if (id.Contains("Fisico Biologico"))
            {
                id = id.Replace("Fisico Biologico", "");
                frmFisicoBiologico Obj = new frmFisicoBiologico();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }



            if (id.Contains("Referencia Laboral"))
            {
                id = id.Replace("Referencia Laboral", "");
                frmReferenciaLaboral Obj = new frmReferenciaLaboral();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }



            if (id.Contains("Referencia Personal"))
            {
                id = id.Replace("Referencia Personal", "");
                frmReferenciaPersonal Obj = new frmReferenciaPersonal();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);

            }



            if (id.Contains("Otros Datos"))
            {
                id = id.Replace("Otros Datos", "");
                frmOtrosDatos Obj = new frmOtrosDatos();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
            }



            if (id.Contains("Datos Adicionales"))
            {

                id = id.Replace("Datos Adicionales", "");
                frmDatosAdicionales Obj = new frmDatosAdicionales();
                string persona = Convert.ToString(this.dtgPersona.CurrentRow.Cells["id"].Value);
                string a, b, c, d;
                a = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Nombre"].Value);
                b = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Nombre"].Value);
                c = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Primer_Apellido"].Value);
                d = Convert.ToString(this.dtgPersona.CurrentRow.Cells["Segundo_Apellido"].Value);
                string nombre = a + " " + b + " " + c + " " + d;
                Obj.Show();
                Obj.cargar(persona, nombre);
                Obj.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana en el formulario principal
            }
        }

        private void txtPnombre_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPnombre.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPnombre.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPnombre.SelectionStart = textoValidado.Length;
            }
        }

        private string ValidarTexto(string texto)
        {
            // Filtra letras (mayúsculas y minúsculas), espacios y puntos.
            string patron = "[a-zA-ZáéíóúÁÉÍÓÚ-ñ]";

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
            // Filtra letras (mayúsculas y minúsculas), espacios y puntos.
            string patron = "[a-zA-Z0-9áéíóúÁÉÍÓÚ-ñ .,-]";

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

        private void txtSnombre_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtSnombre.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtSnombre.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtSnombre.SelectionStart = textoValidado.Length;
            }
        }

        private void txtTnombre_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtTnombre.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtTnombre.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtTnombre.SelectionStart = textoValidado.Length;
            }
        }

        private void txtPapellido_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtPapellido.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtPapellido.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtPapellido.SelectionStart = textoValidado.Length;
            }
        }

        private void txtSapellido_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtSapellido.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtSapellido.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtSapellido.SelectionStart = textoValidado.Length;
            }
        }

        private void txtTapellido_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtTapellido.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtTapellido.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtTapellido.SelectionStart = textoValidado.Length;
            }
        }

        private void txtNacion_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtNacion.Text;
            string textoValidado = ValidarTexto1(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtNacion.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtNacion.SelectionStart = textoValidado.Length;
            }
        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {
            string textoOriginal = txtNacionalidad.Text;
            string textoValidado = ValidarTexto(textoOriginal);

            if (textoOriginal != textoValidado)
            {
                // Si el texto original no es igual al texto validado,
                // establece el texto validado en el TextBox.
                txtNacionalidad.Text = textoValidado;

                // También puedes establecer el cursor al final del texto para mejorar la experiencia del usuario.
                txtNacionalidad.SelectionStart = textoValidado.Length;
            }
        }

        private void txtIgss_TextChanged(object sender, EventArgs e)
        {
            // Elimina cualquier caracter que no sea dígito
            string IgssNumerico = Regex.Replace(txtIgss.Text, @"[^\d]", "");

            // Limita a 13 caracteres
            if (IgssNumerico.Length > 15)
            {
                IgssNumerico = IgssNumerico.Substring(0, 15);
            }

            // Asigna el texto limpio al TextBox
            txtIgss.Text = IgssNumerico;
            // Coloca el cursor al final del texto
            txtIgss.SelectionStart = txtIgss.Text.Length;
        }

        private void Codigo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewAExcel(dtgPersona);
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

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar si el índice seleccionado no es el elemento en blanco
            if (cmbDepartamento.SelectedIndex > 0)
            {
                // Guardar el municipio seleccionado actualmente
                municipioSeleccionado = cmbMunicipio.SelectedValue?.ToString() ?? "";

                // Obtener la lista de municipios del departamento seleccionado
                cmbMunicipio.DataSource = nPersona.BuscarMunicipio(cmbDepartamento.SelectedValue.ToString());
                cmbMunicipio.DisplayMember = "MUNICIPIO";
                cmbMunicipio.ValueMember = "ID_MUNICIPIO";

                // Seleccionar el municipio guardado previamente
                if (!string.IsNullOrEmpty(municipioSeleccionado))
                {
                    cmbMunicipio.SelectedValue = municipioSeleccionado;
                }
            }
            else
            {
                // Limpiar el combo box de municipios si se selecciona el elemento en blanco
                cmbMunicipio.DataSource = null;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.txtIdPersona.Text = string.Empty;
            this.Habilitar(false);

            // Agregar mensaje de actualización
            MessageBox.Show("Se actualizó la edición de datos.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string municipioSeleccionado = "ID_MUNICIPIO";

        private void dtgPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
{
                DataGridViewRow row = dtgPersona.Rows[e.RowIndex];

                // Obtener valores de las celdas que deseas pasar
                string valorCelda1 = row.Cells["Primer_Nombre"].Value.ToString();
                string valorCelda2 = row.Cells["Segundo_Nombre"].Value.ToString();
                string valorCelda3 = row.Cells["Primer_Apellido"].Value.ToString();
                string valorCelda4 = row.Cells["Segundo_Apellido"].Value.ToString();
            }
        }


    }
}
