using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cPeriodos
    {

        public int ID_PERIODO { get; set; }
        public int IDPERSONA { get; set; }
        public string PERIODO { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_FIN { get; set; }
        public int DIAS_DISPONIBLES { get; set; }
        public int DIAS_TOMADOS { get; set; }
        public int DIAS_RESTANTES { get; set; }
        public bool ESTADO { get; set; }

        public int Persona {  get; set; }

        // Constructor vacío
        public cPeriodos()
        {
        }

        // Constructor lleno
        public cPeriodos(int idPeriodo, int idPersona, string periodo, DateTime fechaInicio, DateTime fechaFin, int diasDisponibles, int diasTomados, int diasRestantes, bool estado, int persona)
        {
            ID_PERIODO = idPeriodo;
            IDPERSONA = idPersona;
            PERIODO = periodo;
            FECHA_INICIO = fechaInicio;
            FECHA_FIN = fechaFin;
            DIAS_DISPONIBLES = diasDisponibles;
            DIAS_TOMADOS = diasTomados;
            DIAS_RESTANTES = diasRestantes;
            ESTADO = estado;
            Persona = persona;
        }

        public string Insertar(cPeriodos periodos)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_rhInsertarPeriodo", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdPersona", periodos.IDPERSONA).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@PERIODO", periodos.PERIODO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@FECHA_INICIO", periodos.FECHA_INICIO).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@FECHA_FIN", periodos.FECHA_FIN).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@DIAS_DISPONIBLES", periodos.DIAS_DISPONIBLES).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DIAS_TOMADOS", periodos.DIAS_TOMADOS).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DIAS_RESTANTES", periodos.DIAS_RESTANTES).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@ESTADO", periodos.ESTADO).SqlDbType = SqlDbType.Bit;

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

        public string ActualizarEstado(int idPeriodo, bool estado)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarEstadoRHPeriodo", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", idPeriodo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Estado", estado).SqlDbType = SqlDbType.Bit;

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

        public DataTable MostrarPeriodos(cPeriodos periodos)
        {
            DataTable DtResultado1 = new DataTable("RHPERIODO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_SeleccionarPeriodos";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@IDPersona";
                ParBuscar.SqlDbType = SqlDbType.Int;
                ParBuscar.Value = periodos.Persona;
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

        public DataTable MostrarPersonas()
        {
            DataTable DtResultado = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarVacacionesPersona";
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
    }
}
