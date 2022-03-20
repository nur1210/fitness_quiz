using MyProject.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DB
{
    public static class DbQuestionView
    {
        public static void AddQuestionView(QuestionView question)
        {
            var conn = Connection.OpenConn();
            string sql = "INSERT INTO questions (`description`) VALUES (@Description);";
            MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", question.Description) });
            conn.Close();
        }

        public static void UpdateQuestionView(QuestionView question)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE questions SET description = @Description WHERE id = @ID;";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", question.Description), new MySqlParameter("ID", question.ID) });
            conn.Close();
        }

        public static void DeleteQuestionView(int questionID)
        {
            var conn = Connection.OpenConn();
            string sql = "DELETE FROM questions WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", questionID) });
            conn.Close();
        }
        public static List<QuestionView> GetAllQuestionsForView()
        {
            var conn = Connection.OpenConn();
            string sql = "SELECT q.id, q.description, a.description FROM questions AS q INNER JOIN answers AS a ON q.id = a.question_id;";
            var rdr = MySqlHelper.ExecuteReader(conn, sql);

            List<QuestionView> list = new List<QuestionView>();

            while (rdr.Read())
            {
                var line = rdr;
                if (line is not null)
                {
                    if (list.Count == 0)
                    {
                        list.Add(new QuestionView(line.GetInt32(0), line.GetString(1), new List<Answer>() { new Answer(line.GetInt32(0), line.GetString(2)) }));
                    }
                    else
                    {
                        foreach (var item in list.ToList())
                        {
                            if (line.GetInt32(0) != item.ID)
                            {
                                list.Add(new QuestionView(line.GetInt32(0), line.GetString(1), new List<Answer>() { new Answer(item.ID, line.GetString(2)) }));
                            }
                            else
                            {
                                item.Answers.Add(new Answer(item.ID, line.GetString(2)));
                            }
                        }
                    }
                }
            }
            rdr.Close();
            conn.Close();
            return list;
        }
    }
}
