using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cPuestoFuncional
    {
       

            public int IdPuestoFuncional { get; set; }
            
            public string PuestoFuncional { get; set; }
            public int IdRenglon { get; set; }

            public int IdPuestoNominal { get; set; }

            public int IdUnidadSeccion { get; set; }

            public string SalarioBase { get; set; }

            public string Puesto { get; set; }
        public cPuestoFuncional()
            {
            }

            public cPuestoFuncional(int idPuestoFuncional, string puestoFuncional, int idRenglon, int idPuestoNominal, int idUnidadSeccion, string salarioBase, string puesto)
            {
                IdPuestoFuncional = idPuestoFuncional;
                PuestoFuncional = puestoFuncional;
                IdRenglon = idRenglon;
                IdPuestoNominal = idPuestoNominal;
                IdUnidadSeccion = idUnidadSeccion;
                SalarioBase = salarioBase;
                Puesto = puesto;
            }

            public string Insertar(cPuestoFuncional puestoFuncionalDatos)
            {
                string respuesta = "";

                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    try
                    {
                        sqlcon.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_InsertarRHPuestoFuncional", sqlcon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@PUESTOFUNCIONAL", puestoFuncionalDatos.PuestoFuncional).SqlDbType = SqlDbType.VarChar;
                            cmd.Parameters.AddWithValue("@IDRENGLON", puestoFuncionalDatos.IdRenglon).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@IDPUESTONOMINAL", puestoFuncionalDatos.IdPuestoNominal).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@IDUNIDADSECCION", puestoFuncionalDatos.IdUnidadSeccion).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@SALARIO", puestoFuncionalDatos.SalarioBase).SqlDbType = SqlDbType.VarChar;

                            respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No ingresó el registro";
                        }
                    }
                    catch (Exception ex)
                    {
                        respuesta = ex.Message;
                    }
                }

                return respuesta;
            }

            public string Actualizar(cPuestoFuncional puestoFuncionalDatos)
            {
                string respuesta = "";

                using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
                {
                    try
                    {
                        sqlcon.Open();

                        using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHPuestoFuncional", sqlcon))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IDPUESTO_FUNCIONAL", puestoFuncionalDatos.IdPuestoFuncional).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@PUESTO_FUNCIONAL", puestoFuncionalDatos.PuestoFuncional).SqlDbType = SqlDbType.VarChar;
                            cmd.Parameters.AddWithValue("@ID_RENGLON", puestoFuncionalDatos.IdRenglon).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@ID_PUESTO_NOMINAL", puestoFuncionalDatos.IdPuestoNominal).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@IDUNIDAD_SECCION", puestoFuncionalDatos.IdUnidadSeccion).SqlDbType = SqlDbType.Int;
                            cmd.Parameters.AddWithValue("@SALARIO_BASE", puestoFuncionalDatos.SalarioBase).SqlDbType = SqlDbType.VarChar;

                            respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó el registro";
                        }
                    }
                    catch (Exception ex)
                    {
                        respuesta = ex.Message;
                    }
                }

                return respuesta;
            }

            public DataTable Mostrar()
            {
                DataTable dtResultado = new DataTable("RHPUESTOFUNCIONAL");
                SqlConnection sqlconn = new SqlConnection();

                try
                {
                    sqlconn.ConnectionString = Conexion.Cn;
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "sp_MostrarRHPUESTOFUNCIONAL";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    dtResultado = null;
                }

                return dtResultado;
            }

            public DataTable Buscar(cPuestoFuncional puestoFuncionalDatos)
            {
                DataTable dtResultado = new DataTable("RHPUESTOFUNCIONAL");
                SqlConnection sqlconn = new SqlConnection();

                try
                {
                    sqlconn.ConnectionString = Conexion.Cn;
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlconn;
                    sqlcmd.CommandText = "sp_BuscarRHPUESTOFUNCIONAL";
                    sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parDPI = new SqlParameter();
                parDPI.ParameterName = "@Puesto";
                parDPI.SqlDbType = SqlDbType.VarChar;
                parDPI.Size = 100;
                parDPI.Value = puestoFuncionalDatos.Puesto;
                sqlcmd.Parameters.Add(parDPI);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                    sqlDat.Fill(dtResultado);
                }
                catch (Exception ex)
                {
                    dtResultado = null;
                }

                return dtResultado;
            }
        


    }
}
