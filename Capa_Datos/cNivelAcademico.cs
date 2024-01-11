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
        private int _Id_Nivel;
        private int _Id_Persona;
        private int _Id_Academico;
        private string _Establecimiento;
        private DateTime _Fecha_Inicio;
        private DateTime _Fecha_Outicio;
        private string _Titulo;
        private string _Especialidad;
        private string _persona;

        public int Id_Nivel
        {
            get { return _Id_Nivel; }
            set { _Id_Nivel = value; }
        }
        public int Id_Persona
        {
            get { return _Id_Persona; }
            set { _Id_Persona = value; }

        }

        public int Id_Academico
        {
            get { return _Id_Academico; }
            set { _Id_Academico = value; }
        }

        public string Establecimiento
        {
            get { return _Establecimiento; }
            set {  _Establecimiento = value;}
        }

        public DateTime Fecha_Inicio
        {
            get { return _Fecha_Inicio; }
            set { _Fecha_Inicio = value; }
        }

        public DateTime Fecha_Outicio
        {
            get { return _Fecha_Outicio; }
            set { _Fecha_Outicio = value; }
        }

        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        public string Especialidad
        {
            get { return _Especialidad; }
            set { _Especialidad = value; }
        }

        public string Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }

        public cNivelAcademico()
        {

        }
        public cNivelAcademico(int id_Nivel, int id_Persona, int id_Academico, string establecimiento , DateTime fecha_Inicio, DateTime fecha_Outicio, string titulo, string especialidad, string persona)
        {
            _Id_Nivel = id_Nivel;
            _Id_Persona = id_Persona;
            _Id_Academico = id_Academico;
            _Establecimiento = establecimiento;
            _Fecha_Inicio = fecha_Inicio;
            _Fecha_Outicio = fecha_Outicio;
            _Titulo = titulo;
            _Especialidad = especialidad;
            _persona = persona;
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
    }
}
