using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbAnswersStatistics : IDbAnswersStatistics
    {
        public List<Answer> GetAllAnswersAnsweredByAllUsers()
        {
            using (var conn = Connection.OpenConn())
            {
                List<Answer> list = new List<Answer>();

                string sql = "SELECT qo.id, qo.question_id, qo.description FROM question_options as qo INNER JOIN " +
                             "user_answers as ua ON qo.id = ua.question_option_id WHERE qo.id = ua.question_option_id;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);
                while (rdr.Read())
                {
                    list.Add(new Answer(rdr.GetInt32(0), rdr.GetInt32(1),
                        rdr.GetString(2)));
                }
                rdr.Close();
                return list;
            }
        }
    }
}
