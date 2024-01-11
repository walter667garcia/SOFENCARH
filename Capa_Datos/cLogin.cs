using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cLogin
    {
        public bool AuthenticateUser(string username, string password, out bool isValid, out string userType)
        {
            using (SqlConnection connection = new SqlConnection(Conexion.Cn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_AutenticarUsuario", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@NombreUsuario", username);
                    command.Parameters.AddWithValue("@Contrasena", password);

                    SqlParameter isValidParameter = new SqlParameter("@EsValido", SqlDbType.Bit);
                    isValidParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(isValidParameter);

                    SqlParameter userTypeParameter = new SqlParameter("@TipoUsuario", SqlDbType.NVarChar, 50);
                    userTypeParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(userTypeParameter);

                    command.ExecuteNonQuery();

                    isValid = (bool)isValidParameter.Value;
                    userType = userTypeParameter.Value.ToString();

                    return isValid;
                }
            }
        }

    }
}
