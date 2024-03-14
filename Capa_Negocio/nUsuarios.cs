using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class nUsuarios
    {
      
       
        public static DataTable MostrarUsuarios()
        {
            return new cUsuario().Mostrar();
        }

        public static DataTable MostrarPersonaEstado()
        {
            return new cUsuario().MostrarPersonaEstado();
        }

        public static string ActualizarEstadoPersona(int idPeriodo, bool estado)
        {
            cUsuario Obj = new cUsuario();
            return Obj.ActualizarEstadoPersona(idPeriodo, estado);

        }

        public static string ActualizarEstadoUsuario(int idPeriodo, bool estado)
        {
            cUsuario Obj = new cUsuario();
            return Obj.ActualizarEstadoUsuario(idPeriodo, estado);

        }
        public static string InsertarUsuario( string nombreUsuario, string contrasena, bool activo, int tipoUsuario, byte[] foto)
        {
            // Crear una instancia de la clase Usuario (suponiendo que ya tienes una)
            cUsuario usuario = new cUsuario();

            // Establecer las propiedades del objeto con los valores proporcionados
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasena = contrasena;
            usuario.Activo = activo;
            usuario.TipoUsuario = tipoUsuario;
            usuario.Foto = foto;

            // Llamar al método de actualización en la clase Usuario (debes tener este método)
            return usuario.Insertar(usuario);
        }
        public static string EditarUsuario(int id, string nombreUsuario, string contrasena, bool activo, int tipoUsuario,byte[]foto)
        {
            // Crear una instancia de la clase Usuario (suponiendo que ya tienes una)
            cUsuario usuario = new cUsuario();

            // Establecer las propiedades del objeto con los valores proporcionados
            usuario.UsuarioID = id;
            usuario.NombreUsuario = nombreUsuario;
            usuario.Contrasena = contrasena;
            usuario.Activo = activo;
            usuario.TipoUsuario = tipoUsuario;
            usuario.Foto = foto;

            // Llamar al método de actualización en la clase Usuario (debes tener este método)
            return usuario.Actualizar(usuario);
        }

        public static DataTable BuscarUsuario(string textoBuscar)
        {
            cUsuario usuario = new cUsuario();
            usuario.BuscarUsuario = textoBuscar;
            return usuario.Buscar(usuario);
        }

        public static DataTable BuscarPersona(string textoBuscar)
        {
            cUsuario usuario = new cUsuario();
            usuario.BuscarPersona = textoBuscar;
            return usuario.BuscarPersonaId(usuario);
        }


    }
}
