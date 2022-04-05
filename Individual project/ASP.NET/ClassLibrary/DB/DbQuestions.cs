using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DB
{
    public static class DbQuestions
    {
        public static void AddQuestion(Question question)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO questions (`description`) VALUES (@Description);";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", question.Description) });
            }
        }

        public static void UpdateQuestion(int questionID, string questionDescription)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE questions SET description = @Description WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", questionDescription), new MySqlParameter("ID", questionID) });
            }
        }

        public static void DeleteQuestion(int questionID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM questions WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", questionID) });
            }
        }


        public static List<Question> GetAllQuestions()
        {
            using (var conn = Connection.OpenConn())
            {
                List<Question> list = new List<Question>();

                string sql = "SELECT * FROM questions ORDER BY id;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        list.Add(new Question(rdr.GetInt32("id"), rdr.GetString("description")));
                    }
                }
                rdr.Close();
                return list;
            }
        }

        public static int GetNextQuestionID()
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'project_db' AND TABLE_NAME = 'questions';";
                var result = MySqlHelper.ExecuteScalar(conn, sql);
                int id = -1;
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
                return id;
            }
        }

        public static int GetInsertedQuestionID()
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id FROM questions ORDER BY id DESC LIMIT 1;";
                var result = MySqlHelper.ExecuteScalar(conn, sql);
                int id = -1;
                if (result is not null)
                {
                    id = Convert.ToInt32(result);
                }
                return id;
            }
        }

        public static Question GetQuestionByID(int questionID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id, description FROM questions WHERE id = @ID";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", questionID) });

                while (rdr.Read())
                {
                    if (rdr is not null)
                    {
                        return new Question(rdr.GetInt32(0), rdr.GetString(1));
                    }
                }
                return null;
            }
        }
    }
}
