using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class DbAnswers
    {
        public static void AddAnswer(Answer answer)
        {
            string sql = "INSERT INTO answers(`question_id`, `description`) VALUES (@QuestionID, @Description)";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("QuestionID", answer.QuestionId), new MySqlParameter("Description", answer.Description) });
        }

        public static void UpdateAnswer(Answer answer)
        {
            string sql = "UPDATE answers SET description = @Description WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("Description", answer.Description), new MySqlParameter("ID", answer.ID) });
        }

        public static void DeleteAnswer(Answer answer)
        {
            string sql = "DELETE FROM answers WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(Connection.Conn, sql, new MySqlParameter[] { new MySqlParameter("ID", answer.ID)});
        }

        public static List<Answer> GetAllAnsers()
        {
            List<Answer> list = new List<Answer>();

            string sql = "SELECT * FROM answers ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(Connection.Conn, sql);

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    list.Add(new Answer(rdr.GetInt32("id"), rdr.GetInt32("question_id"), rdr.GetString("description")));
                }
            }
            return list;
        }

        public static List<Answer> GetAllAnswersForQuestion(Question q)
        {
            List<Answer> answers = new List<Answer>();

            string sql = "SELECT * FROM answers WHERE question_id = @ID";
            var rdr = MySqlHelper.ExecuteReader(Connection.Conn, sql, new MySqlParameter[] {new MySqlParameter("ID", q.ID)});

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    answers.Add(new Answer(rdr.GetInt32("id"), rdr.GetInt32("question_id"), rdr.GetString("description")));
                }
            }
            return answers;
        }
    }
}
