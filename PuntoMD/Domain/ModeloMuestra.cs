using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Domain
{
    public class ModeloMuestra 
    {
        MdMuestra mdMuestra = new MdMuestra();
        public bool muestraUsuario()
        {
            return mdMuestra.Muestra();
        }
    }
}
