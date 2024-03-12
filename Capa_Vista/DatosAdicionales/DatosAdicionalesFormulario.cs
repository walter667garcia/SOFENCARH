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

namespace Capa_Vista.DatosAdicionales
{
    public partial class DatosAdicionalesFormulario : Form
    {
        public int Idpersona {  get; set; }
        public string Evento {  get; set; }

        //Variables necesarias para movilizar el formulario 
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public DatosAdicionalesFormulario()
        {
            
            
            InitializeComponent();
        }

        public void Cargardatos(string id, string emergencias, string parentesco, string telefono)
        {
            txtId.Text = id;
            txtEmergencia.Text = emergencias;
            txtParentesco.Text = parentesco;
            txtTelefono.Text = telefono;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Eventos necesarios para movilizar el formulario
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void LimpiarCampos()
        {
            // Limpiar los campos asignándoles una cadena vacía
            this.txtEmergencia.Text = string.Empty;
            this.txtParentesco.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtEmergencia.Text) || string.IsNullOrEmpty(this.txtParentesco.Text) || string.IsNullOrEmpty(this.txtTelefono.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
                this.txtEmergencia.Text = "***";
                this.txtParentesco.Text = "***";
                this.txtTelefono.Text = "***";
            }
            else
            {
                string rpta = "";

                if (this.Evento == "Nuevo")
                {
                    rpta = nDatosAdicionales.Insertar(
                        Idpersona,
                        this.txtEmergencia.Text.Trim(),
                        this.txtParentesco.Text.Trim(),
                        this.txtTelefono.Text.Trim()
                    );
                }
                else if (this.Evento == "Editar")
                {
                    rpta = nDatosAdicionales.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                        this.Idpersona,
                        this.txtEmergencia.Text.Trim(),
                        this.txtParentesco.Text.Trim(),
                        this.txtTelefono.Text.Trim()
                    );

                }

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk(this.Evento == "Nuevo" ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }

                LimpiarCampos();
               
            }
        }

        public void CargarElementos
            (
            string Id, string Emergencia, 
            string Parentesco, string Telefono
            )
        {
            txtId.Text = Id;
            txtEmergencia.Text = Emergencia;
            txtParentesco.Text = Parentesco;
            txtTelefono.Text = Telefono;
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
    }
}
