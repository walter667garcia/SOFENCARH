using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class nNivelAcademico
    {

        public static DataTable Mostrar()
        {
            return new cNivelAcademico().Mostrar();
        }

        public static DataTable Buscar(string textoBuscar)
        {
            cNivelAcademico obj = new cNivelAcademico();
            obj.Persona = textoBuscar;
            return obj.Buscar(obj);
        }

        public static string Insertar( int idpersona, int idAcademico,
            string establecimiento, DateTime dFecha, DateTime aFecha,
            string titulo, string especialidad)
        {
            cNivelAcademico Obj = new cNivelAcademico();
            Obj.Id_Persona = idpersona;
            Obj.Id_Academico = idAcademico;
            Obj.Establecimiento = establecimiento;
            Obj.Fecha_Inicio = dFecha;
            Obj.Fecha_Outicio = aFecha;
            Obj.Titulo = titulo;
            Obj.Especialidad = especialidad;
            
            return Obj.Insertar(Obj);
        }

        public static string Actualizar(int idNivel,int idpersona, int idAcademico,
          string establecimiento, DateTime dFecha, DateTime aFecha,
          string titulo, string especialidad)
        {
            cNivelAcademico Obj = new cNivelAcademico();
            Obj.Id_Nivel = idNivel;
            Obj.Id_Persona = idpersona;
            Obj.Id_Academico = idAcademico;
            Obj.Establecimiento = establecimiento;
            Obj.Fecha_Inicio = dFecha;
            Obj.Fecha_Outicio = aFecha;
            Obj.Titulo = titulo;
            Obj.Especialidad = especialidad;

            return Obj.Actualizar(Obj);
        }

    }
}
