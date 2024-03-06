using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void CargarExperienciaLaboral(string id, string empresa, string fechaIngreso, string fechaRetiro,
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

    }
}
