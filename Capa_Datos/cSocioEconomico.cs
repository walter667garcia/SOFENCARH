using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cSocioEconomico
    {

        public int IdSocio { get; set; }
        public int IdPersona { get; set; }
        public int IdAgrupacion { get; set; }
        public String DetalleAgrupacion { get; set; }
        public String Dependientes { get; set; }
        public String DetalleDependientes { get; set; }
        public int IdVivienda { get; set; }
        public String PagoVivienda { get; set; }
        public String FlagDeudas { get; set; }
        public String MontoDeuda { get; set; }
        public String MotivoDeuda { get; set; }
        public String FlagOtrosIngresos { get; set; }
        public String MontoOtrosIngresos { get; set; }
        public String FuentesOtrosIngresos { get; set; }
        public int IdVehiculo { get; set; }
        public String TipoVehiculo { get; set; }
        public String ModeloVehiculo { get; set; }
        public String PlacaVehiculo { get; set; }
        public String Persona { get; set; }

        public int ID { get; set; }


        // Constructor vacío
        public cSocioEconomico() 
        {
            
        }

        // Constructor completo
        public cSocioEconomico(int idSocio, int idPersona, int idAgrupacion, String detalleAgrupacion,
                       String dependientes, String detalleDependientes, int idVivienda, String pagoVivienda,
                       String flagDeudas,  String montoDeuda, String motivoDeuda,
                       String flagOtrosIngresos, String montoOtrosIngresos, String fuentesOtrosIngresos,
                       int idVehiculo, String tipoVehiculo, String modeloVehiculo, String placaVehiculo, string persona, int iD)
        {
            IdSocio = idSocio;
            IdPersona = idPersona;
            IdAgrupacion = idAgrupacion;
            DetalleAgrupacion = detalleAgrupacion;
            Dependientes = dependientes;
            DetalleDependientes = detalleDependientes;
            IdVivienda = idVivienda;
            PagoVivienda = pagoVivienda;
            FlagDeudas = flagDeudas;
            MontoDeuda = montoDeuda;
            MotivoDeuda = motivoDeuda;
            FlagOtrosIngresos = flagOtrosIngresos;
            MontoOtrosIngresos = montoOtrosIngresos;
            FuentesOtrosIngresos = fuentesOtrosIngresos;
            IdVehiculo = idVehiculo;
            TipoVehiculo = tipoVehiculo;
            ModeloVehiculo = modeloVehiculo;
            PlacaVehiculo = placaVehiculo;
            Persona = persona;
            ID = iD;
        }


        public string Insertar( cSocioEconomico socio)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHSOCIOECONOMICO", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Configura los parámetros del procedimiento almacenado según tus propiedades
                        cmd.Parameters.AddWithValue("@IDPERSONA", socio.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDAGRUPACION", socio.IdAgrupacion).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DETALLE_AGRUPACION", socio.DetalleAgrupacion).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@DEPENDIENTES", socio.Dependientes).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@DETALLE_DEPENDIENTES", socio.DetalleDependientes).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@IDVIVIENDA", socio.IdVivienda).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@PAGO_VIVIENDA", socio.PagoVivienda).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FLAG_DEUDAS", socio.FlagDeudas).SqlDbType = SqlDbType.NVarChar;            
                        cmd.Parameters.AddWithValue("@MONTO_DEUDA", socio.MontoDeuda).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@MOTIVO_DEUDA", socio.MotivoDeuda).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FLAG_OTROS_INGRESOS", socio.FlagOtrosIngresos).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@MONTO_OTROS_INGRESOS", socio.MontoOtrosIngresos).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FUENTES_OTROS_INGRESOS", socio.FuentesOtrosIngresos).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@IDVEHICULO", socio.IdVehiculo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@TIPO_VEHICULO", socio.TipoVehiculo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@MODELO_VEHICULO", socio.ModeloVehiculo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PLACA_VEHICULO", socio.PlacaVehiculo).SqlDbType = SqlDbType.NVarChar;

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

        public string Actualizar(cSocioEconomico socio)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHSOCIOECONOMICO", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Configura los parámetros del procedimiento almacenado según tus propiedades
                        cmd.Parameters.AddWithValue("@Id", socio.IdSocio).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDPERSONA", socio.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDAGRUPACION", socio.IdAgrupacion).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@DETALLE_AGRUPACION", socio.DetalleAgrupacion).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@DEPENDIENTES", socio.Dependientes).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@DETALLE_DEPENDIENTES", socio.DetalleDependientes).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@IDVIVIENDA", socio.IdVivienda).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@PAGO_VIVIENDA", socio.PagoVivienda).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FLAG_DEUDAS", socio.FlagDeudas).SqlDbType = SqlDbType.NVarChar;                       
                        cmd.Parameters.AddWithValue("@MONTO_DEUDA", socio.MontoDeuda).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@MOTIVO_DEUDA", socio.MotivoDeuda).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FLAG_OTROS_INGRESOS", socio.FlagOtrosIngresos).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@MONTO_OTROS_INGRESOS", socio.MontoOtrosIngresos).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@FUENTES_OTROS_INGRESOS", socio.FuentesOtrosIngresos).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@IDVEHICULO", socio.IdVehiculo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@TIPO_VEHICULO", socio.TipoVehiculo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@MODELO_VEHICULO", socio.ModeloVehiculo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PLACA_VEHICULO", socio.PlacaVehiculo).SqlDbType = SqlDbType.NVarChar;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        rpta = filasAfectadas == 1 ? "OK" : "No se actualizó el registro";
                    }
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        rpta += $"Error: {error.Message}, Número: {error.Number}, Procedimiento: {error.Procedure}";
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
            DataTable DtResultado = new DataTable("RHSOCIOECONOMICO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHSOCIOECONOMICO";
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

        public DataTable Buscar(cSocioEconomico socioEconomico)
        {
            DataTable DtResultado1 = new DataTable("RHSOCIOECONOMICO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHSOCIOECONOMICO";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = socioEconomico.Persona;
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

        public string Eliminar(cSocioEconomico economico)
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
                cmd.CommandText = "sp_EliminarRHSocioEconomico";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParEconomico = new SqlParameter();
                ParEconomico.ParameterName = "@Id";
                ParEconomico.SqlDbType = SqlDbType.Int;
                ParEconomico.Value = economico.ID;
                cmd.Parameters.Add(ParEconomico);

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
