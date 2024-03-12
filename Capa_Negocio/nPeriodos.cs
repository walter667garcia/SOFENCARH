using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nPeriodos
    {
        public static DataTable MostrarPeriodos(int idPersona)
        {
            cPeriodos Obj = new cPeriodos();
            Obj.Persona = idPersona;
            return Obj.MostrarPeriodos(Obj);
  
        }

        // Método para insertar un nuevo registro
        public static string Insertar(
            int idPersona,
            string periodo,
            DateTime fechaInicio,
            DateTime fechaFin,
            int diasDisponibles,
            int diasTomados,
            int diasRestantes,
            bool estado)
        {
            try
            {
                // Crear una instancia de la clase RHPERIODO
                cPeriodos Obj = new cPeriodos();

                // Establecer las propiedades del objeto con los valores proporcionados
                Obj.IDPERSONA = idPersona;
                Obj.PERIODO = periodo;
                Obj.FECHA_INICIO = fechaInicio;
                Obj.FECHA_FIN = fechaFin;
                Obj.DIAS_DISPONIBLES = diasDisponibles;
                Obj.DIAS_TOMADOS = diasTomados;
                Obj.DIAS_RESTANTES = diasRestantes;
                Obj.ESTADO = estado;

                // Llamar al método de inserción en la instancia de la clase RHPERIODO
                return Obj.Insertar(Obj);
            }
            catch (Exception ex)
            {
                return "Error al insertar el registro: " + ex.Message;
            }
        }
        public static string ActualizarEstado(int idPeriodo, bool estado)
        {
            cPeriodos Obj = new cPeriodos();
            return Obj.ActualizarEstado(idPeriodo,estado);

        }
        public static DataTable MostrarPersonas()
        {
            return new cPeriodos().MostrarPersonas();
        }

    }
}
