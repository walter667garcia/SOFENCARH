using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cUsuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public bool Activo { get; set; }
        public int TipoUsuario { get; set; }
        public byte[] Foto { get; set; }

        public string BuscarUsuario {  get; set; }

        public string BuscarPersona { get; set; }
        public cUsuario()
        {
            // Constructor vacío
        }

        public cUsuario(int usuarioID, string nombreUsuario, string contrasena, bool activo, int tipoUsuario, byte[] foto, string buscar, string buscarPersona)
        {
            UsuarioID = usuarioID;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Activo = activo;
            TipoUsuario = tipoUsuario;
            Foto = foto;
            BuscarUsuario = buscar;
            BuscarPersona = buscarPersona;
        }
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarUsuarios";
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

        
        public DataTable MostrarPersonaEstado()
        {
            DataTable DtResultado = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHPersonaestado";
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

        public DataTable MostrarActasEstado()
        {
            DataTable DtResultado = new DataTable("RHACTAPOSESION");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarRHActaMantenimiento";
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

        public string ActualizarEstadoPersona(int idPeriodo, bool estado)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarEstadoPersona", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", idPeriodo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Estado", estado).SqlDbType = SqlDbType.Bit;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        rpta = filasAfectadas > 0 ? "OK" : "No se actualizó ningún registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }

        public string ActualizarEstadoUsuario(int idPeriodo, bool estado)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarEstadoUsuario", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", idPeriodo).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Estado", estado).SqlDbType = SqlDbType.Bit;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        rpta = filasAfectadas > 0 ? "OK" : "No se actualizó ningún registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }
        public string ActualizarEstadoActa(int idActa)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_DesactivarActa", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Id", idActa).SqlDbType = SqlDbType.Int;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        rpta = filasAfectadas > 0 ? "OK" : "No se actualizó ningún registro";
                    }
                }
                catch (Exception ex)
                {
                    rpta = ex.Message;
                }
            }

            return rpta;
        }


        public string Insertar(cUsuario usuario)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                        cmd.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);
                        cmd.Parameters.AddWithValue("@Foto", usuario.Foto);

                        respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al insertar usuario";
                    }
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }
            return respuesta;
        }

        public string Actualizar(cUsuario usuario)
        {
            string respuesta = "";
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarUsuario", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UsuarioID", usuario.UsuarioID);
                        cmd.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@Activo", usuario.Activo);
                        cmd.Parameters.AddWithValue("@TipoUsuario", usuario.TipoUsuario);
                        cmd.Parameters.AddWithValue("@Foto", usuario.Foto);

                        respuesta = cmd.ExecuteNonQuery() == 1 ? "OK" : "Error al actualizar usuario";
                    }
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }
            return respuesta;
        }

        public DataTable Buscar(cUsuario usuario)
        {
            DataTable DtResultado1 = new DataTable("Usuario");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarUsuarioPorNombre";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@NombreUsuario";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 50;
                ParBuscar.Value = usuario.BuscarUsuario;
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

        public DataTable BuscarPersonaId(cUsuario usuario)
        {
            DataTable DtResultado1 = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHPersonaestadoID";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = usuario.BuscarPersona;
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
