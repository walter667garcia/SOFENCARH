using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    internal class Conexion
    {
        // Obtener los valores de configuración de la aplicación
        private static string Server = ConfigurationManager.AppSettings["Server"];
        private static string Database = ConfigurationManager.AppSettings["Database"];
        private static string User = ConfigurationManager.AppSettings["User"];
        private static string Password = ConfigurationManager.AppSettings["Password"];


        // Crear la cadena de conexión utilizando los valores obtenidos
        public static string Cn => $"Data Source={Server};Initial Catalog={Database};User ID={User};Password={Password};";
    }
}
