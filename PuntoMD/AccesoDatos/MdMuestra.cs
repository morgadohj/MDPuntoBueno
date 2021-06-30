using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccesoDatos
{

   /* public class Muestra
    {
        private SqlConexion conexion = new SqlConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand command = new SqlCommand();
        public DataTable Mostrar()
        {
            command.CommandText = "mostrar_usuario";
            command.CommandType = CommandType.StoredProcedure;
            leer = command.ExecuteReader();
            tabla.Load(leer);
            return tabla;
        }


    
    }*/
    
    
    
    
    
    public class MdMuestra:SqlConexion 
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
    }
}
