using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class Datos
    {
        //Metodo para mostar los datos necesarios para una persona
        public DataSet CargarDatosPersona()
        {
            DataSet dataSet = new DataSet();
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;

                // Crear un adaptador de datos para cada procedimiento almacenado
                SqlDataAdapter religionAdapter = new SqlDataAdapter("sp_ReligionMostrar", sqlconn);
                SqlDataAdapter etniaAdapter = new SqlDataAdapter("sp_EtniaMostrar", sqlconn);
                SqlDataAdapter generoAdapter = new SqlDataAdapter("sp_GeneroMostrar", sqlconn);
                SqlDataAdapter municipioAdapter = new SqlDataAdapter("sp_ListarMunicipio", sqlconn);
                SqlDataAdapter estadoCivilAdapter = new SqlDataAdapter("sp_EstadoCivilMostrar", sqlconn);

                // Llenar los DataTable en el DataSet
                religionAdapter.Fill(dataSet, "TYRELIGION");
                etniaAdapter.Fill(dataSet, "TYETNIA");
                generoAdapter.Fill(dataSet, "TYGENERO");
                municipioAdapter.Fill(dataSet, "TYMUNICIPIO");
                estadoCivilAdapter.Fill(dataSet, "TYESTADOCIVIL");
            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
                throw new Exception("Error al cargar datos", ex);
            }

            return dataSet;
        }


        //Metodo para mostrar otras tablas para RHIDIOMA
        public DataSet CargarDatosRhIdioma()
        {
            DataSet dataSet = new DataSet();
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;

                // Crear un adaptador de datos para cada procedimiento almacenado
                SqlDataAdapter rhPersona = new SqlDataAdapter("sp_ListarPersona", sqlconn);
                SqlDataAdapter idioma = new SqlDataAdapter("sp_ListarIdioma", sqlconn);
                SqlDataAdapter tipoFamilia = new SqlDataAdapter("sp_ListarTipoFamilia", sqlconn);
                SqlDataAdapter tyLocalizacion = new SqlDataAdapter("sp_ListarTyLocalizacion", sqlconn);
                SqlDataAdapter tyAcademico = new SqlDataAdapter("sp_ListarTYNivelAcademico", sqlconn);
                SqlDataAdapter tyVehiculo = new SqlDataAdapter("sp_ListarTYVEHICULO", sqlconn);
                SqlDataAdapter tyVivienda = new SqlDataAdapter("sp_ListarTYVIVIENDA", sqlconn);
                SqlDataAdapter tyAgrupacion = new SqlDataAdapter("sp_ListarTYAGRUPACION", sqlconn);




                // Llenar los DataTable en el DataSet
                rhPersona.Fill(dataSet, "RHPERSONA");
                idioma.Fill(dataSet, "TYIDIOMA");
                tipoFamilia.Fill(dataSet, "TYTIPOFAMILIA");
                tyLocalizacion.Fill(dataSet, "TyLocalizacion");
                tyAcademico.Fill(dataSet, "TYNIVELACADEMICO");
                tyVehiculo.Fill(dataSet, "TYVEHICULO");
                tyVivienda.Fill(dataSet, "TYVIVIENDA");
                tyAgrupacion.Fill(dataSet, "TYAGRUPACION");

            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
                throw new Exception("Error al cargar datos", ex);
            }

            return dataSet;
        }



        //
        public DataSet CargarDatosPuestoFuncional()
        {
            DataSet dataSet = new DataSet();
            SqlConnection sqlconn = new SqlConnection();

            try
            {
                sqlconn.ConnectionString = Conexion.Cn;

                // Crear un adaptador de datos para cada procedimiento almacenado
                SqlDataAdapter puestoFuncional = new SqlDataAdapter("sp_ListarPuestoNominal", sqlconn);
                SqlDataAdapter unidadSeccion = new SqlDataAdapter("sp_ListarUnidadSeccion", sqlconn);
                SqlDataAdapter renglonPresupuestario = new SqlDataAdapter("sp_ListarTYRENGLONPRESUPUESTARIO", sqlconn);


                // Llenar los DataTable en el DataSet
                puestoFuncional.Fill(dataSet, "TYPUESTONOMINAL");
                unidadSeccion.Fill(dataSet, "TYUNIDADSECCION");
                renglonPresupuestario.Fill(dataSet, "TYRENGLONPRESUPUESTARIO");

            }
            catch (Exception ex)
            {
                // Manejar la excepción si es necesario
                throw new Exception("Error al cargar datos", ex);
            }

            return dataSet;
        }
      }
}
