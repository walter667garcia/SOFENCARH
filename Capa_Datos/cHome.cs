using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cHome
    {

        private string _educacionDPI;
        private string _ubicacionPDI;
        private string _idiomaDPI;
        private string _familiaDPI;


        public string EducacionDPI
        {
            get { return _educacionDPI; }
            set { _educacionDPI = value; }
        }

        public string UbicacionDPI
        {
            get { return _ubicacionPDI; }
            set { _ubicacionPDI = value; }
        }

        public string IdiomaDPI
        {
            get { return _idiomaDPI; }
            set { _idiomaDPI = value; }
        }

        public string FamiliaDPI
        {
            get { return _familiaDPI; }
            set { _familiaDPI = value; }
        }
        public cHome() { 
        }
        public cHome(string educacionDPI, string ubicacionPDI, string idiomaDPI, string familiaDPI)
        {
            _educacionDPI = educacionDPI;
            _ubicacionPDI = ubicacionPDI;
            _idiomaDPI = idiomaDPI;
            _familiaDPI = familiaDPI;
          
        }

        public DataSet HomeInformacion()
        {
            DataSet dataSet = new DataSet();
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;

                // Crear un adaptador de datos para cada procedimiento almacenado
                SqlDataAdapter personaInformacion = new SqlDataAdapter("sp_ListarHomePersona", sqlconn);
                // Llenar los DataTable en el DataSet
                personaInformacion.Fill(dataSet, "RHPersona");

            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
                throw new Exception("Error al cargar datos", ex);
            }

            return dataSet;
        }


        public DataTable BuscarEducacion(cHome educacion)
        {
            DataTable DtResultado1 = new DataTable("RHNIVELACADEMICO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_listarHomeEducacion";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@DPI";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 15;
                ParBuscar.Value = educacion.EducacionDPI;
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

        public DataTable BuscarUbicacion(cHome educacion)
        {
            DataTable DtResultado1 = new DataTable("RHLOCALIZACION");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeUbicacion";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@DPI";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 15;
                ParBuscar.Value = educacion.UbicacionDPI;
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


        public DataTable BuscarIdioma(cHome educacion)
        {
            DataTable DtResultado1 = new DataTable("RHIDIOMA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeidioma";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@DPI";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 15;
                ParBuscar.Value = educacion.IdiomaDPI;
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

        public DataTable BuscarFamilia(cHome educacion)
        {
            DataTable DtResultado1 = new DataTable("RHFAMILIA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarFamilia";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParBuscar = new SqlParameter();
                ParBuscar.ParameterName = "@DPI";
                ParBuscar.SqlDbType = SqlDbType.VarChar;
                ParBuscar.Size = 15;
                ParBuscar.Value = educacion.FamiliaDPI;
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
