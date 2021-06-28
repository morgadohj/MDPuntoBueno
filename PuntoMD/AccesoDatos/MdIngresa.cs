using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class MdIngresa:SqlConexion 
        {

        public bool Inserta (string nombre, string user, string pass, string rol)
        {
            using ( var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    
                        command.Connection = connection;
                        SqlCommand cmd = new SqlCommand();
                        cmd = new SqlCommand("insertar_usuario", connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@login", user);
                        cmd.Parameters.AddWithValue("@password", pass);
                        cmd.Parameters.AddWithValue("@rol", rol);
                        cmd.Parameters.AddWithValue("@estado", "Activo");
                        cmd.ExecuteNonQuery();

                    return true;
                        
                    
                  
                }
            }
        }
        
    }
}

//@nombre 
//@login 
//@password 
//@rol 
//@estado 