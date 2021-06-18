using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace DataAcces
{
    public abstract class ConexionSql
    {
        private readonly string connectionString;
        public ConexionSql()
        {
            connectionString = "Server = 25.79.95.49;DataBase = MDPV; usuario = admin; password = *159753*";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
