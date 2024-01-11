using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nPuestoFuncional
    {
        public static string InsertarPuestoFuncional(
        string PuestoFuncional, int IdRenglon, int IdPuestoNominal, int IdUnidadSeccion, string SalarioBase)
        {
            cPuestoFuncional puestoFuncional = new cPuestoFuncional
            {
                PuestoFuncional = PuestoFuncional,
                IdRenglon = IdRenglon,
                IdPuestoNominal = IdPuestoNominal,
                IdUnidadSeccion = IdUnidadSeccion,
                SalarioBase = SalarioBase
            };

            return puestoFuncional.Insertar(puestoFuncional);
        }

        public static DataTable Buscar(string textoBuscar)
        {
            cPuestoFuncional obj = new cPuestoFuncional();
            obj.Puesto = textoBuscar;
            return obj.Buscar(obj);
        }

        public static DataTable MostrarPuestosFuncionales()
        {
            return new cPuestoFuncional().Mostrar();
        }

        public static string EditarPuestoFuncional(
            int idPuestoFuncional, string PuestoFuncional, int IdRenglon, int IdPuestoNominal, int IdUnidadSeccion, string SalarioBase)
        {
            cPuestoFuncional Obj = new cPuestoFuncional();
            Obj.IdPuestoFuncional = idPuestoFuncional;
            Obj.PuestoFuncional = PuestoFuncional;
            Obj.IdRenglon = IdRenglon;
            Obj.IdPuestoNominal = IdPuestoNominal;
            Obj.IdUnidadSeccion = IdUnidadSeccion;
            Obj.SalarioBase = SalarioBase;

            return Obj.Actualizar(Obj);
        }
    }
}
