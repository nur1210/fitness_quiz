using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class DbPrograms
    {
        public static void AddProgram(TrainigProgram program)
        {
            var conn = Connection.OpenConn();
            string sql = "INSERT INTO programs (`description`) VALUES (@Description)";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description) });
            conn.Close();
        }

        public static void UpdateProgram(TrainigProgram program)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE programs SET description = @Description WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description), new MySqlParameter("ID", program.Description) });
            conn.Close();
        }

        public static void DeleteProgram(TrainigProgram program)
        {
            var conn = Connection.OpenConn();
            string sql = "DELETE FROM programs WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", program.ID) });
            conn.Close();
        }

        /*public List<TrainigProgram> GetAllPrograms()
        {
            List<TrainigProgram> list = new List<TrainigProgram>();

            string sql = "SELECT * FROM programs ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(Connection.Conn, sql);

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        list.Add(new TrainigProgram(rdr.GetInt32("id"), rdr.GetString("description"), rdr.GetInt32("type_id")));
                    }
                }
                rdr.Close();
                return list;
        }*/
    }
}
