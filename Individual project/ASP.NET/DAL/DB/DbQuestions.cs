using Logic.Interfaces;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbQuestions : IQuestionDb, IDbQuestions
    {
        public void AddQuestion(Question q)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO questions (`description`) VALUES (@Description);";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", q.Description) });
            }
        }

        public void EditQuestion(int questionID, string descpription)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE questions SET description = @Description WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", descpription), new MySqlParameter("ID", questionID) });
            }
        }

        public void RemoveQuestion(int questionID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM questions WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", questionID) });
            }
        }


        public List<Question> GetAllQuestions()
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
                        list.Add(new Question(rdr.GetInt32(0), rdr.GetString(1)));
                    }
                }
                rdr.Close();
                return list;
            }
        }

        public int GetNextQuestionID()
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'project_db' AND TABLE_NAME = 'questions';";
                var result = MySqlHelper.ExecuteScalar(conn, sql);
                int id = -1;
                if (result != null)
                {
                    id = Convert.ToInt32((object?) result);
                }
                return id;
            }
        }

        public int GetInsertedQuestionID()
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT id FROM questions ORDER BY id DESC LIMIT 1;";
                var result = MySqlHelper.ExecuteScalar(conn, sql);
                int id = -1;
                if (result is not null)
                {
                    id = Convert.ToInt32((object?) result);
                }
                return id;
            }
        }

        public Question GetQuestionByID(int questionID)
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
