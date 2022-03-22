using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public static class DbPrograms
    {
        public static void AddProgram(TrainigProgram program)
        {
            var conn = Connection.OpenConn();
            string sql = "INSERT INTO programs (description, type_id) VALUES (@Description, @TypeID)";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description), new MySqlParameter("TypeID", program.TypeID) });
            conn.Close();
        }

        public static void UpdateProgram(TrainigProgram program)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE programs SET description = @Description, type_id = @TypeID WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", program.Description), new MySqlParameter("TypeID", program.TypeID), new MySqlParameter("ID", program.ID) });
            conn.Close();
        }

        public static void DeleteProgram(TrainigProgram program)
        {
            var conn = Connection.OpenConn();
            string sql = "DELETE FROM programs WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", program.ID) });
            conn.Close();
        }

        public static List<TrainigProgram> GetAllPrograms()
        {
            List<TrainigProgram> list = new List<TrainigProgram>();

            var conn = Connection.OpenConn();
            string sql = "SELECT * FROM programs ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(conn, sql);

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        list.Add(new TrainigProgram(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2)));
                    }
                }
                rdr.Close();
                conn.Close();
                return list;
        }

        public static int GetInsertedProgramID()
        {
            var conn = Connection.OpenConn();
            string sql = "SELECT id FROM programs ORDER BY id DESC LIMIT 1;";
            var result = MySqlHelper.ExecuteScalar(conn, sql);
            int id = -1;
            if (result is not null)
            {
                id = Convert.ToInt32(result);
            }
            conn.Close();
            return id;
        }

        public static TrainigProgram GetProgramByID(int programID)
        {
            var conn = Connection.OpenConn();
            string sql = "SELECT * FROM programs WHERE id = @ID";
            var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", programID) });

            while (rdr.Read())
            {
                if (rdr is not null)
                {
                    return new TrainigProgram(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
                }
            }
            conn.Close();
            return null;
        }
    }
}
