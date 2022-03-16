using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public static class DbQuestions
    {
        public static void AddQuestion(Question question)
        {
            string sql = "INSERT INTO questions (`description`) VALUES (@Description);";
            MySqlHelper.ExecuteReader(Connection.OpenConn(), sql, new MySqlParameter[] { new MySqlParameter("Description", question.Description) });
            Connection.OpenConn().Close();
        }

        public static void UpdateQuestion(Question question)
        {
            string sql = "UPDATE questions SET description = @Description WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("Description", question.Description), new MySqlParameter("ID", question.ID) });
        }

        public static void DeleteQuestion(Question question)
        {
            string sql = "DELETE FROM questions WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("ID", question.ID) });
        }


        public static List<Question> GetAllQuestions()
        {
            List<Question> list = new List<Question>();

            string sql = "SELECT * FROM questions ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(Connection.Conn, sql);

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

        public static int GetNextQuestionID()
        {
            string sql = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'project_db' AND TABLE_NAME = 'questions';";
            var result = MySqlHelper.ExecuteScalar(Connection.Conn, sql);
            int id = -1;
            if (result != null)
            {
                id = Convert.ToInt32(result);
            }
            return id;
        }

        public static int GetInsertedQuestionID()
        {
            string sql = "SELECT id FROM questions ORDER BY id DESC LIMIT 1;";
            var result = MySqlHelper.ExecuteScalar(Connection.OpenConn(), sql);
            int id = -1;
                if (result is not null)
                {
                    id = Convert.ToInt32(result);
                }
            return id;
        }
    }
}
