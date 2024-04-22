using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public   class cReferenciaPersonal
    {

        public int IdRefpersonal { get; set; }
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Relacion { get; set; }
        public string Documento { get; set; }

        public string Persona { get; set; }

        public int ID { get; set; }

        public cReferenciaPersonal() { }

        public cReferenciaPersonal(int idRefpersonal, int idPersona, string nombre, string telefono, string relacion,string documento, string persona, int iD)
        {
            IdRefpersonal = idRefpersonal;
            IdPersona = idPersona;
            Nombre = nombre;
            Telefono = telefono;
            Relacion = relacion;
            Documento = documento;
            Persona = persona;
            ID = iD;
        }

        public string Insertar(cReferenciaPersonal personal)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarReferenciaPersonal", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", personal.IdPersona);
                        cmd.Parameters.AddWithValue("@Nombre", personal.Nombre);
                        cmd.Parameters.AddWithValue("@Telefono", personal.Telefono);
                        cmd.Parameters.AddWithValue("@Relacion", personal.Relacion);
                        cmd.Parameters.AddWithValue("@Documento", personal.Documento);

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


        public string Actualizar(cReferenciaPersonal personal)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarReferenciaPersonal", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdRefpersonal", personal.IdRefpersonal);
                        cmd.Parameters.AddWithValue("@IdPersona", personal.IdPersona);
                        cmd.Parameters.AddWithValue("@Nombre", personal.Nombre);
                        cmd.Parameters.AddWithValue("@Telefono", personal.Telefono);
                        cmd.Parameters.AddWithValue("@Relacion", personal.Relacion);
                        cmd.Parameters.AddWithValue("@Documento", personal.Documento);
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
            DataTable DtResultado = new DataTable("RHREFERENCIAPERSONAL");
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarReferenciaPersonal";
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
        public DataTable Buscar(cReferenciaPersonal personal)
        {
            DataTable DtResultado1 = new DataTable("RHREFERENCIAPERSONAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarReferenciaPersonal";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = personal.Persona;
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

        public string Eliminar(cReferenciaPersonal personal)
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
                cmd.CommandText = "sp_EliminarRHPersonal";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParPersonal = new SqlParameter();
                ParPersonal.ParameterName = "@Id";
                ParPersonal.SqlDbType = SqlDbType.Int;
                ParPersonal.Value = personal.ID;
                cmd.Parameters.Add(ParPersonal);

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
