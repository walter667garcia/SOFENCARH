using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Capa_Vista.Usuario
{
    public partial class frmEntregaPuesto : Form
    {
        public frmEntregaPuesto()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            // Configurar el diálogo para que solo acepte archivos de Word
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documentos de Word (*.docx, *.doc)|*.docx;*.doc";

            // Mostrar el diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado y mostrarla en un cuadro de texto
                string selectedFilePath = openFileDialog.FileName;
                txtPath.Text = selectedFilePath;
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            // Configurar el cuadro de diálogo para la selección de carpeta
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Mostrar el cuadro de diálogo y verificar si se seleccionó una carpeta
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta de la carpeta seleccionada y asignarla al TextBox
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    txtDestino.Text = selectedFolderPath;
                }
            }
        }

        private void frmEntregaPuesto_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatos(string dpi, string puestofuncional, string puestonominal, 
            string profesion, string empleado)
        {
            DateTime dateTime = DateTime.Now;
            int hora = dateTime.Hour;
            int ninutos = dateTime.Minute;
            this.txtDPI.Text = dpi;
            this.txtPuestoFuncional.Text = puestofuncional;
            this.txtPuestoNominal.Text = puestonominal;
            this.txtEmpleado.Text = empleado;
            this.txtProfesion.Text = profesion;
            this.txtHora.Text = hora + ":" + ninutos.ToString();
            this.txtHora1.Text = hora + ":" + ninutos.ToString();

        }
        private void ReplaceBookmark(Word.Document doc, string bookmarkName, string text)
        {
            // Verificar si el marcador existe
            if (doc.Bookmarks.Exists(bookmarkName))
            {
                // Obtener el rango del marcador
                Word.Range range = doc.Bookmarks[bookmarkName].Range;

                // Reemplazar el contenido del marcador
                range.Text = text;

                // Reemplazar el marcador con el nuevo rango
                doc.Bookmarks.Add(bookmarkName, range);
            }
            else
            {
                // Manejar el caso donde el marcador no existe
                MessageBox.Show("El marcador '" + bookmarkName + "' no existe en el documento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Validar si se ha seleccionado un archivo
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show("Por favor, seleccione un archivo de Word primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar si se ha seleccionado una carpeta de destino
            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Por favor, seleccione la carpeta de destino para guardar el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar campos requeridos
            if (
                string.IsNullOrEmpty(txtHoraLetras.Text) ||
                string.IsNullOrEmpty(txtFechaletras.Text) ||
                string.IsNullOrEmpty(txtDPILetras.Text) ||
                 string.IsNullOrEmpty(txtHoraLetras1.Text) 

                )
            {
                MessageBox.Show("Por favor, ingrese un los capos necesarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Obtener el nombre del archivo del TextBox
            string nuevoNombreArchivo = txtDPI.Text.Trim();

            // Validar si se ha proporcionado un nombre para el nuevo archivo
            if (string.IsNullOrEmpty(nuevoNombreArchivo))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el nuevo archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                Word.Application objWord = new Word.Application();

                // Abrir el documento existente
                Word.Document doc = objWord.Documents.Open(txtPath.Text);

                DateTime fechaActual = DateTime.Now;
                // Reemplazar marcadores con los valores de los TextBox
                ReplaceBookmark(doc, "DPI", txtDPI.Text);
                ReplaceBookmark(doc, "DPILetras", txtDPILetras.Text);
                ReplaceBookmark(doc, "Empleado", txtEmpleado.Text);
                ReplaceBookmark(doc, "FechaLetras", txtFechaletras.Text);
                ReplaceBookmark(doc, "FechaLetras1", txtFechaletras.Text);
                ReplaceBookmark(doc, "FechaLetras2", txtFechaletras.Text);
                ReplaceBookmark(doc, "Hora", txtHora.Text);
                ReplaceBookmark(doc, "Hora1", txtHora1.Text);
                ReplaceBookmark(doc, "Horaletras", txtHoraLetras.Text);
                ReplaceBookmark(doc, "Horaletras1", txtHoraLetras1.Text);
                ReplaceBookmark(doc, "Profesion", txtProfesion.Text);
                ReplaceBookmark(doc, "PuestoFuncional", txtPuestoFuncional.Text);
                ReplaceBookmark(doc, "PuestoNominal", txtPuestoNominal.Text);




                // Guardar una copia del documento con los cambios y el nuevo nombre en la carpeta seleccionada
                string destino = txtDestino.Text;
                object filename = destino + "\\"+ nuevoNombreArchivo + ".docx";
                doc.SaveAs2(ref filename);

                MessageBox.Show("Los cambios se han guardado correctamente en una copia del documento con el nombre especificado en la carpeta seleccionada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el documento si no es nulo y liberar los recursos
                if (doc != null)
                {
                    doc.Close();
                }

                // Cerrar Word y liberar los recursos
                objWord.Quit();

                // Abrir el documento recién guardado
                Process.Start(filename.ToString());

                // Cerrar la aplicación Windows Forms
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al intentar guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
