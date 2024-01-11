using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nDatos
    {
        private Datos datos;
        private Datos rhIdiomas;
        private Datos puestoFuncional;

        public nDatos()
        {
            this.datos = new Datos();
            this.rhIdiomas = new Datos();
            this.puestoFuncional = new Datos();
        }

        public DataSet CargarDatosPersona()
        {
            return datos.CargarDatosPersona();
        }

        public DataSet CargarDatosRhIdiomas()
        {
            return rhIdiomas.CargarDatosRhIdioma();
        }

        public DataSet CargarDatosPuestoFuncional()
        {
            return puestoFuncional.CargarDatosPuestoFuncional();
        }
    }
}
