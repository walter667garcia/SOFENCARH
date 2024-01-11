using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    internal class cExperienciaLaboral
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

        // Constructor vacío
        public cExperienciaLaboral()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cExperienciaLaboral(int idPersona, string empresa, string telefono, string jefe, string puesto,
            string salario, DateTime fechaIngreso, DateTime fechaRetiro, string motivoRetiro,
            string referencias, string descripcion, string persona)
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
        }

        public void InsertarExperienciaLaboral(cExperienciaLaboral experiencia)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_InsertarRHEXPERIENCIALABORAL", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@IdPersona", experiencia.IdPersona);
                    command.Parameters.AddWithValue("@Empresa", experiencia.EMPRESA);
                    command.Parameters.AddWithValue("@Telefono", experiencia.TELEFONO);
                    command.Parameters.AddWithValue("@Jefe", experiencia.JEFE);
                    command.Parameters.AddWithValue("@Puesto", experiencia.PUESTO);
                    command.Parameters.AddWithValue("@Salario", experiencia.SALARIO);
                    command.Parameters.AddWithValue("@Fecha_Ingreso", experiencia.FECHA_INGRESO);
                    command.Parameters.AddWithValue("@Fecha_Retiro", experiencia.FECHA_RETIRO);
                    command.Parameters.AddWithValue("@Motivo_Retiro", experiencia.MOTIVO_RETIRO);
                    command.Parameters.AddWithValue("@Referencias", experiencia.REFERENCIAS);
                    command.Parameters.AddWithValue("@Descripcion", experiencia.DESCRIPCION);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarExperienciaLaboral(cExperienciaLaboral experiencia)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_ActualizarRHEXPERIENCIALABORAL", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@Id", experiencia.IDEXPERIENCIA);
                    command.Parameters.AddWithValue("@IdPersona", experiencia.IdPersona);
                    command.Parameters.AddWithValue("@Empresa", experiencia.EMPRESA);
                    command.Parameters.AddWithValue("@Telefono", experiencia.TELEFONO);
                    command.Parameters.AddWithValue("@Jefe", experiencia.JEFE);
                    command.Parameters.AddWithValue("@Puesto", experiencia.PUESTO);
                    command.Parameters.AddWithValue("@Salario", experiencia.SALARIO);
                    command.Parameters.AddWithValue("@Fecha_Ingreso", experiencia.FECHA_INGRESO);
                    command.Parameters.AddWithValue("@Fecha_Retiro", experiencia.FECHA_RETIRO);
                    command.Parameters.AddWithValue("@Motivo_Retiro", experiencia.MOTIVO_RETIRO);
                    command.Parameters.AddWithValue("@Referencias", experiencia.REFERENCIAS);
                    command.Parameters.AddWithValue("@Descripcion", experiencia.DESCRIPCION);

                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarExperienciaLaboral(cExperienciaLaboral experiencia)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_BuscarRHEXPERIENCIALABORAL", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Persona", experiencia.Persona);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        public DataTable MostrarExperienciaLaboral()
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_ListarRHEXPERIENCIALABORAL", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }

        }


        public string InsertarFisicoBiologico(cFisicoBiologicos fisicoBiologicos)
        {
            string resultado = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHFISICABIOLOGICA", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdPersona", fisicoBiologicos.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Enfermedad", fisicoBiologicos.ENFERMEDAD).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Diabetes", fisicoBiologicos.DIABETES).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Accidente", fisicoBiologicos.ACCIDENTE).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Operacion", fisicoBiologicos.OPERACION).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Alergias", fisicoBiologicos.ALERGIAS).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Tratamiento", fisicoBiologicos.TRATAMIENTO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Espesifique", fisicoBiologicos.ESPECIFIQUE).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Lentes", fisicoBiologicos.LENTES).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Auditivo", fisicoBiologicos.AUDITIVO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Discapacidad", fisicoBiologicos.DISCAPACIDAD).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Drogras", fisicoBiologicos.DROGRAS).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Alcohol", fisicoBiologicos.ALCOHOL).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Fuma", fisicoBiologicos.FUMA).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Peso", fisicoBiologicos.PESO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Estatura", fisicoBiologicos.ESTATURA).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Sangre", fisicoBiologicos.SANGRE).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Pasatiempos", fisicoBiologicos.PASATIEMPOS).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Deportes", fisicoBiologicos.DEPORTES).SqlDbType = SqlDbType.VarChar;

                        resultado = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingresó el registro";
                    }
                }
                catch (Exception ex)
                {
                    resultado = ex.Message;
                }
            }

            return resultado;
        }

        public string ActualizarFisicoBiologico(cFisicoBiologicos fisicoBiologicos)
        {
            string resultado = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHFISICABIOLOGICA", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", fisicoBiologicos.IDFISICABIO).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IdPersona", fisicoBiologicos.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Enfermedad", fisicoBiologicos.ENFERMEDAD).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Diabetes", fisicoBiologicos.DIABETES).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Accidente", fisicoBiologicos.ACCIDENTE).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Operacion", fisicoBiologicos.OPERACION).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Alergias", fisicoBiologicos.ALERGIAS).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Tratamiento", fisicoBiologicos.TRATAMIENTO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Espesifique", fisicoBiologicos.ESPECIFIQUE).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Lentes", fisicoBiologicos.LENTES).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Auditivo", fisicoBiologicos.AUDITIVO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Discapacidad", fisicoBiologicos.DISCAPACIDAD).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Drogras", fisicoBiologicos.DROGRAS).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Alcohol", fisicoBiologicos.ALCOHOL).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Fuma", fisicoBiologicos.FUMA).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Peso", fisicoBiologicos.PESO).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Estatura", fisicoBiologicos.ESTATURA).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Sangre", fisicoBiologicos.SANGRE).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Pasatiempos", fisicoBiologicos.PASATIEMPOS).SqlDbType = SqlDbType.VarChar;
                        cmd.Parameters.AddWithValue("@Deportes", fisicoBiologicos.DEPORTES).SqlDbType = SqlDbType.VarChar;

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        resultado = filasAfectadas == 1 ? "OK" : "No se actualizó el registro";
                    }
                }
                catch (Exception ex)
                {
                    resultado = ex.Message;
                }
            }

            return resultado;
        }

        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("RHEXPERIENCIALABORAL");

            using (SqlConnection sqlconn = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlconn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ListarRHEXPERIENCIALABORAL", sqlconn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(cmd))
                        {
                            sqlDat.Fill(dtResultado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResultado = null;
                }
            }

            return dtResultado;
        }

        public DataTable Buscar(cExperienciaLaboral experiencia)
        {
            DataTable dtResultado = new DataTable("RHEXPERIENCIALABORAL");

            using (SqlConnection sqlconn = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlconn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_BuscarRHEXPERIENCIALABORAL", sqlconn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter parBuscar = new SqlParameter();
                        parBuscar.ParameterName = "@Persona";
                        parBuscar.SqlDbType = SqlDbType.VarChar;
                        parBuscar.Size = 200;
                        parBuscar.Value = experiencia.Persona;
                        cmd.Parameters.Add(parBuscar);

                        using (SqlDataAdapter sqlDat = new SqlDataAdapter(cmd))
                        {
                            sqlDat.Fill(dtResultado);
                        }
                    }
                }
                catch (Exception ex)
                {
                    dtResultado = null;
                }
            }

            return dtResultado;
        }
    }
}
