using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cPersona
    {
        private int _idPersona;
        private string _P_NOMBRE;
        private string _S_NOMBRE;
        private string _T_NOMBRE;
        private string _P_APELLIDO;
        private string _S_APELLIDO;
        private string _C_APELLIDO;
        private string _EDAD;
        private string _PRETENCION_SALARIO;
        private int _ID_ESTADO_CIVIL;
        private string _L_NACIMIENTO;
        private DateTime _F_NACIMIENTO;
        private int _ID_GENERO;
        private int _ID_ETNIA;
        private string _NACIONALIDAD;
        private int _ID_RELIGION;
        private string _DPI;
        private int _ID_MUNICIPIO;
        private string _IGSS;
        private string _NIT;
        private byte[] _Foto;
        private string _LICENCIA;
        private string _TIPO_LICENCIA;
        private string _persona;

        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public string P_NOMBRE
        {
            get { return _P_NOMBRE; }
            set { _P_NOMBRE = value; }
        }

        public string S_NOMBRE
        {
            get { return _S_NOMBRE; }
            set { _S_NOMBRE = value; }
        }

        public string T_NOMBRE
        {
            get { return _T_NOMBRE; }
            set { _T_NOMBRE = value; }
        }

        public string P_APELLIDO
        {
            get { return _P_APELLIDO; }
            set { _P_APELLIDO = value; }
        }

        public string S_APELLIDO
        {
            get { return _S_APELLIDO; }
            set { _S_APELLIDO = value; }
        }

        public string C_APELLIDO
        {
            get { return _C_APELLIDO; }
            set { _C_APELLIDO = value; }
        }

        public string EDAD
        {
            get { return _EDAD; }
            set { _EDAD = value; }
        }

        public string PRETENCION_SALARIO
        {
            get { return _PRETENCION_SALARIO; }
            set { _PRETENCION_SALARIO = value; }
        }

        public int ID_ESTADO_CIVIL
        {
            get { return _ID_ESTADO_CIVIL; }
            set { _ID_ESTADO_CIVIL = value; }
        }

        public string L_NACIMIENTO
        {
            get { return _L_NACIMIENTO; }
            set { _L_NACIMIENTO = value; }
        }

        public DateTime F_NACIMIENTO
        {
            get { return _F_NACIMIENTO; }
            set { _F_NACIMIENTO = value; }
        }

        public int ID_GENERO
        {
            get { return _ID_GENERO; }
            set { _ID_GENERO = value; }
        }

        public int ID_ETNIA
        {
            get { return _ID_ETNIA; }
            set { _ID_ETNIA = value; }
        }

        public string NACIONALIDAD
        {
            get { return _NACIONALIDAD; }
            set { _NACIONALIDAD = value; }
        }

        public int ID_RELIGION
        {
            get { return _ID_RELIGION; }
            set { _ID_RELIGION = value; }
        }

        public string DPI
        {
            get { return _DPI; }
            set { _DPI = value; }
        }

        public int ID_MUNICIPIO
        {
            get { return _ID_MUNICIPIO; }
            set { _ID_MUNICIPIO = value; }
        }

        public string IGSS
        {
            get { return _IGSS; }
            set { _IGSS = value; }
        }

        public string NIT
        {
            get { return _NIT; }
            set { _NIT = value; }
        }

        public byte[] Foto
        {
            get { return _Foto; }
            set { _Foto = value; }
        }

        public string LICENCIA
        {
            get { return _LICENCIA; }
            set { _LICENCIA = value; }
        }

        public string TIPO_LICENCIA
        {
            get { return _TIPO_LICENCIA; }
            set { _TIPO_LICENCIA = value; }
        }

        public string Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }

        // Constructor vacío
        public cPersona()
        {
        }

        // Constructor con parámetros
        public cPersona(int idPersona, string p_NOMBRE, string s_NOMBRE, string t_NOMBRE,
                        string p_APELLIDO, string s_APELLIDO, string c_APELLIDO,
                        string eDAD, string pRETENCION_SALARIO, int iD_ESTADO_CIVIL,
                        string l_NACIMIENTO, DateTime f_NACIMIENTO, int iD_GENERO,
                        int iD_ETNIA, string nACIONALIDAD, int iD_RELIGION,
                        string dPI, int iD_MUNICIPIO, string iGSS, string nIT,
                        byte[] foto, string lICENCIA, string tIPO_LICENCIA, string persona)
        {
            this.IdPersona = idPersona;
            this.P_NOMBRE = p_NOMBRE;
            this.S_NOMBRE = s_NOMBRE;
            this.T_NOMBRE = t_NOMBRE;
            this.P_APELLIDO = p_APELLIDO;
            this.S_APELLIDO = s_APELLIDO;
            this.C_APELLIDO = c_APELLIDO;
            this.EDAD = eDAD;
            this.PRETENCION_SALARIO = pRETENCION_SALARIO;
            this.ID_ESTADO_CIVIL = iD_ESTADO_CIVIL;
            this.L_NACIMIENTO = l_NACIMIENTO;
            this.F_NACIMIENTO = f_NACIMIENTO;
            this.ID_GENERO = iD_GENERO;
            this.ID_ETNIA = iD_ETNIA;
            this.NACIONALIDAD = nACIONALIDAD;
            this.ID_RELIGION = iD_RELIGION;
            this.DPI = dPI;
            this.ID_MUNICIPIO = iD_MUNICIPIO;
            this.IGSS = iGSS;
            this.NIT = nIT;
            this.Foto = foto;
            this.LICENCIA = lICENCIA;
            this.TIPO_LICENCIA = tIPO_LICENCIA;
            this.Persona = persona;
        }
        public string Insertar(cPersona persona)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarPersona", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@P_NOMBRE", persona.P_NOMBRE).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@S_NOMBRE", persona.S_NOMBRE).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@T_NOMBRE", persona.T_NOMBRE).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@P_APELLIDO", persona.P_APELLIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@S_APELLIDO", persona.S_APELLIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@C_APELLIDO", persona.C_APELLIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@EDAD", persona.EDAD).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PRETENCION_SALARIO", persona.PRETENCION_SALARIO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ID_ESTADO_CIVIL", persona.ID_ESTADO_CIVIL).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@L_NACIMIENTO", persona.L_NACIMIENTO).SqlDbType = SqlDbType.NVarChar;
                        cmd .Parameters.AddWithValue("@F_NACIMIENTO", F_NACIMIENTO).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@ID_GENERO", persona.ID_GENERO).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@ID_ETNIA", persona.ID_ETNIA).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@NACIONALIDAD", persona.NACIONALIDAD).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ID_RELIGION", persona.ID_RELIGION).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DPI", persona.DPI).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ID_MUNICIPIO", persona.ID_MUNICIPIO).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IGSS", persona.IGSS).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@NIT", persona.NIT).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Foto", persona.Foto).SqlDbType = SqlDbType.Image;
                        cmd.Parameters.AddWithValue("@LICENCIA", persona.LICENCIA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@TIPO_LICENCIA", persona.TIPO_LICENCIA).SqlDbType = SqlDbType.NVarChar;


                        rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No ingresó el registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }

        public string Actualizar(cPersona persona)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarPersona", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", persona.IdPersona).SqlDbType = SqlDbType.Int;  // Asegúrate de tener el IdPersona en tu clase cPersona.
                        cmd.Parameters.AddWithValue("@P_NOMBRE", persona.P_NOMBRE).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@S_NOMBRE", persona.S_NOMBRE).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@T_NOMBRE", persona.T_NOMBRE).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@P_APELLIDO", persona.P_APELLIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@S_APELLIDO", persona.S_APELLIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@C_APELLIDO", persona.C_APELLIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@EDAD", persona.EDAD).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PRETENCION_SALARIO", persona.PRETENCION_SALARIO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ID_ESTADO_CIVIL", persona.ID_ESTADO_CIVIL).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@L_NACIMIENTO", persona.L_NACIMIENTO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@F_NACIMIENTO", persona.F_NACIMIENTO).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@ID_GENERO", persona.ID_GENERO).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@ID_ETNIA", persona.ID_ETNIA).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@NACIONALIDAD", persona.NACIONALIDAD).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ID_RELIGION", persona.ID_RELIGION).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DPI", persona.DPI).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ID_MUNICIPIO", persona.ID_MUNICIPIO).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IGSS", persona.IGSS).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@NIT", persona.NIT).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Foto", persona.Foto).SqlDbType = SqlDbType.Image;
                        cmd.Parameters.AddWithValue("@LICENCIA", persona.LICENCIA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@TIPO_LICENCIA", persona.TIPO_LICENCIA).SqlDbType = SqlDbType.NVarChar;

                        rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }
        // Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHPersona";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        // Método Buscar
        public DataTable Buscar(cPersona persona)
        {
            DataTable DtResultado1 = new DataTable("RHIDIOMA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarPersona";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = persona.Persona;
                sqlcmd.Parameters.Add(ParBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

       
    }
}
