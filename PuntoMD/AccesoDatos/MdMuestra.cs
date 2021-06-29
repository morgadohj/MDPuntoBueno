using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccesoDatos
{

    class Muestra
    {
        private SqlConexion = new SqlConexionn();

    
    }
    
    
    
    
    
    /*public class MdMuestra:SqlConexion 
    {
        public bool Muestra()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter da;
                    da = new SqlDataAdapter("mostrar_usuarios", connection);
                     da.Fill(dt);

                    return da;

                       }
            }

          
        }
    }*/
}
