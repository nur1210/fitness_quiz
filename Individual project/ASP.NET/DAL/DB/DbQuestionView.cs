using Logic.Interfaces;
using Logic.Managers;
using Logic.Models;
using Logic.View;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbQuestionView : IQuestionViewDb, IDbQuestionView
    {
        public List<QuestionView> GetAllQuestionsForView()
        {
            using (var conn = Connection.OpenConn())
            {
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
                return list;
            }
        }
    }
}
