using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cOtrosDatos
    {
        // Propiedades automáticas
        public int IDOTROS { get; set; }
        public int IdPersona { get; set; }
        public string TRABAJOENCA { get; set; }
        public DateTime FECHAT { get; set; }
        public string PUESTO { get; set; }
        public string SOLICITUDENCA { get; set; }
        public DateTime FECHAS { get; set; }
        public string PLAZA { get; set; }
        public string DISPONIBILIDAD { get; set; }
        public string FAMILIAR_ENCA { get; set; }
        public string FAMILIAR_ENCA_ACTUAL { get; set; }
        public string ENCA_RELACION { get; set; }
        public string PUESTO_CONOCIDO { get; set; }
        public string PLAZA_VACANTE { get; set; }
        public string Persona { get; set; }

        public int ID { get; set; }

        // Constructor vacío
        public cOtrosDatos()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cOtrosDatos(int idPersona, string trabajoEnca, DateTime fechaT, string puesto, string solicitudEnca,
                          DateTime fechaS, string plaza, string disponibilidad, string familiarEnca,
                          string familiarEncaActual, string encaRelacion, string puestoConocido, string plazaVacante, string persona, int iD)
        {
            IdPersona = idPersona;
            TRABAJOENCA = trabajoEnca;
            FECHAT = fechaT;
            PUESTO = puesto;
            SOLICITUDENCA = solicitudEnca;
            FECHAS = fechaS;
            PLAZA = plaza;
            DISPONIBILIDAD = disponibilidad;
            FAMILIAR_ENCA = familiarEnca;
            FAMILIAR_ENCA_ACTUAL = familiarEncaActual;
            ENCA_RELACION = encaRelacion;
            PUESTO_CONOCIDO = puestoConocido;
            PLAZA_VACANTE = plazaVacante;
            Persona = persona;
            ID = iD;
        }

        public string Insertar(cOtrosDatos otrosDatos)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHOTROSDATOS", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdPersona", otrosDatos.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@TRABAJOENCA", otrosDatos.TRABAJOENCA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FECHAT", otrosDatos.FECHAT).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@PUESTO", otrosDatos.PUESTO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@SOLICITUDENCA", otrosDatos.SOLICITUDENCA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FECHAS", otrosDatos.FECHAS).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@PLAZA", otrosDatos.PLAZA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@DISPONIBILIDAD", otrosDatos.DISPONIBILIDAD).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FAMILIAR_ENCA", otrosDatos.FAMILIAR_ENCA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FAMILIAR_ENCA_ACTUAL", otrosDatos.FAMILIAR_ENCA_ACTUAL).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ENCA_RELACION", otrosDatos.ENCA_RELACION).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PUESTO_CONOCIDO", otrosDatos.PUESTO_CONOCIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PLAZA_VACANTE", otrosDatos.PLAZA_VACANTE).SqlDbType = SqlDbType.NVarChar;

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


        public string Actualizar(cOtrosDatos otrosDatos)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHOTROSDATOS", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IDOTROS", otrosDatos.IDOTROS).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IdPersona", otrosDatos.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@TRABAJOENCA", otrosDatos.TRABAJOENCA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FECHAT", otrosDatos.FECHAT).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@PUESTO", otrosDatos.PUESTO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@SOLICITUDENCA", otrosDatos.SOLICITUDENCA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FECHAS", otrosDatos.FECHAS).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@PLAZA", otrosDatos.PLAZA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@DISPONIBILIDAD", otrosDatos.DISPONIBILIDAD).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FAMILIAR_ENCA", otrosDatos.FAMILIAR_ENCA).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FAMILIAR_ENCA_ACTUAL", otrosDatos.FAMILIAR_ENCA_ACTUAL).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@ENCA_RELACION", otrosDatos.ENCA_RELACION).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PUESTO_CONOCIDO", otrosDatos.PUESTO_CONOCIDO).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PLAZA_VACANTE", otrosDatos.PLAZA_VACANTE).SqlDbType = SqlDbType.NVarChar;

                        rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el registro";
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
            DataTable DtResultado = new DataTable("RHOTROSDATOS");
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarRHOTROSDATOS";
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
        public DataTable Buscar(cOtrosDatos otros)
        {
            DataTable DtResultado1 = new DataTable("RHOTROSDATOS");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHOTROSDATOS";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = otros.Persona;
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

        public string Eliminar(cOtrosDatos otros)
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
                cmd.CommandText = "sp_EliminarRHOtrosDatos";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParOtros = new SqlParameter();
                ParOtros.ParameterName = "@Id";
                ParOtros.SqlDbType = SqlDbType.Int;
                ParOtros.Value = otros.ID;
                cmd.Parameters.Add(ParOtros);

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
