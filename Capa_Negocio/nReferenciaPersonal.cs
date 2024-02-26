using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nReferenciaPersonal
    {


        public static string Insertar(int idpersona, string nombre, string telefono, string relacion)
        {
            cReferenciaPersonal Obj  = new cReferenciaPersonal();
            Obj.IdPersona = idpersona;
            Obj.Nombre = nombre;
            Obj.Telefono = telefono;
            Obj.Relacion = relacion;
            return Obj.Insertar(Obj);
        }

        public static string Actualizar(int idrefpersonal ,int idpersona, string nombre, string telefono, string relacion)
        {
            cReferenciaPersonal Obj = new cReferenciaPersonal();
            Obj.IdRefpersonal = idrefpersonal;
            Obj.IdPersona = idpersona;
            Obj.Nombre = nombre;
            Obj.Telefono = telefono;
            Obj.Relacion = relacion;
            return Obj.Actualizar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new cReferenciaPersonal().Mostrar();
        }

        public static DataTable Buscar(string persona)
        {
            cReferenciaPersonal Obj = new cReferenciaPersonal();
            Obj.Persona = persona;
            return Obj.Buscar(Obj);
        }

        public static string Eliminar(int idPersonal)
        {
            cReferenciaPersonal Obj = new cReferenciaPersonal();
            Obj.ID = idPersonal;
            return Obj.Eliminar(Obj);
        }

    }
}
