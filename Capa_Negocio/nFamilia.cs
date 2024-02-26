using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nFamilia
    {

        public static string EditarFamilia(
    int id,
    int idPersona,
    int idTipoFamilia,
    string nombre,
    DateTime fNacimiento,
    string ocupacion,
    string telefono,
    string lTrabajo,
    string dTrabajo,
    string tTrabajo)
        {
            // Crear una instancia de la clase Familia (suponiendo que ya tienes una)
            cFamilia obj = new cFamilia();

            // Establecer las propiedades del objeto con los valores proporcionados
            obj.Id_Familia = id;
            obj.IdPersona = idPersona;
            obj.IdTipo_Familia = idTipoFamilia;
            obj.Nombre = nombre;
            obj.F_nacimiento = fNacimiento;
            obj.Ocupacion = ocupacion;
            obj.Telefono = telefono;
            obj.L_trabajo = lTrabajo;
            obj.D_trabajo = dTrabajo;
            obj.T_trabajo = tTrabajo;

            // Llamar al método de actualización en la clase Familia (debes tener este método)
            return obj.Actualizar(obj);
        }

        public static DataTable Buscar(string textoBuscar)
        {

            cFamilia obj = new cFamilia();
            obj.Persona = textoBuscar;
            return obj.Buscar(obj);
        }

        public static DataTable MostrarPersonas()
        {
            return new cFamilia().Mostrar();
        }


        public static string Insertar(
                  int idPersona,
                   int idTipoFamilia,
                 string nombre,
                  DateTime fNacimiento,
              string ocupacion,
                string telefono,
               string lTrabajo,
            string dTrabajo,
                    string tTrabajo)
              {
            // Crear una instancia de la clase Familia (suponiendo que ya tienes una)
            cFamilia obj = new cFamilia();

            // Establecer las propiedades del objeto con los valores proporcionados
          
            obj.IdPersona = idPersona;
            obj.IdTipo_Familia = idTipoFamilia;
            obj.Nombre = nombre;
            obj.F_nacimiento = fNacimiento;
            obj.Ocupacion = ocupacion;
            obj.Telefono = telefono;
            obj.L_trabajo = lTrabajo;
            obj.D_trabajo = dTrabajo;
            obj.T_trabajo = tTrabajo;

            // Llamar al método de actualización en la clase Familia (debes tener este método)
            return obj.Insertar(obj);
        }


        public static string Eliminar(int idFamilia)
        {
            cFamilia Obj = new cFamilia();
            Obj.ID = idFamilia;
            return Obj.Eliminar(Obj);
        }
    }

    



}
