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
            var conn = Connection.OpenConn();
            string sql = "INSERT INTO answers(`question_id`, `description`) VALUES (@QuestionID, @Description)";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("QuestionID", answer.QuestionId), new MySqlParameter("Description", answer.Description) });
            conn.Close();
        }

        public static void UpdateAnswer(Answer answer)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE answers SET description = @Description WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", answer.Description), new MySqlParameter("ID", answer.ID) });
            conn.Close();
        }

        public static void DeleteAnswer(Answer answer)
        {
            var conn = Connection.OpenConn();
            string sql = "DELETE FROM answers WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", answer.ID)});
            conn.Close();
        }

        public static List<Answer> GetAllAnsers()
        {
            var conn = Connection.OpenConn();
            List<Answer> list = new List<Answer>();

            string sql = "SELECT * FROM answers ORDER BY id;";
            var rdr = MySqlHelper.ExecuteReader(conn, sql);

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    list.Add(new Answer(rdr.GetInt32("id"), rdr.GetInt32("question_id"), rdr.GetString("description")));
                }
            }
            rdr.Close();
            conn.Close();
            return list;
        }

        public static List<Answer> GetAllAnswersForQuestion(Question question)
        {
            var conn = Connection.OpenConn();
            List<Answer> answers = new List<Answer>();

            string sql = "SELECT * FROM answers WHERE question_id = @ID";
            var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] {new MySqlParameter("ID", question.ID) });

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    answers.Add(new Answer(rdr.GetInt32("id"), rdr.GetInt32("question_id"), rdr.GetString("description")));
                }
            }
            rdr.Close();
            conn.Close();
            return answers;
        }
    }
}
