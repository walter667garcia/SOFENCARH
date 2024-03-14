using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nVacaciones
    {
        public static DataTable MostrarVacaciones(int id)
        {
            cVacaciones Obj = new cVacaciones();
            Obj.Id = id;
            return Obj.Mostrar(Obj);
        }

        public static DataTable BuscarPersona(string textoBuscar)
        {

            cVacaciones obj = new cVacaciones();
            obj.Persona = textoBuscar;
            return obj.BuscarPersona(obj);
        }

        public static string DescontarPeriodo(int idPeriodo, int diasD, int diasT, int diasR)
        {
            cVacaciones Obj = new cVacaciones();
            return Obj.DescontarPeriodos(idPeriodo, diasD, diasT, diasR);

        }

        public static string InsertarVacaciones(int idpersona, int idperiodo, DateTime fechaInicio, 
            DateTime fechafin, int diasF, int diasT ,string descripcion )
        {
            cVacaciones Obj = new cVacaciones();
            Obj.IDPERSONA = idpersona;
            Obj.ID_PERIODO = idperiodo;
            Obj.FECHA_INICIO = fechaInicio;
            Obj.FECHA_FIN = fechafin;
            Obj.DIAS_FESTIVOS = diasF;
            Obj.DIAS_TOMADOS = diasT;
            Obj.DESCRIPCION = descripcion;
            return Obj.Insertar();
        }
    }
}
