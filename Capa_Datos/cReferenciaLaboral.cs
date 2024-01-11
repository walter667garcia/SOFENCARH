using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cReferenciaLaboral
    {
        // Propiedades
        public int IDREFLABORAL { get; set; }
        public int IdPersona { get; set; }
        public string EMPRESA { get; set; }
        public string TELEFONO { get; set; }
        public string RELACION { get; set; }

        // Constructor vacío
        public cReferenciaLaboral()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cReferenciaLaboral(int idPersona, string empresa, string telefono, string relacion)
        {
            IdPersona = idPersona;
            EMPRESA = empresa;
            TELEFONO = telefono;
            RELACION = relacion;
        }
    }
}
