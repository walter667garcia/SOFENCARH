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
        

        public int IdPersona { get; set; }
      
        public string P_NOMBRE { get; set; }
 
        public string S_NOMBRE { get; set; }

        public string T_NOMBRE { get; set; }

        public string P_APELLIDO { get; set; }

        public string S_APELLIDO { get; set; }

        public string C_APELLIDO { get; set; }

        public string EDAD { get; set; }

        public int ID_ESTADO_CIVIL { get; set; }

        public string L_NACIMIENTO { get; set; }

        public DateTime F_NACIMIENTO { get; set; }

        public int ID_GENERO { get; set; }

        public int ID_ETNIA { get; set; }

        public string NACIONALIDAD { get; set; }

        public int ID_RELIGION { get; set; }

        public string DPI { get; set; }

        public int ID_MUNICIPIO { get; set; }

        public string IGSS { get; set; }

        public string NIT { get; set; }

        public byte[] Foto { get; set; }

        public string LICENCIA { get; set; }

        public string TIPO_LICENCIA { get; set; }

        public string Persona { get; set; }

        public string Municipio { get; set; }

        public string Departamento { get; set; }
       



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
                        byte[] foto, string lICENCIA, string tIPO_LICENCIA, string persona, string municipio, string departamento)
        {
            IdPersona = idPersona;
            P_NOMBRE = p_NOMBRE;
            S_NOMBRE = s_NOMBRE;
            T_NOMBRE = t_NOMBRE;
            P_APELLIDO = p_APELLIDO;
            S_APELLIDO = s_APELLIDO;
            C_APELLIDO = c_APELLIDO;
            EDAD = eDAD;
            ID_ESTADO_CIVIL = iD_ESTADO_CIVIL;
            L_NACIMIENTO = l_NACIMIENTO;
            F_NACIMIENTO = f_NACIMIENTO;
            ID_GENERO = iD_GENERO;
            ID_ETNIA = iD_ETNIA;
            NACIONALIDAD = nACIONALIDAD;
            ID_RELIGION = iD_RELIGION;
            DPI = dPI;
            ID_MUNICIPIO = iD_MUNICIPIO;
            IGSS = iGSS;
            NIT = nIT;
            Foto = foto;
            LICENCIA = lICENCIA;
            TIPO_LICENCIA = tIPO_LICENCIA;
            Persona = persona;
            Municipio = municipio;
            Departamento = departamento;
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
                        cmd.Parameters.AddWithValue("@DEPARTAMENTO", persona.Departamento).SqlDbType = SqlDbType.NVarChar;

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
                        cmd.Parameters.AddWithValue("@DEPARTAMENTO", persona.Departamento).SqlDbType = SqlDbType.NVarChar;

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

        public DataTable BuscarMunicipio(cPersona municipio)
        {
            DataTable DtResultado1 = new DataTable("TYMUNICIPIO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarMunicipioPersona";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Departamento";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = municipio.Municipio;
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

        public DataTable BuscarDepartamento(cPersona departamento)
        {
            DataTable DtResultado1 = new DataTable("TYMUNICIPIO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "BuscarDepartamento";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Municipio";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 25;
                ParBuscar.Value = departamento.Departamento;
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
