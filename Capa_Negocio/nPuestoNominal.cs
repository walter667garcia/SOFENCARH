using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nPuestoNominal
    {


        public static string Insertar(string puestoNominal)
        {
            cPuestoNominal Obj = new cPuestoNominal();
            Obj.PuestoNominal = puestoNominal;
            
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idPuestoNominal, string puestoNominal)
        {
            cPuestoNominal Obj = new cPuestoNominal();
            Obj.IdPuestoNominal = idPuestoNominal;
            Obj.PuestoNominal = puestoNominal;
            

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idPuestoNominal)
        {
            cPuestoNominal Obj = new cPuestoNominal();
            Obj.IdPuestoNominal = idPuestoNominal;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new cPuestoNominal().Mostrar();
        }

        public static DataTable Buscar(string textoBuscar)
        {
            cPuestoNominal obj = new cPuestoNominal();
            obj.TextoBuscar = textoBuscar;
            return obj.BuscarPuestoNominal(obj);
        }
    }
}
