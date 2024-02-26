using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nExperienciaLaboral
    {
        public static string Insertar(
            int idpersona, string empresa,string telefono,
            string jefe, string puesto,string salario,
            DateTime fechaIngreso,
            DateTime fechaRetiro,
            string motivoRetiro,
            string referencias,
            string descripcion)
        {
            cExperienciaLaboral Obj = new cExperienciaLaboral();
            Obj.IdPersona = idpersona;
            Obj.EMPRESA = empresa;
            Obj.TELEFONO = telefono;
            Obj.JEFE = jefe;
            Obj.SALARIO = salario;
            Obj.PUESTO = puesto;
            Obj.FECHA_INGRESO = fechaIngreso;
            Obj.FECHA_RETIRO = fechaRetiro;
            Obj.MOTIVO_RETIRO = motivoRetiro;
            Obj.REFERENCIAS = referencias;
            Obj.DESCRIPCION = descripcion;

            return Obj.Insertar(Obj);

        }

        public static string Actualizar(
            int idexperiencia,
            int idpersona, 
            string empresa,
            string telefono,
            string jefe, string puesto,
            string salario,
            DateTime fechaIngreso,
            DateTime fechaRetiro,
            string motivoRetiro,
            string referencias,
            string descripcion)
        {
            cExperienciaLaboral Obj = new cExperienciaLaboral();

            Obj.IDEXPERIENCIA = idexperiencia;
            Obj.IdPersona = idpersona;
            Obj.EMPRESA = empresa;
            Obj.TELEFONO = telefono;
            Obj.JEFE = jefe;
            Obj.PUESTO = puesto;
            Obj.SALARIO = salario;
            Obj.FECHA_INGRESO = fechaIngreso;
            Obj.FECHA_RETIRO = fechaRetiro;
            Obj.MOTIVO_RETIRO = motivoRetiro;
            Obj.REFERENCIAS = referencias;
            Obj.DESCRIPCION = descripcion;

            return Obj.Actualizar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new cExperienciaLaboral().Mostrar();
        }

        public static DataTable Buscar(string persona)
        {
            cExperienciaLaboral Obj = new cExperienciaLaboral();
            Obj.Persona = persona;
            return Obj.Buscar(Obj);
        }

        public static string Eliminar(int idExperiencia)
        {
            cExperienciaLaboral Obj = new cExperienciaLaboral();
            Obj.ID = idExperiencia;
            return Obj.Eliminar(Obj);
        }

    }
}
