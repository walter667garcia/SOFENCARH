using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nSocioEconomico
    {


        public static string Insertar(
        int idPersona,
        int idAgrupacion,
        string detalleAgrupacion,
        string dependientes,
        string detalleDependientes,
        int idVivienda,
        string pagoVivienda,
        string flagDeudas,  
        string montoDeuda,
        string motivoDeuda,
        string flagOtrosIngresos,
        string montoOtrosIngresos,
        string fuentesOtrosIngresos,
        int idVehiculo,
        string tipoVehiculo,
        string modeloVehiculo,
        string placaVehiculo)
        {
            cSocioEconomico obj = new cSocioEconomico();
            obj.IdPersona = idPersona;
            obj.IdAgrupacion = idAgrupacion;
            obj.DetalleAgrupacion = detalleAgrupacion;
            obj.Dependientes = dependientes;
            obj.DetalleDependientes = detalleDependientes;
            obj.IdVivienda = idVivienda;
            obj.PagoVivienda = pagoVivienda;
            obj.FlagDeudas = flagDeudas;
            obj.MontoDeuda = montoDeuda;
            obj.MotivoDeuda = motivoDeuda;
            obj.FlagOtrosIngresos = flagOtrosIngresos;
            obj.MontoOtrosIngresos = montoOtrosIngresos;
            obj.FuentesOtrosIngresos = fuentesOtrosIngresos;
            obj.IdVehiculo = idVehiculo;
            obj.TipoVehiculo = tipoVehiculo;
            obj.ModeloVehiculo = modeloVehiculo;
            obj.PlacaVehiculo = placaVehiculo;

            return obj.Insertar(obj);
        }

        public static DataTable BuscarSocioEconomico(string textoBuscar)
        {
            cSocioEconomico obj = new cSocioEconomico();
            obj.Persona = textoBuscar;
            return obj.Buscar(obj);
        }

        public static DataTable MostrarSocioEconomico()
        {
            return new cSocioEconomico().Mostrar();
        }


        public static string Actualizar(
       int idSocio,
       int idPersona,
       int idAgrupacion,
       string detalleAgrupacion,
       string dependientes,
       string detalleDependientes,
       int idVivienda,
       string pagoVivienda,
       string flagDeudas,
       string montoDeuda,
       string motivoDeuda,
       string flagOtrosIngresos,
       string montoOtrosIngresos,
       string fuentesOtrosIngresos,
       int idVehiculo,
       string tipoVehiculo,
       string modeloVehiculo,
       string placaVehiculo)
        {
            cSocioEconomico obj = new cSocioEconomico();

            obj.IdSocio = idSocio;
            obj.IdPersona = idPersona;
            obj.IdAgrupacion = idAgrupacion;
            obj.DetalleAgrupacion = detalleAgrupacion;
            obj.Dependientes = dependientes;
            obj.DetalleDependientes = detalleDependientes;
            obj.IdVivienda = idVivienda;
            obj.PagoVivienda = pagoVivienda;
            obj.FlagDeudas = flagDeudas;        
            obj.MontoDeuda = montoDeuda;
            obj.MotivoDeuda = motivoDeuda;
            obj.FlagOtrosIngresos = flagOtrosIngresos;
            obj.MontoOtrosIngresos = montoOtrosIngresos;
            obj.FuentesOtrosIngresos = fuentesOtrosIngresos;
            obj.IdVehiculo = idVehiculo;
            obj.TipoVehiculo = tipoVehiculo;
            obj.ModeloVehiculo = modeloVehiculo;
            obj.PlacaVehiculo = placaVehiculo;

            return obj.Actualizar(obj);
        }


        public static string Eliminar(int idEconomico)
        {
            cSocioEconomico Obj = new cSocioEconomico();
            Obj.ID = idEconomico;
            return Obj.Eliminar(Obj);
        }


    }
}
