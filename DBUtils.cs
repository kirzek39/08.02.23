using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace shop
{
    internal class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "shop";
            string user = "root";
            string password = "0000";

            return DBMySqlUtils.GetMySqlConnection(host, port, database, user, password);
        }
    }
}
