using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data.SqlClient;
using System.Data;

namespace Domain
{
   public class ModeloMuestra
    {
        private Muestra obetoMuestra = new Muestra();

        public DataTable MostrarProd()
        {

            DataTable tabla = new DataTable();
            tabla = obetoMuestra.Mostrar();
            return tabla;
        }

    }
}
