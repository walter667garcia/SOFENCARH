using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cVacaciones
    {
        // Propiedades
        public int ID_VACACIONES { get; set; }
        public int IDPERSONA { get; set; }
        public int ID_PERIODO { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_FIN { get; set; }
        public int DIAS_FESTIVOS { get; set; }
        public int DIAS_TOMADOS { get; set; }
        public string DESCRIPCION { get; set; }

        public int Id {  get; set; }

        public string Persona {  get; set; }
        // Constructor por defecto
        public cVacaciones()
        {
        }

        // Constructor con parámetros
        public cVacaciones(int idVacaciones, int idPersona, int idPeriodo, DateTime fechaInicio, DateTime fechaFin, int diasFestivos, int diasTomados, string descripcion, string persona)
        {
            ID_VACACIONES = idVacaciones;
            IDPERSONA = idPersona;
            ID_PERIODO = idPeriodo;
            FECHA_INICIO = fechaInicio;
            FECHA_FIN = fechaFin;
            DIAS_FESTIVOS = diasFestivos;
            DIAS_TOMADOS = diasTomados;
            DESCRIPCION = descripcion;
            Persona = persona;
        }

        public DataTable Mostrar(cVacaciones vacaciones)
        {
            DataTable DtResultado1 = new DataTable("RHVACACIONES");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarVacacionesHistorial";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@ID";
                ParBuscar.SqlDbType = SqlDbType.Int;
                ParBuscar.Value = vacaciones.Id;
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

        public DataTable BuscarPersona(cVacaciones persona)
        {
            DataTable DtResultado1 = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarVacacionesPersonaId";
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

        public string DescontarPeriodos(int idPeriodo, int diasD, int diasT, int diasR)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_RestarRHPeriodos", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", idPeriodo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DiasD", diasD).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DiasT", diasT).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DiasR", diasR).SqlDbType = SqlDbType.Int;
                       

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        rpta = filasAfectadas > 0 ? "OK" : "No se actualizó ningún registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }

        public string Insertar()
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarHistorialVacaciones", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPERSONA", IDPERSONA);
                        cmd.Parameters.AddWithValue("@ID_PERIODO", ID_PERIODO);
                        cmd.Parameters.AddWithValue("@FECHA_INICIO", FECHA_INICIO);
                        cmd.Parameters.AddWithValue("@FECHA_FIN", FECHA_FIN);
                        cmd.Parameters.AddWithValue("@DIAS_FESTIVOS", DIAS_FESTIVOS);
                        cmd.Parameters.AddWithValue("@DIAS_TOMADOS", DIAS_TOMADOS);
                      
                        cmd.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);

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
       
    }
}
