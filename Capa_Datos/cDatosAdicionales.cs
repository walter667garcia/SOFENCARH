using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cDatosAdicionales
    {
        // Propiedades automáticas
        public int IDDATOSADI { get; set; }
        public int IdPersona { get; set; }
        public string EMERGENCIAS { get; set; }
        public string PARENTESCO { get; set; }
        public string TELEFONO { get; set; }

        // Constructor vacío
        public cDatosAdicionales()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cDatosAdicionales(int idPersona, string emergencias, string parentesco, string telefono)
        {
            IdPersona = idPersona;
            EMERGENCIAS = emergencias;
            PARENTESCO = parentesco;
            TELEFONO = telefono;
        }
    }
}
