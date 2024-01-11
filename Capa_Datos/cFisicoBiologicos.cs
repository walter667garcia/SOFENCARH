using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cFisicoBiologicos
    {
        // Propiedades
        public int IDFISICABIO { get; set; }
        public int IdPersona { get; set; }
        public string ENFERMEDAD { get; set; }
        public string DIABETES { get; set; }
        public string ACCIDENTE { get; set; }
        public string OPERACION { get; set; }
        public string ALERGIAS { get; set; }
        public string TRATAMIENTO { get; set; }
        public string ESPECIFIQUE { get; set; }
        public string LENTES { get; set; }
        public string AUDITIVO { get; set; }
        public string DISCAPACIDAD { get; set; }
        public string DROGRAS { get; set; }
        public string ALCOHOL { get; set; }
        public string FUMA { get; set; }
        public string PESO { get; set; }
        public string ESTATURA { get; set; }
        public string SANGRE { get; set; }
        public string PASATIEMPOS { get; set; }
        public string DEPORTES { get; set; }

        public string Persona {  get; set; }

        // Constructor vacío
        public cFisicoBiologicos()
        {
            // Puedes inicializar propiedades predeterminadas aquí si es necesario
        }

        // Constructor con datos
        public cFisicoBiologicos(int idPersona, string enfermedad, string diabetes, string accidente,
            string operacion, string alergias, string tratamiento, string especifique, string lentes,
            string auditivo, string discapacidad, string drogras, string alcohol, string fuma, string peso,
            string estatura, string sangre, string pasatiempos, string deportes, string persona)
        {
            IdPersona = idPersona;
            ENFERMEDAD = enfermedad;
            DIABETES = diabetes;
            ACCIDENTE = accidente;
            OPERACION = operacion;
            ALERGIAS = alergias;
            TRATAMIENTO = tratamiento;
            ESPECIFIQUE = especifique;
            LENTES = lentes;
            AUDITIVO = auditivo;
            DISCAPACIDAD = discapacidad;
            DROGRAS = drogras;
            ALCOHOL = alcohol;
            FUMA = fuma;
            PESO = peso;
            ESTATURA = estatura;
            SANGRE = sangre;
            PASATIEMPOS = pasatiempos;
            DEPORTES = deportes;
            Persona = persona;
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
                        cmd.Parameters.AddWithValue("@Drogas", fisicoBiologicos.DROGRAS).SqlDbType = SqlDbType.VarChar;
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
                        cmd.Parameters.AddWithValue("@Drogas", fisicoBiologicos.DROGRAS).SqlDbType = SqlDbType.VarChar;
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
            DataTable dtResultado = new DataTable("RHFISICABIOLOGICA");

            using (SqlConnection sqlconn = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlconn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ListarRHFISICABIOLOGICA", sqlconn))
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

        public DataTable Buscar(cFisicoBiologicos fisicoBiologicos)
        {
            DataTable dtResultado = new DataTable("RHFISICABIOLOGICA");

            using (SqlConnection sqlconn = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlconn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_BuscarRHFISICABIOLOGICA", sqlconn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter parBuscar = new SqlParameter();
                        parBuscar.ParameterName = "@Persona";
                        parBuscar.SqlDbType = SqlDbType.VarChar;
                        parBuscar.Size = 200;
                        parBuscar.Value = fisicoBiologicos.Persona;
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
