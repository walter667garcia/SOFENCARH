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

        private int _idSocio;
        private int _idPersona;
        private int _idAgrupacion;
        private String _detalleAgrupacion;
        private String _dependientes;
        private String _detalleDependientes;
        private int _idVivienda;
        private String _flagDeudas;
        private String _pagoVivienda;
        private String _montoDeuda;
        private String _motivoDeuda;
        private String _flagOtrosIngresos;
        private String _montoOtrosIngresos;
        private String _fuentesOtrosIngresos;
        private int _idVehiculo;
        private String _tipoVehiculo;
        private String _modeloVehiculo;
        private String _placaVehiculo;
        private String _persona;

        public int IdSocio
        {
            get { return _idSocio; }
            set { _idSocio = value; }
        }
        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        public int IdAgrupacion
        {
            get { return _idAgrupacion; }
            set { _idAgrupacion = value; }
        }

        public String DetalleAgrupacion
        {
            get { return _detalleAgrupacion; }
            set { _detalleAgrupacion = value; }
        }

        public String Dependientes
        {
            get { return _dependientes; }
            set { _dependientes = value; }
        }

        public String DetalleDependientes
        {
            get { return _detalleDependientes; }
            set { _detalleDependientes = value; }
        }

        public int IdVivienda
        {
            get { return _idVivienda; }
            set { _idVivienda = value; }
        }

        public String FlagDeudas
        {
            get { return _flagDeudas; }
            set { _flagDeudas = value; }
        }

        public String PagoVivienda
        {
            get { return _pagoVivienda; }
            set { _pagoVivienda = value; }
        }

        public String MontoDeuda
        {
            get { return _montoDeuda; }
            set { _montoDeuda = value; }
        }

        public String MotivoDeuda
        {
            get { return _motivoDeuda; }
            set { _motivoDeuda = value; }
        }

        public String FlagOtrosIngresos
        {
            get { return _flagOtrosIngresos; }
            set { _flagOtrosIngresos = value; }
        }

        public String MontoOtrosIngresos
        {
            get { return _montoOtrosIngresos; }
            set { _montoOtrosIngresos = value; }
        }

        public String FuentesOtrosIngresos
        {
            get { return _fuentesOtrosIngresos; }
            set { _fuentesOtrosIngresos = value; }
        }

        public int IdVehiculo
        {
            get { return _idVehiculo; }
            set { _idVehiculo = value; }
        }

        public String TipoVehiculo
        {
            get { return _tipoVehiculo; }
            set { _tipoVehiculo = value; }
        }

        public String ModeloVehiculo
        {
            get { return _modeloVehiculo; }
            set { _modeloVehiculo = value; }
        }

        public String PlacaVehiculo
        {
            get { return _placaVehiculo; }
            set { _placaVehiculo = value; }
        }

        public String Persona
        {
            get { return _persona; }
            set { _persona = value; }
        }

        // Constructor vacío
        public cSocioEconomico() 
        {
            
        }

        // Constructor completo
        public cSocioEconomico(int idSocio, int idPersona, int idAgrupacion, String detalleAgrupacion,
                       String dependientes, String detalleDependientes, int idVivienda,
                       String flagDeudas, String pagoVivienda, String montoDeuda, String motivoDeuda,
                       String flagOtrosIngresos, String montoOtrosIngresos, String fuentesOtrosIngresos,
                       int idVehiculo, String tipoVehiculo, String modeloVehiculo, String placaVehiculo, string persona)
        {
            _idSocio = idSocio;
            _idPersona = idPersona;
            _idAgrupacion = idAgrupacion;
            _detalleAgrupacion = detalleAgrupacion;
            _dependientes = dependientes;
            _detalleDependientes = detalleDependientes;
            _idVivienda = idVivienda;
            _flagDeudas = flagDeudas;
            _pagoVivienda = pagoVivienda;
            _montoDeuda = montoDeuda;
            _motivoDeuda = motivoDeuda;
            _flagOtrosIngresos = flagOtrosIngresos;
            _montoOtrosIngresos = montoOtrosIngresos;
            _fuentesOtrosIngresos = fuentesOtrosIngresos;
            _idVehiculo = idVehiculo;
            _tipoVehiculo = tipoVehiculo;
            _modeloVehiculo = modeloVehiculo;
            _placaVehiculo = placaVehiculo;
            _persona = persona;
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
                        cmd.Parameters.AddWithValue("@FLAG_DEUDAS", socio.FlagDeudas).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PAGO_VIVIENDA", socio.PagoVivienda).SqlDbType = SqlDbType.NVarChar;
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
                        cmd.Parameters.AddWithValue("@FLAG_DEUDAS", socio.FlagDeudas).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@PAGO_VIVIENDA", socio.PagoVivienda).SqlDbType = SqlDbType.NVarChar;
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
    }
}
