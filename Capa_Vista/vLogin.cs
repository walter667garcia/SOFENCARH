using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista
{
    public class vLogin
    {
        public nLogin login;
        
       public vLogin() { 
            login = new nLogin();
        }
       public bool validad(string username, string password, out bool isValid, out string userType)
        {
          
            return login.AuthenticateUser(username,password,out isValid, out userType);
        }
    }
}
