using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista.FisicoBiologico
{
    public partial class FisicoBiologicoFormulario : Form
    {
        //Variables necesarias para movilizar el formulario
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Variables necesarias para iniciar
        public int Idpersona {  get; set; }
        public string Evento { get; set; }
        public FisicoBiologicoFormulario()
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

            this.cmbEmfermedad.Text = string.Empty;
            this.cmbDiabetes.Text = string.Empty;
            this.cmbAccidente.Text = string.Empty;
            this.cmbOperacion.Text = string.Empty;
            this.txtAlergias.Text = string.Empty;
            this.cmbtratamiento.Text = string.Empty;
            this.txtEspecifique.Text = string.Empty;
            this.cmblentes.Text = string.Empty;
            this.cmbauditivo.Text = string.Empty;
            this.txtDiscapacidad.Text = string.Empty;
            this.cmbdrogas.Text = string.Empty;
            this.cmbalcohol.Text = string.Empty;
            this.cmbfuma.Text = string.Empty;
            this.txtPeso.Text = string.Empty;
            this.txtEstatura.Text = string.Empty;
            this.cmbsangre.Text = string.Empty;
            this.txtPasatienpo.Text = string.Empty;
            this.txtDeporte.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbDiabetes.Text) || string.IsNullOrEmpty(this.cmbDiabetes.Text))
            {
                MensajeError("Falta ingresar algunos datos Remarcados");
               
            }
            else
            {
                string rpta = "";
                if (this.Evento == "Nuevo")
                {
                    rpta = nFisicoBiologico.Insertar(
                        Idpersona,
                        this.cmbEmfermedad.Text.Trim(),
                        this.cmbDiabetes.Text.Trim(),
                        this.cmbAccidente.Text.Trim(),
                        this.cmbOperacion.Text.Trim(),
                        this.txtAlergias.Text.Trim(),
                        this.cmbtratamiento.Text.Trim(),
                        this.txtEspecifique.Text.Trim(),
                        this.cmblentes.Text.Trim(),
                        this.cmbauditivo.Text.Trim(),
                        this.txtDiscapacidad.Text.Trim(),
                        this.cmbdrogas.Text.Trim(),
                        this.cmbalcohol.Text.Trim(),
                        this.cmbfuma.Text.Trim(),
                        this.txtPeso.Text.Trim(),
                        this.txtEstatura.Text.Trim(),
                        this.cmbsangre.Text.Trim(),
                        this.txtPasatienpo.Text.Trim(),
                        this.txtDeporte.Text.Trim()
                    );
                }
                else if (this.Evento == "Editar")
                {
                    rpta = nFisicoBiologico.Actualizar(
                        Convert.ToInt32(this.txtId.Text),
                       Idpersona,
                        this.cmbEmfermedad.Text.Trim(),
                        this.cmbDiabetes.Text.Trim(),
                        this.cmbAccidente.Text.Trim(),
                        this.cmbOperacion.Text.Trim(),
                        this.txtAlergias.Text.Trim(),
                        this.cmbtratamiento.Text.Trim(),
                        this.txtEspecifique.Text.Trim(),
                        this.cmblentes.Text.Trim(),
                        this.cmbauditivo.Text.Trim(),
                        this.txtDiscapacidad.Text.Trim(),
                        this.cmbdrogas.Text.Trim(),
                        this.cmbalcohol.Text.Trim(),
                        this.cmbfuma.Text.Trim(),
                        this.txtPeso.Text.Trim(),
                        this.txtEstatura.Text.Trim(),
                        this.cmbsangre.Text.Trim(),
                        this.txtPasatienpo.Text.Trim(),
                        this.txtDeporte.Text.Trim()
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
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void CargarDatos(string id, string enfermedad, string diabetes, string accidente,
                       string operacion, string alergias, string tratamiento,
                       string especifique, string lentes, string auditivo,
                       string discapacidad, string drogas, string alcohol,
                       string fuma, string peso, string estatura, string sangre,
                       string pasatiempos, string deportes )
        {
            this.txtId.Text = id;
            this.cmbEmfermedad.Text = enfermedad;
            this.cmbDiabetes.Text = diabetes;
            this.cmbAccidente.Text = accidente;
            this.cmbOperacion.Text = operacion;
            this.txtAlergias.Text = alergias;
            this.cmbtratamiento.Text = tratamiento;
            this.txtEspecifique.Text = especifique;
            this.cmblentes.Text = lentes;
            this.cmbauditivo.Text = auditivo;
            this.txtDiscapacidad.Text = discapacidad;
            this.cmbdrogas.Text = drogas;
            this.cmbalcohol.Text = alcohol;
            this.cmbfuma.Text = fuma;
            this.txtPeso.Text = peso;
            this.txtEstatura.Text = estatura;
            this.cmbsangre.Text = sangre;
            this.txtPasatienpo.Text = pasatiempos;
            this.txtDeporte.Text = deportes;
           
        }

        private void ValidarPeso(TextBox textBox)
        {
            string textoOriginal = textBox.Text;

            // Limpiar el texto de cualquier carácter no permitido y mantener solo números.
            string textoNumerico = LimpiarNoNumericos(textoOriginal);

            // Limitar a tres caracteres numéricos.
            if (textoNumerico.Length > 3)
            {
                textoNumerico = textoNumerico.Substring(0, 3);
            }

            // Agregar "LBS" al final del texto.
            string textoFinal = textoNumerico + " LBS";

            // Actualizar el TextBox solo si ha habido un cambio.
            if (textoOriginal != textoFinal)
            {
                textBox.Text = textoFinal;
                // Establecer el cursor al final del texto.
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private string LimpiarNoNumericos(string texto)
        {
            // Eliminar caracteres no numéricos.
            string patron = @"[^\d]";
            return System.Text.RegularExpressions.Regex.Replace(texto, patron, "");
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            ValidarPeso(txtPeso);
        }

        private void ValidarEstatura(TextBox textBox)
        {
            string textoOriginal = textBox.Text;

            // Limpiar el texto de cualquier carácter no permitido y mantener solo números.
            string textoNumerico = LimpiarNoNumericos(textoOriginal);

            // Limitar a tres caracteres numéricos.
            if (textoNumerico.Length > 3)
            {
                textoNumerico = textoNumerico.Substring(0, 3);
            }

            // Agregar "MTS" al final del texto.
            string textoFinal = textoNumerico + " MTS";

            // Insertar un punto después del primer número y dos números después del punto.
            if (textoNumerico.Length >= 1)
            {
                textoFinal = textoFinal.Insert(1, ".");
            }

            // Actualizar el TextBox solo si ha habido un cambio.
            if (textoOriginal != textoFinal)
            {
                textBox.Text = textoFinal;
                // Establecer el cursor al final del texto.
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {
            ValidarEstatura(txtEstatura);
        }

        
    }
}
