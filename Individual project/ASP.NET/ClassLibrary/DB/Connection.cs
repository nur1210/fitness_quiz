using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ClassLibrary.DB
{
    public static class Connection
    {
        private static string conn_str = "Server=localhost;Uid=root;Database=project_db;Pwd=123456";

        public static string Conn
        {
            get { return conn_str; }
        }

        public static MySqlConnection OpenConn()
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            conn.Open();
            return conn;
        }
    }
}
