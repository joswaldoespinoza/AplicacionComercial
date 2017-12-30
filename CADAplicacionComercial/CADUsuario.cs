using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADAplicacionComercial
{
    public class CADUsuario
    {
        private static DSAplicacionComercialTableAdapters.UsuarioTableAdapter adaptador = new DSAplicacionComercialTableAdapters.UsuarioTableAdapter();

        public static bool ValidarUsuario(String IdUsuario, String Clave)
        {
            if (adaptador.sp_ValidaUsuario(IdUsuario, Clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
