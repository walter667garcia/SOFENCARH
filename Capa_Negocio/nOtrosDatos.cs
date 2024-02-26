using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nOtrosDatos
    {

        public static string Insertar(
            int idpersona, 
            string trabajoenca,
            DateTime fechat, 
            string puesto,
            string solicitudenca,
            DateTime fechas,
            string plaza,
            string disponibilidad,
            string familiaEnca,
            string familiaEncaactual,
            string encaRelacion,
            string puestoConocido,
            string plazaVacante

             )
        {
            cOtrosDatos Obj = new cOtrosDatos();
            Obj.IdPersona = idpersona;
            Obj.TRABAJOENCA = trabajoenca;
            Obj.FECHAT = fechat;
            Obj.PUESTO = puesto;
            Obj.SOLICITUDENCA = solicitudenca;
            Obj.FECHAS = fechas;
            Obj.PLAZA = plaza;
            Obj.DISPONIBILIDAD = disponibilidad;
            Obj.FAMILIAR_ENCA = familiaEnca;
            Obj.FAMILIAR_ENCA_ACTUAL = familiaEncaactual;
            Obj.ENCA_RELACION = encaRelacion;
            Obj.PUESTO_CONOCIDO = puestoConocido;
            Obj.PLAZA_VACANTE = plazaVacante;

            return Obj.Insertar(Obj);
        }

        public static string Actualizar(
            int idotros,
            int idpersona,
            string trabajoenca,
            DateTime fechat,
            string puesto,
            string solicitudenca,
            DateTime fechas,
            string plaza,
            string disponibilidad,
            string familiaEnca,
            string familiaEncaactual,
            string encaRelacion,
            string puestoConocido,
            string plazaVacante
            )
        {
            cOtrosDatos Obj = new cOtrosDatos();
            Obj.IDOTROS = idotros;
            Obj.IdPersona = idpersona;
            Obj.TRABAJOENCA = trabajoenca;
            Obj.FECHAT = fechat;
            Obj.PUESTO = puesto;
            Obj.SOLICITUDENCA = solicitudenca;
            Obj.FECHAS = fechas;
            Obj.PLAZA = plaza;
            Obj.DISPONIBILIDAD = disponibilidad;
            Obj.FAMILIAR_ENCA = familiaEnca;
            Obj.FAMILIAR_ENCA_ACTUAL = familiaEncaactual;
            Obj.ENCA_RELACION = encaRelacion;
            Obj.PUESTO_CONOCIDO = puestoConocido;
            Obj.PLAZA_VACANTE = plazaVacante;
            return Obj.Actualizar(Obj);
        }


        public static DataTable Mostar()
        {
            return new cOtrosDatos().Mostrar();
        }

        public static DataTable Buscar(string persona)
        {
            cOtrosDatos Obj = new cOtrosDatos();
            Obj.Persona = persona;
            return Obj.Buscar(Obj);
        }

        public static string Eliminar(int idOtros)
        {
            cOtrosDatos Obj = new cOtrosDatos();
            Obj.ID = idOtros;
            return Obj.Eliminar(Obj);
        }

    }
}
