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
        public int IdUbicacio { get; set; }
        public int IdSocioEconimico { get; set; }
        public int IdOtrosDatos { get; set; }
        public int IdFisicoBiologico { get; set; }
        public int IdExperienciaLaboral { get; set; }
        public int IdDatosAdicionales { get; set; }
        public int IdReferenciaLaboral { get; set; }
        public int IdReferenciaPersonal { get; set; }
        public string IdPersona { get; set; }
        public int IdIdioma { get; set; }
        public int IdEducacion { get; set; }
        public int IdFamilia { get; set; }


        public cHome ()
        {
        }

        public cHome( 
            int idUbicacion, int idSocioEconomico, int idotrosDatos,
            int idFisicoBiologico, int idExperienciaLaboral, int idDatosAdicionales,
            int idReferenciaLaboral, int idReferenciaPersonal,string idPersona,
            int idIdioma,int idEducacuion,int idFamilia
          
            )

        {
            IdUbicacio = idUbicacion;
            IdSocioEconimico = idSocioEconomico;
            IdOtrosDatos = idotrosDatos;
            IdFisicoBiologico = idFisicoBiologico;
            IdExperienciaLaboral = idExperienciaLaboral;
            IdDatosAdicionales = idDatosAdicionales;
            IdReferenciaLaboral = idReferenciaLaboral;
            IdReferenciaPersonal = idReferenciaPersonal;
            IdPersona = idPersona;
            IdIdioma = idIdioma;
            IdEducacion = idEducacuion;
            IdFamilia = idFamilia;
  
        }


        public DataTable UbicacionPersona(cHome ubicacion)
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

                SqlParameter Ubicacion = new SqlParameter();
                Ubicacion.ParameterName = "@IdUbicacion";
                Ubicacion.SqlDbType = SqlDbType.Int;
                Ubicacion.Value = ubicacion.IdUbicacio;
                sqlcmd.Parameters.Add(Ubicacion);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable SocioeconomicoPersona(cHome socioeconomico)
        {
            DataTable DtResultado1 = new DataTable("RHSOCIOECONOMICO");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeRHSOCIOECONOMICO";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter SocioEconomico = new SqlParameter();
                SocioEconomico.ParameterName = "@IdSocioEconomico";
                SocioEconomico.SqlDbType = SqlDbType.Int;
                SocioEconomico.Value = socioeconomico.IdSocioEconimico;
                sqlcmd.Parameters.Add(SocioEconomico);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable OtrosDatosPersona(cHome otrosdatos)
        {
            DataTable DtResultado1 = new DataTable("RHOTROSDATOS");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeRHOTROSDATOS";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter OtrosDatos = new SqlParameter();
                OtrosDatos.ParameterName = "@IdOtrosDatos";
                OtrosDatos.SqlDbType = SqlDbType.Int;
                OtrosDatos.Value = otrosdatos.IdOtrosDatos;
                sqlcmd.Parameters.Add(OtrosDatos);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable FisicoBialogicaPersona(cHome fisicabiologica)
        {
            DataTable DtResultado1 = new DataTable("RHFISICABIOLOGICA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeRHFISICABIOLOGICA";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter FisicaBiologica = new SqlParameter();
                FisicaBiologica.ParameterName = "@IdFisicaBiologica";
                FisicaBiologica.SqlDbType = SqlDbType.Int;
                FisicaBiologica.Value = fisicabiologica.IdFisicoBiologico;
                sqlcmd.Parameters.Add(FisicaBiologica);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable ExperienciaLaboralPersona(cHome experiencialaboral)
        {
            DataTable DtResultado1 = new DataTable("RHEXPERIENCIALABORAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeRHEXPERIENCIALABORAL";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ExperienciaLaboral = new SqlParameter();
                ExperienciaLaboral.ParameterName = "@IdExperienciaLaboral";
                ExperienciaLaboral.SqlDbType = SqlDbType.Int;
                ExperienciaLaboral.Value = experiencialaboral.IdExperienciaLaboral;
                sqlcmd.Parameters.Add(ExperienciaLaboral);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable DatosAdicionalesPersona(cHome datosadicionales)
        {
            DataTable DtResultado1 = new DataTable("RHDATOSADICIONALES");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeRHDATOSADICIONALES";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter DatosAdicionales = new SqlParameter();
                DatosAdicionales.ParameterName = "@IdDatosAdicionales";
                DatosAdicionales.SqlDbType = SqlDbType.Int;
                DatosAdicionales.Value = datosadicionales.IdDatosAdicionales;
                sqlcmd.Parameters.Add(DatosAdicionales);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }


        public DataTable ReferenciaLaboralPersona(cHome referencialaboral)
        {
            DataTable DtResultado1 = new DataTable("RHREFERENCIALABORAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeReferenciaLaboral";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ReferenciaLaboral = new SqlParameter();
                ReferenciaLaboral.ParameterName = "@IdReferenciaLaboral";
                ReferenciaLaboral.SqlDbType = SqlDbType.Int;
                ReferenciaLaboral.Value = referencialaboral.IdReferenciaLaboral;
                sqlcmd.Parameters.Add(ReferenciaLaboral);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable ReferenciaPersonalPersona(cHome referenciapersonal)
        {
            DataTable DtResultado1 = new DataTable("RHREFERENCIAPERSONAL");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeReferenciaPersonal";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ReferenciaPersonal = new SqlParameter();
                ReferenciaPersonal.ParameterName = "@IdReferenciaPersonal";
                ReferenciaPersonal.SqlDbType = SqlDbType.Int;
                ReferenciaPersonal.Value = referenciapersonal.IdReferenciaPersonal;
                sqlcmd.Parameters.Add(ReferenciaPersonal);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable MostrarPersona()
        {
            DataTable DtResultado = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomePersona";
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

        public DataTable IdiomaPersona(cHome idioma)
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

                SqlParameter Idioma = new SqlParameter();
                Idioma.ParameterName = "@IdIdioma";
                Idioma.SqlDbType = SqlDbType.Int;
                Idioma.Value = idioma.IdIdioma;
                sqlcmd.Parameters.Add(Idioma);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable EducacionPersona(cHome educacion)
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

                SqlParameter Educacion = new SqlParameter();
                Educacion.ParameterName = "@IdEducacion";
                Educacion.SqlDbType = SqlDbType.Int;
                Educacion.Value = educacion.IdEducacion;
                sqlcmd.Parameters.Add(Educacion);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }

        public DataTable FamiliaPersona(cHome familia)
        {
            DataTable DtResultado1 = new DataTable("RHFAMILIA");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_ListarHomeFamilia";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Familia = new SqlParameter();
                Familia.ParameterName = "@IdFamilia";
                Familia.SqlDbType = SqlDbType.Int;
                Familia.Value = familia.IdFamilia;
                sqlcmd.Parameters.Add(Familia);

                SqlDataAdapter sqlDat = new SqlDataAdapter(sqlcmd);
                sqlDat.Fill(DtResultado1);
            }
            catch (Exception ex)
            {
                DtResultado1 = null;
            }
            return DtResultado1;
        }


        public DataTable BuscarPersona(cHome persona)
        {
            DataTable DtResultado1 = new DataTable("RHPersona");
            SqlConnection sqlconn = new SqlConnection();
            try
            {
                sqlconn.ConnectionString = Conexion.Cn;
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandText = "sp_BuscarHomePersona";
                sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Persona = new SqlParameter();
                Persona.ParameterName = "@Persona";
                Persona.SqlDbType = SqlDbType.NVarChar;
                Persona.Size = 200;
                Persona.Value = persona.IdPersona;
                sqlcmd.Parameters.Add(Persona);

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
