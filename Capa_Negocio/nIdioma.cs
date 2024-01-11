using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nIdioma
    {

        public static string Insertar
            (int idPersona,int ididioma,string conversacion,string escritura, string lectura, string documento)
        {
            cIdioma Idioma = new cIdioma
            {
                IdPersona = idPersona,
                IdIdioma = ididioma,
                Conversacion = conversacion,
                Escritura = escritura,
                Lectura = lectura,
                Documento = documento

            };

            return Idioma.Insertar(Idioma);
        }

        
        public static DataTable MostarrhIdioma()
        {
            return new cIdioma().Mostrar();
        }

        public static DataTable Buscar(string persona)
        {
            cIdioma obj = new cIdioma();
            obj.Persona = persona;
            return obj.Buscar(obj);
        }

        public static string Actualizar
           (int id_Idioma,int idPersona, int ididioma, string conversacion, string escritura, string lectura, string documento)
        {
            cIdioma Idioma = new cIdioma
            {
                Id_Idioma = id_Idioma,
                IdPersona = idPersona,
                IdIdioma = ididioma,
                Conversacion = conversacion,
                Escritura = escritura,
                Lectura = lectura,
                Documento = documento

            };

            return Idioma.Actualizar(Idioma);
        }

    }
}
