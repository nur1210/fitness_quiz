using MySql.Data.MySqlClient;

namespace Logic.Managers
{
    public static class Connection
    {
        private static string conn_str = "Server=studmysql01.fhict.local;Uid=dbi495554;Database=dbi495554;Pwd=Nechushtan!998;";
        //private static string conn_str = "Server=localhost;Uid=root;Database=test; port=3307; Pwd=";

        private static string Conn => conn_str;

        public static MySqlConnection OpenConn()
        {
            MySqlConnection conn = new MySqlConnection(Conn);
            conn.Open();
            return conn;
        }
    }
}
