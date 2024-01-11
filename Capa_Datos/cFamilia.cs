using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cFamilia
    {
        // Variables privadas
        private int id_Familia;
        private int idPersona;
        private int idTipo_Familia;
        private string nombre;
        private DateTime f_nacimiento;
        private string ocupacion;
        private string telefono;
        private string l_trabajo;
        private string d_trabajo;
        private string t_trabajo;
        private string persona;

        // Propiedades públicas
        public int Id_Familia
        {
            get { return id_Familia; }
            set { id_Familia = value; }
        }

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        public int IdTipo_Familia
        {
            get { return idTipo_Familia; }
            set { idTipo_Familia = value; }
        }

        public string Persona
        {
            get { return persona; }
            set { persona = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime F_nacimiento
        {
            get { return f_nacimiento; }
            set { f_nacimiento = value; }
        }

        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string L_trabajo
        {
            get { return l_trabajo; }
            set { l_trabajo = value; }
        }

        public string D_trabajo
        {
            get { return d_trabajo; }
            set { d_trabajo = value; }
        }

        public string T_trabajo
        {
            get { return t_trabajo; }
            set { t_trabajo = value; }
        }

        // Constructor vacío
        public cFamilia()
        {
        }

        // Constructor lleno
        public cFamilia(int id_Familia, int idPersona, int idTipo_Familia, string nombre, DateTime f_nacimiento, string ocupacion, string telefono, string l_trabajo, string d_trabajo, string t_trabajo, string persona)
        {
            Id_Familia = id_Familia;
            IdPersona = idPersona;
            IdTipo_Familia = idTipo_Familia;
            Nombre = nombre;
            F_nacimiento = f_nacimiento;
            Ocupacion = ocupacion;
            Telefono = telefono;
            L_trabajo = l_trabajo;
            D_trabajo = d_trabajo;
            T_trabajo = t_trabajo;
            Persona = persona;
        }

        public string Insertar(cFamilia familia)
        {
            string rpta = "";
            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertarRHFamilia", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IDPersona", familia.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDTIPO_FAMILIA", familia.IdTipo_Familia).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Nombre", familia.Nombre).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@F_nacimiento", familia.F_nacimiento).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@Ocupacion", familia.Ocupacion).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Telefono", familia.Telefono).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@L_trabajo", familia.L_trabajo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@D_trabajo", familia.D_trabajo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@T_trabajo", familia.T_trabajo).SqlDbType = SqlDbType.NVarChar;


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

        public string Actualizar(cFamilia familia)
        {
            string rpta = "";

            using (SqlConnection sqlcon = new SqlConnection(Conexion.Cn))
            {
                try
                {
                    sqlcon.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_ActualizarRHFamilia", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", familia.Id_Familia).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDPersona", familia.IdPersona).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@IDTipo_FAMILIA", familia.IdTipo_Familia).SqlDbType = SqlDbType.Int;
                        cmd.Parameters.AddWithValue("@Nombre", familia.Nombre).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@F_nacimiento", familia.F_nacimiento).SqlDbType = SqlDbType.Date;
                        cmd.Parameters.AddWithValue("@Ocupacion", familia.Ocupacion).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@Telefono", familia.Telefono).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@L_trabajo", familia.L_trabajo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@D_trabajo", familia.D_trabajo).SqlDbType = SqlDbType.NVarChar;
                        cmd.Parameters.AddWithValue("@T_trabajo", familia.T_trabajo).SqlDbType = SqlDbType.NVarChar;

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
            DataTable DtResultado = new DataTable("RHFAMILIA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_MostrarRHFamilia";
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

        public DataTable Buscar(cFamilia familia)
        {
            DataTable DtResultado1 = new DataTable("RHFAMILIA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarRHFamilia";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@Persona";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 200;
                ParBuscar.Value = familia.Persona;
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
