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
        public static List<QuestionView> GetAllQuestionsForView()
        {
            string sql = "SELECT q.id, q.description, a.description FROM questions AS q INNER JOIN answers AS a ON q.id = a.question_id;";
            var rdr = MySqlHelper.ExecuteReader(Connection.OpenConn(), sql);

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
            Connection.OpenConn().Close();
            return list;
        }
    }
}
