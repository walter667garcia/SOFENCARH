using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nReferenciaLaboral
    {

        public static string Insertar(int idpersona, string empresa, string telefono, string relacion)
        {
            cReferenciaLaboral Obj = new cReferenciaLaboral();
            Obj.IdPersona = idpersona;
            Obj.Empresa = empresa;
            Obj.Telefono = telefono;
            Obj.Relacion = relacion;
            return Obj.Insertar(Obj);
        }

        public static string Actualizar(int idreflaboral, int idpersona, string empresa, string telefono, string relacion)
        {
            cReferenciaLaboral Obj = new cReferenciaLaboral();
            Obj.IdReflaboral = idreflaboral;
            Obj.IdPersona = idpersona;
            Obj.Empresa = empresa;
            Obj.Telefono = telefono;
            Obj.Relacion = relacion;
            return Obj.Actualizar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new cReferenciaLaboral().Mostrar();
        }

        public static DataTable Buscar(string persona)
        {
            cReferenciaLaboral Obj = new cReferenciaLaboral();
            Obj.Persona = persona;
            return Obj.Buscar(Obj);
        }

        public static string Eliminar(int idLaboral)
        {
            cReferenciaLaboral Obj = new cReferenciaLaboral();
            Obj.ID = idLaboral;
            return Obj.Eliminar(Obj);
        }

    }
}
