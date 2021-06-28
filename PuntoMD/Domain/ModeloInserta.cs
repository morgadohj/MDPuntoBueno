using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Domain
{
   public  class ModeloInserta
    {
        MdIngresa mdIngresa = new MdIngresa();

        public bool insertaUsuario(string nombre, string user, string pass, string rol)
        {
            return mdIngresa.Inserta(nombre, user, pass, rol);
        }
    }
}
