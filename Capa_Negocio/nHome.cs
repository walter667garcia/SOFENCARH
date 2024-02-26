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
        public static DataTable PersonaMostrar()
        {
            return new cHome().MostrarPersona();
        }

        public static DataTable BuscarUbicacion(int ubicacion)
        {

            cHome obj = new cHome();
            obj.IdUbicacio = ubicacion;
            return obj.UbicacionPersona(obj);
        }
        public static DataTable BuscarFamilia(int familia)
        {
            cHome obj = new cHome();
            obj.IdFamilia = familia;
            return obj.FamiliaPersona(obj);
        }

        public static DataTable BuscarEducacion(int educacion)
        {
            cHome obj = new cHome();
            obj.IdEducacion = educacion;
            return obj.EducacionPersona(obj);
        }
        public static DataTable BuscarIdioma(int idioma)
        {
            cHome obj = new cHome();
            obj.IdIdioma = idioma;
            return obj.IdiomaPersona(obj);
        }

        public static DataTable BuscarExperiencia(int experiencia)
        {
            cHome obj = new cHome();
            obj.IdExperienciaLaboral = experiencia;
            return obj.ExperienciaLaboralPersona(obj);
        }
        public static DataTable BuscarSocioEconomico(int socioeconomico)
        {
            cHome obj = new cHome();
            obj.IdSocioEconimico = socioeconomico;
            return obj.SocioeconomicoPersona(obj);
        }

        public static DataTable BuscarFisioBiologico(int fisicobiologico)
        {
            cHome obj = new cHome();
            obj.IdFisicoBiologico = fisicobiologico;
            return obj.FisicoBialogicaPersona(obj);
        }
        public static DataTable BuscarReferenciaLaboral(int referencialaboral)
        {
            cHome obj = new cHome();
            obj.IdReferenciaLaboral = referencialaboral;
            return obj.ReferenciaLaboralPersona(obj);
        }
        public static DataTable BuscarReferenciaPersonal(int referenciapersonal)
        {
            cHome obj = new cHome();
            obj.IdReferenciaPersonal = referenciapersonal;
            return obj.ReferenciaPersonalPersona(obj);
        }

        public static DataTable BuscarOtrosDatos(int otrosdatos)
        {
            cHome obj = new cHome();
            obj.IdOtrosDatos = otrosdatos;
            return obj.OtrosDatosPersona(obj);
        }

        public static DataTable BuscarDatosAdicionales(int datosadicionales)
        {
            cHome obj = new cHome();
            obj.IdDatosAdicionales = datosadicionales;
            return obj.DatosAdicionalesPersona(obj);
        }

        public static DataTable BuscarPersona(string persona)
        {
            cHome obj = new cHome();
            obj.IdPersona = persona;
            return obj.BuscarPersona(obj);
        }
    }
}
