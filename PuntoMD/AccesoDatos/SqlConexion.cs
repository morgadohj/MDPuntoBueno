using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.SqlClient;
namespace AccesoDatos
{
    public abstract class SqlConexion
    {
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
