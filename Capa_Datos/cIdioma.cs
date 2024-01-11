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
        private string _persona;
        private int _Id_Idioma;
        private int _IdPersona;
        private int _IdIdioma;
        private string _Conversacion;
        private string _Escritura;
        private string _Lectura;
        private string _Documento;

        public string Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }

        public int Id_Idioma
        {
            get { return _Id_Idioma; }
            set { _Id_Idioma = value; }
        }

        public int IdPersona
        {
            get { return _IdPersona; }
            set { _IdPersona = value; }
        }

        public int IdIdioma
        {
            get { return _IdIdioma; }
            set { _IdIdioma = value; }
        }

        public string Conversacion
        {
            get { return _Conversacion; }
            set { _Conversacion = value; }
        }

        public string Escritura
        {
            get { return _Escritura; }
            set { _Escritura = value; }
        }

        public string Lectura
        {
            get { return _Lectura; }
            set { _Lectura = value; }
        }

        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        // Constructor vacío
        public cIdioma()
        {
        }

        // Constructor lleno
        public cIdioma(string persona, int id_Idioma, int idPersona, int idIdioma,
                       string conversacion, string escritura, string lectura, string documento)
        {
            _persona = persona;
            _Id_Idioma = id_Idioma;
            _IdPersona = idPersona;
            _IdIdioma = idIdioma;
            _Conversacion = conversacion;
            _Escritura = escritura;
            _Lectura = lectura;
            _Documento = documento;
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

                cmd.Parameters.AddWithValue("@ID_IDIOMA", idioma.IdPersona).SqlDbType = SqlDbType.Int;
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
    }
}
