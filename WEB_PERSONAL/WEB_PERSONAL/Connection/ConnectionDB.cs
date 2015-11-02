using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.OracleClient;

namespace WEB_PERSONAL.Connection
{
    public static class ConnectionDB
    {
        private static OraConnection conn;
        static ConnectionDB()
        {
            //
            // TODO: Add constructor logic here
            //
            string RMUTTOORCL = ConfigurationManager.RMUTTOORCL["Connectionstring"].ToString();
            conn = new SqlConnection(RMUTTOORCL);
        }

        public static OraConnection GetSqlConnection()
        {
            return conn;
        }

    }
}