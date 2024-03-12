using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cLocalizacion
    {
        public int IdLocalizacion { get; set; }
        public int IdPersona { get; set; }
        public int IdLocalizacionTipo { get; set; }
        public string Localizacion { get; set; }
        public string Persona { get; set; }
        public int ID { get; set; }

        public cLocalizacion()
        {
        }

        public cLocalizacion(int idLocalizacion, int idPersona, 
            int idLocalizacionTipo, string localizacion, string persona, int ID)
        {
            IdLocalizacion = idLocalizacion;
            IdPersona = idPersona;
            IdLocalizacionTipo = idLocalizacionTipo;
            Localizacion = localizacion;
            Persona = persona;
            ID = ID;
        }

        public string Insertar()
        {
            string respuesta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHLocalizacion", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPersona", IdPersona);
                        cmd.Parameters.AddWithValue("@IDLocalizacion", IdLocalizacionTipo);
                        cmd.Parameters.AddWithValue("@Localizacion",Localizacion);

                        respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se insertó el registro";
                    }
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return respuesta;
        }

        public string Actualizar( )
        {
            string respuesta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRhLocalizacion", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", IdLocalizacion);
                        cmd.Parameters.AddWithValue("@IDPersona", IdPersona);
                        cmd.Parameters.AddWithValue("@IDLocalizacion", IdLocalizacionTipo);
                        cmd.Parameters.AddWithValue("@Localizacion", Localizacion);
                        respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el registro";
                    }
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return respuesta;
        }

        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("RHLOCALIZACION");
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHLocalizacion";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }

        public DataTable Buscar(cLocalizacion localizacion)
        {
            DataTable dtResultado = new DataTable("RHLOCALIZACION");
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHLocalizacion";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parDPI = new SqlParameter();
                parDPI.ParameterName = "@Persona";
                parDPI.SqlDbType = SqlDbType.VarChar;
                parDPI.Size = 200;
                parDPI.Value = localizacion.Persona;
                sqlcmd.Parameters.Add(parDPI);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }

            return dtResultado;
        }

        public string Eliminar(cLocalizacion localizacion)
        {
            string rpta = "" ;
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                // Código
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();
                // Establecer el Comando Sql
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_EliminarRHLocalizacion";
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter ParIdEtnia = new SqlParameter();
                ParIdEtnia.ParameterName ="@ID" ;
                ParIdEtnia.SqlDbType = SqlDbType.Int;
                ParIdEtnia.Value = localizacion.ID;
                cmd.Parameters.Add(ParIdEtnia);
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No eliminó el registro";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                    sqlcon.Close();
            }
            return rpta;
        }

    }
}
