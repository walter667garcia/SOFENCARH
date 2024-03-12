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

namespace Capa_Vista.ExperienciaLaboral
{
    public partial class ExperienciaLaboralFormulario : Form
    {
        //Variables Necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para iniciar
        public int Idpersona {  get; set; }
        public string Evento { get; set; }

        public ExperienciaLaboralFormulario()
        {
            InitializeComponent();
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
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            this.txtId.Text = string.Empty;
            this.txtEmpresa.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtJefe.Text = string.Empty;
            this.txtPuesto.Text = string.Empty;
            this.txtSalario.Text = string.Empty;
            dtmFechaIngreso.Text = string.Empty;
            dtmFechaRetiro.Text = string.Empty;
            this.txtMotivo.Text = string.Empty;
            this.cmbReferencia.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            DateTime fechaIngreso = this.dtmFechaIngreso.Value;
            DateTime fechaRetiro = this.dtmFechaRetiro.Value;

            if (string.IsNullOrEmpty(this.txtEmpresa.Text) || 
                string.IsNullOrEmpty(this.txtSalario.Text) || 
                string.IsNullOrEmpty(this.txtDescripcion.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
                this.txtEmpresa.Text = "***";
                this.txtSalario.Text = "***";
                this.txtDescripcion.Text = "***";
            }
            else
            {
                string rpta = "";
                if (Evento == "Nuevo")
                {
                    rpta = nExperienciaLaboral.Insertar(
                        Idpersona,
                        this.txtEmpresa.Text.Trim(),
                        this.txtTelefono.Text.Trim(),
                        this.txtJefe.Text.Trim(),
                        this.txtPuesto.Text.Trim(),
                        this.txtSalario.Text.Trim(),
                        fechaIngreso,
                        fechaRetiro,
                        this.txtMotivo.Text.Trim(),
                        this.cmbReferencia.Text.Trim(),
                        this.txtDescripcion.Text.Trim()
                    );
                }
                else if(Evento == "Editar")
                {
                    rpta = nExperienciaLaboral.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                        Idpersona,
                        this.txtEmpresa.Text.Trim(),
                        this.txtTelefono.Text.Trim(),
                        this.txtJefe.Text.Trim(),
                        this.txtPuesto.Text.Trim(),
                        this.txtSalario.Text.Trim(),
                        fechaIngreso,
                        fechaRetiro,
                        this.txtMotivo.Text.Trim(),
                        this.cmbReferencia.Text.Trim(),
                        this.txtDescripcion.Text.Trim()
                    );
                }

                if (rpta.Equals("OK"))
                {
                    this.MensajeOk(this.Evento == "Nuevo" ? "Se insertó de forma correcta el registro" : "Se actualizó de forma correcta el registro");
                    LimpiarCampos();
                    this.Close();
                }
                else
                {
                    this.MensajeError(rpta);
                }
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
        public void CargarDatos(string id, string empresa, string fechaIngreso, string fechaRetiro,
                                     string telefono, string jefe, string puesto, string salario,
                                     string motivo, string referencia, string descripcion)
        {
            this.txtId.Text = id;
            this.txtEmpresa.Text = empresa;
            this.dtmFechaIngreso.Text = fechaIngreso;
            this.dtmFechaRetiro.Text = fechaRetiro;
            this.txtTelefono.Text = telefono;
            this.txtJefe.Text = jefe;
            this.txtPuesto.Text = puesto;
            this.txtSalario.Text = salario;
            this.txtMotivo.Text = motivo;
            this.cmbReferencia.Text = referencia;
            this.txtDescripcion.Text = descripcion;
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
