using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Domain
{
    public class ModeloMuestra : MdMuestra
    {
        MdMuestra mdMuestra = new MdMuestra();
        public bool muestraUsuario(string nombre, string user, string pass, string rol)
        {
            return mdMuestra.Muestra(nombre, user, pass, rol);
        }
    }
}
