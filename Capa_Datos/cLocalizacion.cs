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

        private int idLocalizacion;
        private int idPersona;
        private int idLocalizacionTipo;
        private string localizacion;
        private string persona;

        public int IdLocalizacion
        {
            get { return idLocalizacion; }
            set { idLocalizacion = value; }
        }

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        public int IdLocalizacionTipo
        {
            get { return idLocalizacionTipo; }
            set { idLocalizacionTipo = value; }
        }

        public string Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
        }

        public string Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        public cLocalizacion()
        {
        }

        public cLocalizacion(int idLocalizacion, int idPersona, int idLocalizacionTipo, string localizacion, string persona)
        {
            IdLocalizacion = idLocalizacion;
            IdPersona = idPersona;
            IdLocalizacionTipo = idLocalizacionTipo;
            Localizacion = localizacion;
            Persona = persona;
        }

        public string Insertar(cLocalizacion localizacionDatos)
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
                        cmd.Parameters.AddWithValue("@IDPersona", localizacionDatos.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDLocalizacion", localizacionDatos.IdLocalizacionTipo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Localizacion", localizacionDatos.Localizacion).SqlDbType = SqlDbType.NVarChar;
               
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

        public string Actualizar(cLocalizacion localizacionDatos)
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
                        cmd.Parameters.AddWithValue("@ID", localizacionDatos.IdLocalizacion).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDPersona", localizacionDatos.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDLocalizacion", localizacionDatos.IdLocalizacionTipo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Localizacion", localizacionDatos.Localizacion).SqlDbType = SqlDbType.NVarChar;
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

        public DataTable Buscar(cLocalizacion localizacionDatos)
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
                parDPI.Value = localizacionDatos.Persona;
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
    }
}
