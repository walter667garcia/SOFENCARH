using Capa_Negocio;
using DocumentFormat.OpenXml.Office2010.Excel;
using FontAwesome.Sharp;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Markup;
using System.Windows.Media;

namespace Capa_Vista
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            chbDpi.Checked = false;
            chbNombre.Checked = false;
            //tabInformacionEmpleado.Visible = false;
        }

        private void OcultarColumna(string nombreColumna)
        {
            // Buscar la columna por su nombre
            DataGridViewColumn columna = dtgHome.Columns[nombreColumna];

            // Verificar si la columna existe y luego ocultarla
            if (columna != null)
            {
                columna.Visible = false;
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Mostrar();
            
        }

        private void BuscarPersona()
        {
            this.dtgHome.DataSource = nPersona.Buscar(this.txtBuscarPersona1.Text);

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dtgHome.Rows.Count - 1);
        }


        private void Mostrar()
        {
            this.dtgHome.DataSource = nHome.PersonaMostrar();
            Imagen();
        }

        private void Imagen()
        {
            DataGridViewImageColumn image = dtgHome.Columns["Foto"] as DataGridViewImageColumn;
            if (image != null )
            {
                image.ImageLayout = DataGridViewImageCellLayout.Zoom;
                image.DefaultCellStyle.NullValue = null;
            }
        }

        private void dtgHome_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
          
        }

        private void dtgHome_DoubleClick(object sender, EventArgs e)
        {
            if (this.dtgHome.CurrentRow != null)

            {
                byte[] datosBinarios = this.dtgHome.CurrentRow.Cells["Foto"].Value as byte[];

                if (datosBinarios != null && datosBinarios.Length > 0)
                {
                    // Asignar la imagen al PictureBox directamente desde los datos binarios
                    ptFoto.Image = Image.FromStream(new MemoryStream(datosBinarios));
                }
                else
                {
                    MessageBox.Show("Los datos binarios de la imagen son nulos o vacíos.");
                }
                this.lbNombre1.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["PrimerNombre"].Value);
                this.lbNombre2.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["SegundoNombre"].Value);
                this.lbApellido1.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["PrimerApellido"].Value);
                this.lbApellido2.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["SegundoApellido"].Value);
                this.lbFecha.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["FechaNacimiento"].Value);
                this.lbEdad.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Edad"].Value);
                this.lbNacionalidad.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Nacionalidad"].Value);
                this.lbDPI.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["DPI"].Value);
                this.lbNit.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Nit"].Value);
                this.lbIggs.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["IGSS"].Value);
                this.lbGenero.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Genero"].Value);
                this.lbEstadoCivil.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["EstadoCivil"].Value);
                this.txtIdBusqueda.Text = Convert.ToString(this.dtgHome.CurrentRow.Cells["Id"].Value);
                this.tbHome.SelectedIndex = 1;
                tabInformacionEmpleado.Visible = true;
            } 
        }

       

        private void PersonaHome(int idmostrar)
        {
            string resultado = "ID =" + dtgHome.Rows[idmostrar].Cells[0].Value.ToString();
        }

        private void chbDpi_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDpi.Checked)
            { 
                chbDpi.Checked = true;
                chbNombre.Checked = false;
                txtBuscarPersona1.Text = "";
            }
        }

        private void chbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNombre.Checked)
            {
                chbNombre.Checked = true;
                chbDpi.Checked = false;
                txtBuscarPersona1.Text = "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           if(chbNombre.Checked == true)
            {
                chbDpi.Checked = false;

                 BuscarPersona();
            }
           else if (chbDpi.Checked == true){
                chbNombre.Checked = false;
                // Elimina cualquier caracter que no sea dígito
                string dpiNumerico = Regex.Replace(txtBuscarPersona1.Text, @"[^\d]", "");

                // Limita a 13 caracteres
                if (dpiNumerico.Length > 13)
                {
                    dpiNumerico = dpiNumerico.Substring(0, 13);
                }

                // Asigna el texto limpio al TextBox
                txtBuscarPersona1.Text = dpiNumerico;
                // Coloca el cursor al final del texto
                txtBuscarPersona1.SelectionStart = txtBuscarPersona1.Text.Length;
                BuscarPersona();
            }
            else
            {
                Mostrar();
            }  
        }

        private void tabInformacionEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIdBusqueda.Text))
            {
                 if (tabInformacionEmpleado.SelectedTab == tbUbicacion)
                 {
                  this.dtgUbicacion.DataSource = nHome.BuscarUbicacion(Convert.ToInt32(txtIdBusqueda.Text));
                 }

                 if (tabInformacionEmpleado.SelectedTab == tbFamilia)
                 {
                  this.dtgFamilia.DataSource = nHome.BuscarFamilia(Convert.ToInt32(txtIdBusqueda.Text));
                 }

                if (tabInformacionEmpleado.SelectedTab == tbEducacion)
                {
                    this.dtgEducacion.DataSource = nHome.BuscarEducacion(Convert.ToInt32(txtIdBusqueda.Text));
                }
                if (tabInformacionEmpleado.SelectedTab == tbIdiomas)
                {
                    this.dtgIdiomas.DataSource = nHome.BuscarIdioma(Convert.ToInt32(txtIdBusqueda.Text));
                }
                if (tabInformacionEmpleado.SelectedTab == tbExperienciaLaboral)
                {
                    this.dtgExperiencia.DataSource = nHome.BuscarExperiencia(Convert.ToInt32(txtIdBusqueda.Text));
                }
                if (tabInformacionEmpleado.SelectedTab == tbSocio)
                {
                    this.dtgSocioEconomico.DataSource = nHome.BuscarSocioEconomico(Convert.ToInt32(txtIdBusqueda.Text));
                }

                if (tabInformacionEmpleado.SelectedTab == tbFisicaBiologica)
                {

                    this.dtgFisicoBiologico.DataSource = nHome.BuscarFisioBiologico(Convert.ToInt32(txtIdBusqueda.Text));

                }
                if (tabInformacionEmpleado.SelectedTab == tbReferenciaLaboral)
                {

                    this.dtgLaboral.DataSource = nHome.BuscarReferenciaLaboral(Convert.ToInt32(txtIdBusqueda.Text));

                }
                if (tabInformacionEmpleado.SelectedTab == tbReferenciapersonal)
                {

                    this.dtgPersonal.DataSource = nHome.BuscarReferenciaPersonal(Convert.ToInt32(txtIdBusqueda.Text));

                }
                if (tabInformacionEmpleado.SelectedTab == tbOtrosDatos)
                {

                    this.dtgOtrosDatos.DataSource = nHome.BuscarOtrosDatos(Convert.ToInt32(txtIdBusqueda.Text));

                }
                if (tabInformacionEmpleado.SelectedTab == tbAdicionales)
                {

                    this.dtgDatosAdicional.DataSource = nHome.BuscarDatosAdicionales(Convert.ToInt32(txtIdBusqueda.Text));

                }
            }
              else
              {
                   MessageBox.Show("Necesitas Selecionar un Empleado");
              }
        }
        
        private void lblTotal_Click(object sender, EventArgs e)
        {
           
        }
        private void dtgHome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Llamar a la función con el nombre de la columna que deseas ocultar
            OcultarColumna("id");
        }

        private void dtgUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            
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
            ShowUbicacion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowFamilia();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowEstudios();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowIdioma();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowExperiencialaboral();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowFisicobiologico();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowReferencialaboral();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowReferenciapersonal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowOtrosdatos();
        }

      

        private void button12_Click(object sender, EventArgs e)
        {
            ShowPersona();
        }

        private void ShowPersona()
        {
            frmPersona Obj = new frmPersona();
            Obj.Show();
        }

        private void ShowUbicacion()
        {
           
        }

        private void ShowFamilia()
        {
            
        }

        private void ShowEstudios()
        {
           
        }

        private void ShowIdioma()
        {
           
        }

        private void ShowExperiencialaboral()
        {
          
        }

       

        private void ShowFisicobiologico()
        {
            
        }

        private void ShowReferencialaboral()
        {
           
        }

        private void ShowReferenciapersonal()
        {
          
        }

        private void ShowOtrosdatos()
        {
            
        }

      

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void data_Mousclick(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;

            if (dataGridView != null && e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                int rowIndex = dataGridView.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex > -1)
                {
                    menu.Items.Add("Eliminar").Name = "Eliminar";
                }

                menu.Show(dataGridView, e.Location);
                menu.ItemClicked += (s, ev) =>
                {
                    string id = ev.ClickedItem.Name.ToString();
                    string valorPrimeraColumna = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
                    if (id.Contains("Eliminar"))
                    {
                        string rpta = "";
                        int idRegistro = Convert.ToInt32(valorPrimeraColumna);
                        switch (dataGridView.Name)
                        {
                            case "dtgUbicacion":

                                rpta = nLocalizacion.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgFamilia":
                                rpta = nFamilia.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgEducacion":
                                rpta = nNivelAcademico.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgIdiomas":
                                rpta = nIdioma.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgExperiencia":
                                rpta = nExperienciaLaboral.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgSocioEconomico":
                                rpta = nSocioEconomico.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgLaboral":
                                rpta = nReferenciaLaboral.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgPersonal":
                                rpta = nReferenciaPersonal.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgOtrosDatos":
                                rpta = nOtrosDatos.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgDatosAdicional":
                                rpta = nDatosAdicionales.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            case "dtgFisicoBiologico":
                                rpta = nFisicoBiologico.Eliminar(idRegistro);
                                validad(rpta);
                                break;

                            default:
                                MessageBox.Show("No existe el dato");
                                break;
                        }
                    }
                };
            }
        }

        private void validad(string rpta)
        {
            if (rpta.Equals("OK"))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que deseas eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    this.MensajeOk("Se Eliminó el registro");
                }
                else
                {
                    this.MensajeOk("No se realizó la eliminación");
                }
            }
            else
            {
                this.MensajeError(rpta);
            }
        }
    }
}
