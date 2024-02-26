using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cExperienciaLaboral
    {
        // Propiedades
        public int IDEXPERIENCIA { get; set; }
        public int IdPersona { get; set; }
        public string EMPRESA { get; set; }
        public string TELEFONO { get; set; }
        public string JEFE { get; set; }
        public string PUESTO { get; set; }
        public string SALARIO { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public DateTime FECHA_RETIRO { get; set; }
        public string MOTIVO_RETIRO { get; set; }
        public string REFERENCIAS { get; set; }
        public string DESCRIPCION { get; set; }

        public string Persona { get; set; }

        public int ID { get; set; }

        // Constructor vacío
        public cExperienciaLaboral()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cExperienciaLaboral(int idPersona, string empresa, string telefono, string jefe, string puesto,
            string salario, DateTime fechaIngreso, DateTime fechaRetiro, string motivoRetiro,
            string referencias, string descripcion, string persona, int iD)
        {
            IdPersona = idPersona;
            EMPRESA = empresa;
            TELEFONO = telefono;
            JEFE = jefe;
            PUESTO = puesto;
            SALARIO = salario;
            FECHA_INGRESO = fechaIngreso;
            FECHA_RETIRO = fechaRetiro;
            MOTIVO_RETIRO = motivoRetiro;
            REFERENCIAS = referencias;
            DESCRIPCION = descripcion;
            Persona = persona;
            ID = iD;
        }

        public string Insertar(cExperienciaLaboral experiencia)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHEXPERIENCIALABORAL", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdPersona", experiencia.IdPersona);
                        cmd.Parameters.AddWithValue("@Empresa", experiencia.EMPRESA);
                        cmd.Parameters.AddWithValue("@Telefono", experiencia.TELEFONO);
                        cmd.Parameters.AddWithValue("@Jefe", experiencia.JEFE);
                        cmd.Parameters.AddWithValue("@Puesto", experiencia.PUESTO);
                        cmd.Parameters.AddWithValue("@Salario", experiencia.SALARIO);
                        cmd.Parameters.AddWithValue("@Fecha_Ingreso", experiencia.FECHA_INGRESO);
                        cmd.Parameters.AddWithValue("@Fecha_Retiro", experiencia.FECHA_RETIRO);
                        cmd.Parameters.AddWithValue("@Motivo_Retiro", experiencia.MOTIVO_RETIRO);
                        cmd.Parameters.AddWithValue("@Referencias", experiencia.REFERENCIAS);
                        cmd.Parameters.AddWithValue("@Descripcion", experiencia.DESCRIPCION);


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


        public string Actualizar(cExperienciaLaboral experiencia)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHEXPERIENCIALABORAL", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", experiencia.IDEXPERIENCIA);
                        cmd.Parameters.AddWithValue("@IdPersona", experiencia.IdPersona);
                        cmd.Parameters.AddWithValue("@Empresa", experiencia.EMPRESA);
                        cmd.Parameters.AddWithValue("@Telefono", experiencia.TELEFONO);
                        cmd.Parameters.AddWithValue("@Jefe", experiencia.JEFE);
                        cmd.Parameters.AddWithValue("@Puesto", experiencia.PUESTO);
                        cmd.Parameters.AddWithValue("@Salario", experiencia.SALARIO);
                        cmd.Parameters.AddWithValue("@Fecha_Ingreso", experiencia.FECHA_INGRESO);
                        cmd.Parameters.AddWithValue("@Fecha_Retiro", experiencia.FECHA_RETIRO);
                        cmd.Parameters.AddWithValue("@Motivo_Retiro", experiencia.MOTIVO_RETIRO);
                        cmd.Parameters.AddWithValue("@Referencias", experiencia.REFERENCIAS);
                        cmd.Parameters.AddWithValue("@Descripcion", experiencia.DESCRIPCION);
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
            DataTable DtResultado = new DataTable("RHEXPERIENCIALABORAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarRHEXPERIENCIALABORAL";
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

        public DataTable Buscar(cExperienciaLaboral experiencia)
        {
            DataTable DtResultado1 = new DataTable("RHEXPERIENCIALABORAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHEXPERIENCIALABORAL";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = experiencia.Persona;
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

        public string Eliminar(cExperienciaLaboral experiencia)
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
                cmd.CommandText = "sp_EliminarRHExperiencia";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParExperiencia = new SqlParameter();
                ParExperiencia.ParameterName = "@Id";
                ParExperiencia.SqlDbType = SqlDbType.Int;
                ParExperiencia.Value = experiencia.ID;
                cmd.Parameters.Add(ParExperiencia);

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
