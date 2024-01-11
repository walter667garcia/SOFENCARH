using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cOtrosDatos
    {
        // Propiedades automáticas
        public int IDOTROS { get; set; }
        public int IdPersona { get; set; }
        public string TRABAJOENCA { get; set; }
        public DateTime FECHAT { get; set; }
        public string PUESTO { get; set; }
        public string SOLICITUDENCA { get; set; }
        public DateTime FECHAS { get; set; }
        public string PLAZA { get; set; }
        public string DISPONIBILIDAD { get; set; }
        public string FAMILIAR_ENCA { get; set; }
        public string FAMILIAR_ENCA_ACTUAL { get; set; }
        public string ENCA_RELACION { get; set; }
        public string PUESTO_CONOCIDO { get; set; }
        public string PLAZA_VACANTE { get; set; }

        // Constructor vacío
        public cOtrosDatos()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cOtrosDatos(int idPersona, string trabajoEnca, DateTime fechaT, string puesto, string solicitudEnca,
                          DateTime fechaS, string plaza, string disponibilidad, string familiarEnca,
                          string familiarEncaActual, string encaRelacion, string puestoConocido, string plazaVacante)
        {
            IdPersona = idPersona;
            TRABAJOENCA = trabajoEnca;
            FECHAT = fechaT;
            PUESTO = puesto;
            SOLICITUDENCA = solicitudEnca;
            FECHAS = fechaS;
            PLAZA = plaza;
            DISPONIBILIDAD = disponibilidad;
            FAMILIAR_ENCA = familiarEnca;
            FAMILIAR_ENCA_ACTUAL = familiarEncaActual;
            ENCA_RELACION = encaRelacion;
            PUESTO_CONOCIDO = puestoConocido;
            PLAZA_VACANTE = plazaVacante;
        }
    }
}
