using MySql.Data.MySqlClient;

namespace Logic.Managers
{
    public static class Connection
    {
        //private static string conn_str = "Server=localhost;Uid=root;Database=project_db;Pwd=123456";
        private static string conn_str = "Server=localhost;Uid=root;Database=test; port=3307; Pwd=";

        private static string Conn => conn_str;

        public static MySqlConnection OpenConn()
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            conn.Open();
            return conn;
        }
    }
}
