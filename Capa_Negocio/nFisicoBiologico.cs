using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nFisicoBiologico
    {
        public static string Insertar(
            int idPersona, string enfermedad, 
            string diabetes, string accidente,
            string operacion, string alergias, 
            string tratamiento, string especifique,
            string lentes,string auditivo, string discapacidad,
            string drogras, string alcohol, string fuma, string peso,
            string estatura, string sangre, string pasatiempos, 
            string deportes)
        {

            cFisicoBiologicos Obj = new cFisicoBiologicos();
            Obj.IdPersona = idPersona;
            Obj.ENFERMEDAD = enfermedad;
            Obj.DIABETES = diabetes;
            Obj.ACCIDENTE = accidente;
            Obj.OPERACION = operacion;
            Obj.ALERGIAS = alergias;
            Obj.TRATAMIENTO = tratamiento;
            Obj.ESPECIFIQUE = especifique;
            Obj.LENTES = lentes;
            Obj.AUDITIVO = auditivo;
            Obj.DISCAPACIDAD    = discapacidad;
            Obj.DROGRAS = drogras;
            Obj.ALCOHOL = alcohol;
            Obj.FUMA = fuma;
            Obj.PESO = peso;
            Obj.ESTATURA = estatura;
            Obj.SANGRE = sangre;
            Obj.PASATIEMPOS = pasatiempos;
            Obj.DEPORTES = deportes;
             return Obj.InsertarFisicoBiologico( Obj );


        }
                    
    

        public static string Actualizar(int idFisicoBiologico, int idPersona, string enfermedad, string diabetes, string accidente,
            string operacion, string alergias, string tratamiento, string especifique, string lentes,
            string auditivo, string discapacidad, string drogras, string alcohol, string fuma, string peso,
            string estatura, string sangre, string pasatiempos, string deportes)
        {
            cFisicoBiologicos Obj = new cFisicoBiologicos();
            Obj.IDFISICABIO = idFisicoBiologico;
            Obj.IdPersona = idPersona;
            Obj.ENFERMEDAD = enfermedad;
            Obj.DIABETES = diabetes;
            Obj.ACCIDENTE = accidente;
            Obj.OPERACION = operacion;
            Obj.ALERGIAS = alergias;
            Obj.TRATAMIENTO = tratamiento;
            Obj.ESPECIFIQUE = especifique;
            Obj.LENTES = lentes;
            Obj.AUDITIVO = auditivo;
            Obj.DISCAPACIDAD = discapacidad;
            Obj.DROGRAS = drogras;
            Obj.ALCOHOL = alcohol;
            Obj.FUMA = fuma;
            Obj.PESO = peso;
            Obj.ESTATURA = estatura;
            Obj.SANGRE = sangre;
            Obj.PASATIEMPOS = pasatiempos;
            Obj.DEPORTES = deportes;
            return Obj.ActualizarFisicoBiologico(Obj);

        }

        public static DataTable Buscar(string persona)
        {

            cFisicoBiologicos obj = new cFisicoBiologicos();
            obj.Persona = persona;
            return obj.Buscar(obj);
        }

        public static DataTable Mostrar()
        {
            return new cFisicoBiologicos().Mostrar();
        }

    }
}
