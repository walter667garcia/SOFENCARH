using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public   class cReferenciaPersonal
    {
        // Propiedades automáticas
        public int IDREFPERSONAL { get; set; }
        public int IdPersona { get; set; }
        public string NOMBRE { get; set; }
        public string TELEFONO { get; set; }
        public string RELACION { get; set; }

        // Constructor vacío
        public cReferenciaPersonal()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cReferenciaPersonal(int idPersona, string nombre, string telefono, string relacion)
        {
            IdPersona = idPersona;
            NOMBRE = nombre;
            TELEFONO = telefono;
            RELACION = relacion;
        }
    }
}
