using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
        public string Persona { get; set; }
        public int ID { get; set; }

        // Constructor vacío
        public cDatosAdicionales()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cDatosAdicionales(int idDd ,int idPersona, string emergencias, string parentesco, string telefono, string persona, int id)
        {
            IDDATOSADI = idDd;
            IdPersona = idPersona;
            EMERGENCIAS = emergencias;
            PARENTESCO = parentesco;
            TELEFONO = telefono;
            Persona = Persona;
            ID = id;
        }


        public string Insertar(cDatosAdicionales adicionales)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHDATOSADICIONALES", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", adicionales.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Emergencia", adicionales.EMERGENCIAS).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Parentesco", adicionales.PARENTESCO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Telefono", adicionales.TELEFONO).SqlDbType = SqlDbType.NVarChar;

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

        public string Actualizar(cDatosAdicionales adicionales)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHDATOSADICIONALES", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Id", adicionales.IDDATOSADI).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IdPersona", adicionales.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Emergencia", adicionales.EMERGENCIAS).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Parentesco", adicionales.PARENTESCO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Telefono", adicionales.TELEFONO).SqlDbType = SqlDbType.NVarChar;
                        // Agregar parámetros para otros campos...
                        int filasAfectadas = cmd.ExecuteNonQuery();
                        rpta = filasAfectadas == 1 ? "OK" : "No se actualizó el registr";
                    }
                }
                catch (SqlException ex)
                {
                    // Manejar la excepción y obtener detalles específicos
                    foreach (SqlError error in ex.Errors)
                    {
                        rpta += $"Error: {error.Message}, Número: {error.Number}, Procedimiento: {error.Procedure}";
                        // Puedes agregar más información según tus necesidades
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }



        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("RHDATOSADICIONALES");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHDATOSADICIONALES";
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

        public DataTable Buscar(cDatosAdicionales adicionales)
        {
            DataTable DtResultado1 = new DataTable("RHDATOSADICIONALES");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHDATOSADICIONALES";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = adicionales.Persona;
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

        public string Eliminar(cDatosAdicionales adicionales)
        {

            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                // Código
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                // Establecer el Comando Sql
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_EliminarRHDatosAdicionales";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAdicionales = new SqlParameter();
                ParAdicionales.ParameterName = "@Id";
                ParAdicionales.SqlDbType = SqlDbType.Int;
                ParAdicionales.Value = adicionales.ID;
                cmd.Parameters.Add(ParAdicionales);

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
