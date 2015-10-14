using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Rmutto.Connection
{
    public static class ConnectionDB
    {
        private static SqlConnection conn;
        static ConnectionDB()
        {
            //
            // TODO: Add constructor logic here
            //
            string connectionString = ConfigurationManager.ConnectionStrings["Connectionstring"].ToString();
            conn = new SqlConnection(connectionString);
        }

        public static SqlConnection GetSqlConnection()
        {
            return conn;
        }

    }
}