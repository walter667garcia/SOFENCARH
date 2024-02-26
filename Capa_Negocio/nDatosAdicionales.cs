using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nDatosAdicionales
    {

        public static string Insertar(
            int idpersona, string emergencias, 
            string parentesco,string telefono
               )
        {
            cDatosAdicionales obj = new cDatosAdicionales();

            obj.IdPersona = idpersona;
            obj.EMERGENCIAS = emergencias;
            obj.PARENTESCO = parentesco;
            obj.TELEFONO = telefono;

            return obj.Insertar(obj);
        }

        public static string Actualizar(
            int id, int idPersona, string emergencias, 
            string parentesco,string telefono
            )
        {
            cDatosAdicionales obj = new cDatosAdicionales();

            obj.IDDATOSADI = id;
            obj.IdPersona = idPersona;
            obj.EMERGENCIAS = emergencias;
            obj.PARENTESCO = parentesco;
            obj.TELEFONO = telefono;

            return obj.Actualizar(obj);
        }

        public static DataTable Buscar(string persona)
        {
            cDatosAdicionales obj = new cDatosAdicionales();
            obj.Persona = persona;
            return obj.Buscar(obj);
        }

        public static DataTable Mostrar()
        {
            return new cDatosAdicionales().Mostrar();
        }

        public static string Eliminar(int idAdicionales)
        {
            cDatosAdicionales Obj = new cDatosAdicionales();
            Obj.ID = idAdicionales;
            return Obj.Eliminar(Obj);
        }

    }
}
