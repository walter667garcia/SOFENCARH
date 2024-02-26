using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cPuestoNominal
    {
        
        public int IdPuestoNominal { get; set; }
     

        public string PuestoNominal { get; set; }
       

        public string TextoBuscar { get; set; }


        // Constructor vacío
        public cPuestoNominal()
        {
        }

        // Constructor con parámetros
        public cPuestoNominal(int idPuestoNominal, string puestoNominal, string textoBuscar)
        {
            this.IdPuestoNominal = idPuestoNominal;
            this.PuestoNominal = puestoNominal;
            this.TextoBuscar = textoBuscar;
        }

        // Método Insertar
        public string Insertar(cPuestoNominal puestoNominal)
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
                cmd.CommandText = "sp_PuestoNominalInsertar";
                cmd.CommandType = CommandType.StoredProcedure;

                // Crear un SqlParameter para el puesto nominal
                SqlParameter ParPuestoNominal = new SqlParameter();
                ParPuestoNominal.ParameterName = "@puestoNominal";
                ParPuestoNominal.SqlDbType = SqlDbType.VarChar;
                ParPuestoNominal.Size = 50;
                ParPuestoNominal.Value = puestoNominal.PuestoNominal;
                cmd.Parameters.Add(ParPuestoNominal);


                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No ingresó el registro";
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

        // Método Editar
        public string Editar(cPuestoNominal puestoNominal)
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
                cmd.CommandText = "sp_PuestoNominalEditar";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPuestoNominal = new SqlParameter();
                ParIdPuestoNominal.ParameterName = "@Id";
                ParIdPuestoNominal.SqlDbType = SqlDbType.Int;
                ParIdPuestoNominal.Value = puestoNominal.IdPuestoNominal;
                cmd.Parameters.Add(ParIdPuestoNominal);

                // Crear un SqlParameter para el puesto nominal
                SqlParameter ParPuestoNominal = new SqlParameter();
                ParPuestoNominal.ParameterName = "@puestoNominal";
                ParPuestoNominal.SqlDbType = SqlDbType.VarChar;
                ParPuestoNominal.Size = 50;
                ParPuestoNominal.Value = puestoNominal.PuestoNominal;
                cmd.Parameters.Add(ParPuestoNominal);

               
             

                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No actualizó el registro";
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
        // Método Eliminar
        public string Eliminar(cPuestoNominal puestoNominal)
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
                cmd.CommandText = "sp_PuestoNominalEliminar";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdPuestoNominal = new SqlParameter();
                ParIdPuestoNominal.ParameterName = "@idPuestoNominal";
                ParIdPuestoNominal.SqlDbType = SqlDbType.Int;
                ParIdPuestoNominal.Value = puestoNominal.IdPuestoNominal;
                cmd.Parameters.Add(ParIdPuestoNominal);

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

        // Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("TyPuestoNominal");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_PuestoNominalMostrar";
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
        public DataTable BuscarPuestoNominal(cPuestoNominal puestoNominal)
        {
            DataTable DtResultado1 = new DataTable("TyPuestoNominal");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_PuestoNominalBuscar";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@textoBuscar";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 40;
                ParBuscar.Value = puestoNominal.TextoBuscar;
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
