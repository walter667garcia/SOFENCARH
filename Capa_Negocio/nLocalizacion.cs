using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nLocalizacion
    {
        public static string InsertarLocalizacion(
        int idPersona, int idLocalizacionTipo, string localizacion)
        {
            cLocalizacion localizacionDatos = new cLocalizacion
            {
                IdPersona = idPersona,
                IdLocalizacionTipo = idLocalizacionTipo,
                Localizacion = localizacion,
            };

            return localizacionDatos.Insertar(localizacionDatos);
        }

        public static DataTable BuscarLocalizacion(string dpi)
        {
            cLocalizacion obj = new cLocalizacion();
            obj.Persona = dpi;
            return obj.Buscar(obj);
        }

        public static DataTable MostrarLocalizaciones()
        {
            return new cLocalizacion().Mostrar();
        }

        public static string ActualizarLocalizacion(
            int idLocalizacion, int idPersona, int idLocalizacionTipo,
            string localizacion)
        {
            cLocalizacion obj = new cLocalizacion();
            obj.IdLocalizacion = idLocalizacion;
            obj.IdPersona = idPersona;
            obj.IdLocalizacionTipo = idLocalizacionTipo;
            obj.Localizacion = localizacion;

            return obj.Actualizar(obj);
        }

 
            public static string Eliminar(int idLocalizacion)
            {
                cLocalizacion Obj = new cLocalizacion();
                Obj.ID = idLocalizacion;
                return Obj.Eliminar(Obj);

        }
    }
}
