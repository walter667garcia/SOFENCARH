using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nActas
    {
        public static string Insertar(int idPersona, DateTime fechaIngreso, string puestoFuncional, int idCoordinacion, int idPuestoNominal, int idRenglon, int idUnidadSeccion, string salarioBase, string descripcion)
        {
            cActas obj = new cActas();

            obj.IDPERSONA = idPersona;
            obj.FECHA_INGRESO = fechaIngreso;
            obj.PUESTO_FUNCIONAL = puestoFuncional;
            obj.ID_COORDINACION = idCoordinacion;
            obj.ID_PUESTO_NOMINAL = idPuestoNominal;
            obj.ID_RENGLON = idRenglon;
            obj.IDUNIDAD_SECCION = idUnidadSeccion;
            obj.SALARIO_BASE = salarioBase;
            obj.DESCRIPCION = descripcion;

            return obj.Insertar();
        }

        public static string Actualizar(int idActa, int idPersona, DateTime fechaIngreso, string puestoFuncional, int idCoordinacion, int idPuestoNominal, int idRenglon, int idUnidadSeccion, string salarioBase, string descripcion)
        {
            cActas obj = new cActas();

            obj.ID_ACTA = idActa;
            obj.IDPERSONA = idPersona;
            obj.FECHA_INGRESO = fechaIngreso;
            obj.PUESTO_FUNCIONAL = puestoFuncional;
            obj.ID_COORDINACION = idCoordinacion;
            obj.ID_PUESTO_NOMINAL = idPuestoNominal;
            obj.ID_RENGLON = idRenglon;
            obj.IDUNIDAD_SECCION = idUnidadSeccion;
            obj.SALARIO_BASE = salarioBase;
            obj.DESCRIPCION = descripcion;

            return obj.Actualizar();
        }

        public static DataTable MostrarActas()
        {
            return new cActas().Mostrar();
        }
        public static DataTable Buscar(string textoBuscar)
        {

            cActas obj = new cActas();
            obj.Persona = textoBuscar;
            return obj.Buscar(obj);
        }

    }
}
