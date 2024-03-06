using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cActas
    {
        // Propiedades
        public int ID_ACTA { get; set; }
        public int IDPERSONA { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public string PUESTO_FUNCIONAL { get; set; }
        public int ID_COORDINACION { get; set; }
        public int ID_PUESTO_NOMINAL { get; set; }
        public int ID_RENGLON { get; set; }
        public int IDUNIDAD_SECCION { get; set; }
        public string SALARIO_BASE { get; set; }
        public string DESCRIPCION { get; set; }
        public string Persona {  get; set; }

        // Constructor vacío
        public cActas()
        {
        }

        // Constructor lleno
        public cActas(int idActa, int idPersona, DateTime fechaIngreso, string puestoFuncional, int idCoordinacion, int idPuestoNominal, int idRenglon, int idUnidadSeccion, string salarioBase, string descripcion, string persona)
        {
            ID_ACTA = idActa;
            IDPERSONA = idPersona;
            FECHA_INGRESO = fechaIngreso;
            PUESTO_FUNCIONAL = puestoFuncional;
            ID_COORDINACION = idCoordinacion;
            ID_PUESTO_NOMINAL = idPuestoNominal;
            ID_RENGLON = idRenglon;
            IDUNIDAD_SECCION = idUnidadSeccion;
            SALARIO_BASE = salarioBase;
            DESCRIPCION = descripcion;
            Persona = persona;
        }

        // Método para insertar un nuevo registro
        public string Insertar()
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHActa", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPERSONA", IDPERSONA);
                        cmd.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
                        cmd.Parameters.AddWithValue("@PUESTO_FUNCIONAL", PUESTO_FUNCIONAL);
                        cmd.Parameters.AddWithValue("@ID_COORDINACION", ID_COORDINACION);
                        cmd.Parameters.AddWithValue("@ID_PUESTO_NOMINAL", ID_PUESTO_NOMINAL);
                        cmd.Parameters.AddWithValue("@ID_RENGLON", ID_RENGLON);
                        cmd.Parameters.AddWithValue("@IDUNIDAD_SECCION", IDUNIDAD_SECCION);
                        cmd.Parameters.AddWithValue("@SALARIO_BASE", SALARIO_BASE);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);

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

        // Método para actualizar un registro existente
        public string Actualizar()
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHActaPosesion", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID_ACTA", ID_ACTA);
                        cmd.Parameters.AddWithValue("@IDPERSONA", IDPERSONA);
                        cmd.Parameters.AddWithValue("@FECHA_INGRESO", FECHA_INGRESO);
                        cmd.Parameters.AddWithValue("@PUESTO_FUNCIONAL", PUESTO_FUNCIONAL);
                        cmd.Parameters.AddWithValue("@ID_COORDINACION", ID_COORDINACION);
                        cmd.Parameters.AddWithValue("@ID_PUESTO_NOMINAL", ID_PUESTO_NOMINAL);
                        cmd.Parameters.AddWithValue("@ID_RENGLON", ID_RENGLON);
                        cmd.Parameters.AddWithValue("@IDUNIDAD_SECCION", IDUNIDAD_SECCION);
                        cmd.Parameters.AddWithValue("@SALARIO_BASE", SALARIO_BASE);
                        cmd.Parameters.AddWithValue("@DESCRIPCION", DESCRIPCION);

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
        // Método para eliminar un registro existente
        public void EliminarActa()
        {
            // Conexión a la base de datos
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                sqlcon.Open();
                // Comando para eliminar
                SqlCommand command = new SqlCommand("EliminarRHActaPosesion", sqlcon);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // Parámetro
                command.Parameters.AddWithValue("@ID_ACTA", ID_ACTA);
                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
        }
        // Método para listar todos los registros
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("RHACTAPOSESION");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarRHActa";
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

        // Método para buscar registros según un parámetro de búsqueda
        public DataTable Buscar(cActas acta)
        {
            DataTable DtResultado1 = new DataTable("RHACTAPOSESION");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHActa";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = acta.Persona;
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
    }
}
