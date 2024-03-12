using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capa_Datos
{
    public class cIdioma
    {
        public string Persona { get; set; }
        public int Id_Idioma { get; set; }
        public int IdPersona { get; set; }
        public int IdIdioma { get; set; }
        public string Conversacion { get; set; }
        public string Escritura { get; set; }
        public string Lectura { get; set; }
        public string Documento { get; set; }

        public int ID { get; set; }


        // Constructor vacío
        public cIdioma()
        {
        }

        // Constructor lleno
        public cIdioma(string persona, int id_Idioma, int idPersona, int idIdioma,
                       string conversacion, string escritura, string lectura, string documento, int iD)
        {
            Persona = persona;
            Id_Idioma = id_Idioma;
            IdPersona = idPersona;
            IdIdioma = idIdioma;
            Conversacion = conversacion;
            Escritura = escritura;
            Lectura = lectura;
            Documento = documento;
            ID = iD;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("RHIDIOMA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "MostrarInformacionIdioma";
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

        public DataTable Buscar(cIdioma idioma)
        {
            DataTable DtResultado1 = new DataTable("RHIDIOMA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRhIdioma";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = idioma.Persona;
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

        public string Insertar(cIdioma idioma)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_InsertarRhIdioma";  // Reemplaza con el nombre real del procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@IDPERSONA", idioma.IdPersona).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IDIDIOMA", idioma.IdIdioma).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@CONVERSACION", idioma.Conversacion).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@ESCRITURA", idioma.Escritura).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@LECTURA", idioma.Lectura).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DOCUMENTO", idioma.Documento).SqlDbType = SqlDbType.NVarChar;


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
        public string Actualizar(cIdioma idioma)
        {
            string rpta = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.Cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "sp_ActualizarRhIdioma";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_IDIOMA", idioma.Id_Idioma).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IDPERSONA", idioma.IdPersona).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IDIDIOMA", idioma.IdIdioma).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@CONVERSACION", idioma.Conversacion).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@ESCRITURA", idioma.Escritura).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@LECTURA", idioma.Lectura).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DOCUMENTO", idioma.Documento).SqlDbType = SqlDbType.NVarChar;

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

        public string Eliminar(cIdioma idioma)
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
                cmd.CommandText = "sp_EliminarRHIdioma";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdioma = new SqlParameter();
                ParIdioma.ParameterName = "@Id";
                ParIdioma.SqlDbType = SqlDbType.Int;
                ParIdioma.Value = idioma.ID;
                cmd.Parameters.Add(ParIdioma);

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
