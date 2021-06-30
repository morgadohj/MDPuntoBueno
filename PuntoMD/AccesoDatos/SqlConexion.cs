using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace AccesoDatos
{
    public  class SqlConexion
    {
        /* private SqlConnection Conexion = new SqlConnection("server= 25.79.95.49; DataBase = MDPV; user id = Admin; Password = *159753*");

         public SqlConnection AbrirConexion()
         {
             if (Conexion.State == ConnectionState.Closed)
                 Conexion.Open();
             return Conexion;
         }

         public SqlConnection CerrarConexion()
         {
             if (Conexion.State == ConnectionState.Open)
                 Conexion.Close();
             return Conexion;
         }
   */



        private readonly string connectionString;
        public SqlConexion()
        {
            connectionString = "data source = 25.79.95.49; initial catalog = MDPV; user id = Admin; Password = *159753*";

        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    } 
}
