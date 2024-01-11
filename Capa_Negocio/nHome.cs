using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nHome
    {
        private cHome persona;

        public nHome() 
        { 
            this.persona = new cHome();
        
        }

        public DataSet PersonaInformacion ()
        {
            return persona.HomeInformacion();
        }


        public static DataTable BuscarEducacion(string txtDPI)
        {

            cHome obj = new cHome();
            obj.EducacionDPI = txtDPI;
            return obj.BuscarEducacion(obj);
        }

        public static DataTable BuscarUbicacion(string txtDPI)
        {

            cHome obj = new cHome();
            obj.UbicacionDPI = txtDPI;
            return obj.BuscarUbicacion(obj);
        }

        public static DataTable BuscarIdioma(string txtDPI)
        {

            cHome obj = new cHome();
            obj.IdiomaDPI = txtDPI;
            return obj.BuscarIdioma(obj);
        }

        public static DataTable BuscarFamilia(string txtDPI)
        {

            cHome obj = new cHome();
            obj.FamiliaDPI = txtDPI;
            return obj.BuscarFamilia(obj);
        }
    }
}
