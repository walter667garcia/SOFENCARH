using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cNivelAcademico
    {
        public int Id_Nivel { get; set; }
        public int Id_Persona { get; set; }
        public int Id_Academico { get; set; }
        public string Establecimiento { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Outicio { get; set; }
        public string Titulo { get; set; }
        public string Especialidad { get; set; }
        public string Persona { get; set; }

        public int ID { get; set; }


        public cNivelAcademico()
        {

        }
        public cNivelAcademico(int id_Nivel, int id_Persona, int id_Academico, 
            string establecimiento , DateTime fecha_Inicio, DateTime fecha_Outicio, 
            string titulo, string especialidad, string persona, int id)
        {
            Id_Nivel = id_Nivel;
            Id_Persona = id_Persona;
            Id_Academico = id_Academico;
            Establecimiento = establecimiento;
            Fecha_Inicio = fecha_Inicio;
            Fecha_Outicio = fecha_Outicio;
            Titulo = titulo;
            Especialidad = especialidad;
            Persona = persona;
            ID = id;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("RHNIVELACADEMICO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHNIVELACADEMICO";
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

        public DataTable Buscar(cNivelAcademico nivel)
        {
            DataTable DtResultado1 = new DataTable("RHNIVELACADEMICO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHNIVELACADEMICO";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = nivel.Persona;
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

        public string Insertar(cNivelAcademico nivel)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_InsertarRHNIVELACADEMICO";  // Reemplaza con el nombre real del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@IdPersona", nivel.Id_Persona).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IdAcademico", nivel.Id_Academico).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@Establecimiento", nivel.Establecimiento).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@dFecha", nivel.Fecha_Inicio).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@aFecha", nivel.Fecha_Outicio).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@Titulo", nivel.Titulo).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@Especialidad", nivel.Especialidad).SqlDbType = SqlDbType.VarChar;


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No ingresó el registro";
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


        // Método para actualizar un registro existente
        public string Actualizar(cNivelAcademico nivel)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_ActualizarRHNIVELACADEMICO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", nivel.Id_Nivel).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IdPersona", nivel.Id_Persona).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IdAcademico", nivel.Id_Academico).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@Establecimiento", nivel.Establecimiento).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@dFecha", nivel.Fecha_Inicio).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@aFecha", nivel.Fecha_Outicio).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@Titulo", nivel.Titulo).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@Especialidad", nivel.Especialidad).SqlDbType = SqlDbType.VarChar;

                // Agregar parámetros para otros campos...

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No actualizó el registro";
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

        public string Eliminar(cNivelAcademico educacion)
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
                cmd.CommandText = "sp_EliminarRHEducacion";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEducacion = new SqlParameter();
                ParEducacion.ParameterName = "@Id";
                ParEducacion.SqlDbType = SqlDbType.Int;
                ParEducacion.Value = educacion.ID;
                cmd.Parameters.Add(ParEducacion);

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
