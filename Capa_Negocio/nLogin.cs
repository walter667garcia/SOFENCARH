using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nLogin
    {
        public cLogin  userRepository;

        public nLogin()
        {
            userRepository = new cLogin();
        }

        public bool AuthenticateUser(string username, string password, out bool isValid, out string userType)
        {
            return userRepository.AuthenticateUser(username, password, out isValid, out userType);
        }
    }
}
