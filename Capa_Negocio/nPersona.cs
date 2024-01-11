using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nPersona
    {
        public static string InsertarPersona(
    string P_NOMBRE, string S_NOMBRE, string T_NOMBRE,
    string P_APELLIDO, string S_APELLIDO, string C_APELLIDO,
    string EDAD, string PRETENCION_SALARIO, int ID_ESTADO_CIVIL,
    string L_NACIMIENTO, DateTime F_NACIMIENTO, int ID_GENERO,
    int ID_ETNIA, string NACIONALIDAD, int ID_RELIGION,
    string DPI, int ID_MUNICIPIO, string IGSS, string NIT,
    byte[] Foto, string LICENCIA, string TIPO_LICENCIA)
        {
            cPersona persona = new cPersona
            {
                P_NOMBRE = P_NOMBRE,
                S_NOMBRE = S_NOMBRE,
                T_NOMBRE = T_NOMBRE,
                P_APELLIDO = P_APELLIDO,
                S_APELLIDO = S_APELLIDO,
                C_APELLIDO = C_APELLIDO,
                EDAD = EDAD,
                PRETENCION_SALARIO = PRETENCION_SALARIO,
                ID_ESTADO_CIVIL = ID_ESTADO_CIVIL,
                L_NACIMIENTO = L_NACIMIENTO,
                F_NACIMIENTO = F_NACIMIENTO,
                ID_GENERO = ID_GENERO,
                ID_ETNIA = ID_ETNIA,
                NACIONALIDAD = NACIONALIDAD,
                ID_RELIGION = ID_RELIGION,
                DPI = DPI,
                ID_MUNICIPIO = ID_MUNICIPIO,
                IGSS = IGSS,
                NIT = NIT,
                Foto = Foto,
                LICENCIA = LICENCIA,
                TIPO_LICENCIA = TIPO_LICENCIA
            };

            return persona.Insertar(persona);
        }



        public static DataTable Buscar(string textoBuscar)
        {

            cPersona obj = new cPersona();
            obj.Persona = textoBuscar;
            return obj.Buscar(obj);
        }

        public static DataTable MostrarPersonas()
        {
            return new cPersona().Mostrar();
        }

        public static string EditarPersona(
    int idPersona,
    string p_NOMBRE,
    string s_NOMBRE,
    string t_NOMBRE,
    string p_APELLIDO,
    string s_APELLIDO,
    string c_APELLIDO,
    string eDAD,
    string pRETENCION_SALARIO,
    int iD_ESTADO_CIVIL,
    string l_NACIMIENTO,
    DateTime f_NACIMIENTO,
    int iD_GENERO,
    int iD_ETNIA,
    string nACIONALIDAD,
    int iD_RELIGION,
    string dPI,
    int iD_MUNICIPIO,
    string iGSS,
    string nIT,
    byte[] foto,
    string lICENCIA,
    string tIPO_LICENCIA)
        {
            cPersona Obj = new cPersona();
            Obj.IdPersona = idPersona;
            Obj.P_NOMBRE = p_NOMBRE;
            Obj.S_NOMBRE = s_NOMBRE;
            Obj.T_NOMBRE = t_NOMBRE;
            Obj.P_APELLIDO = p_APELLIDO;
            Obj.S_APELLIDO = s_APELLIDO;
            Obj.C_APELLIDO = c_APELLIDO;
            Obj.EDAD = eDAD;
            Obj.PRETENCION_SALARIO = pRETENCION_SALARIO;
            Obj.ID_ESTADO_CIVIL = iD_ESTADO_CIVIL;
            Obj.L_NACIMIENTO = l_NACIMIENTO;
            Obj.F_NACIMIENTO = f_NACIMIENTO;
            Obj.ID_GENERO = iD_GENERO;
            Obj.ID_ETNIA = iD_ETNIA;
            Obj.NACIONALIDAD = nACIONALIDAD;
            Obj.ID_RELIGION = iD_RELIGION;
            Obj.DPI = dPI;
            Obj.ID_MUNICIPIO = iD_MUNICIPIO;
            Obj.IGSS = iGSS;
            Obj.NIT = nIT;
            Obj.Foto = foto;
            Obj.LICENCIA = lICENCIA;
            Obj.TIPO_LICENCIA = tIPO_LICENCIA;

            return Obj.Actualizar(Obj);
        }


    }
}
