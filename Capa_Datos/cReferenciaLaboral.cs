using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cReferenciaLaboral
    {
        
        public int IdReflaboral { get; set; }
        public int IdPersona { get; set; }
        public string Empresa { get; set; }
        public string Telefono { get; set; }
        public string Relacion { get; set; }

        public string Persona { get; set; }

        public int ID { get; set; }


        public cReferenciaLaboral() { }

        public cReferenciaLaboral(int idReflaboral, int idPersona, string empresa, string telefono, string relacion, string persona, int iD)
        {
            IdReflaboral = idReflaboral;
            IdPersona = idPersona;
            Empresa = empresa;
            Telefono = telefono;
            Relacion = relacion;
            Persona = persona;
            ID = iD;
        }

        public string Insertar(cReferenciaLaboral laboral)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarReferenciaLaboral", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", laboral.IdPersona);
                        cmd.Parameters.AddWithValue("@Empresa", laboral.Empresa);
                        cmd.Parameters.AddWithValue("@Telefono", laboral.Telefono);
                        cmd.Parameters.AddWithValue("@Relacion", laboral.Relacion);
                    
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


        public string Actualizar(cReferenciaLaboral laboral)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarReferenciaLaboral", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdReflaboral", laboral.IdReflaboral);
                        cmd.Parameters.AddWithValue("@IdPersona", laboral.IdPersona);
                        cmd.Parameters.AddWithValue("@Empresa", laboral.Empresa);
                        cmd.Parameters.AddWithValue("@Telefono", laboral.Telefono);
                        cmd.Parameters.AddWithValue("@Relacion", laboral.Relacion);
                        // Agregar parámetros para otros campos...

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        rpta = filasAfectadas == 1 ? "OK" : "No se actualizó el registro 1234";

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
            DataTable DtResultado = new DataTable("RHREFERENCIALABORAL");
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarReferenciaLaboral";
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
        public DataTable Buscar(cReferenciaLaboral laboral)
        {
            DataTable DtResultado1 = new DataTable("RHREFERENCIALABORAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarReferenciaLaboral";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = laboral.Persona;
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

        public string Eliminar(cReferenciaLaboral laboral)
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
                cmd.CommandText = "sp_EliminarRHLaboral";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParLaboral = new SqlParameter();
                ParLaboral.ParameterName = "@Id";
                ParLaboral.SqlDbType = SqlDbType.Int;
                ParLaboral.Value = laboral.ID;
                cmd.Parameters.Add(ParLaboral);

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
