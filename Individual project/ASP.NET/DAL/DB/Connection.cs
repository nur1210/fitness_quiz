﻿using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public static class Connection
    {
        //private static string conn_str = "Server=localhost;Uid=root;Database=project_db;Pwd=123456";
        private static string conn_str = "Server=localhost;Uid=root;Database=test; port=3307; Pwd=";


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
