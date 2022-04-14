using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbQuestionOptionScore : IDbQuestionOptionScore
    {
        public void AddScore(Score s)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO question_option_score (question_option_id, program_id, weight) VALUES (@QuestionOptionID, @ProgramID, @Weight)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("QuestionOptionID", s.QuestionOptionID),
                    new MySqlParameter("ProgramID", s.ProgramID), new MySqlParameter("Weight", s.Weight) });
            }
        }

        public void UpdateScore(Score s)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE question_option_score SET weight = @Weight WHERE question_option_id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Weight", s.Weight),
                    new MySqlParameter("ID", s.QuestionOptionID) });
            }
        }

        public void DeleteScore(Score s)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM question_option_score WHERE question_option_id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", s.QuestionOptionID) });
            }
        }

        public List<Score> GetAllScores()
        {
            using (var conn = Connection.OpenConn())
            {
                List<Score> list = new List<Score>();

                string sql = "SELECT * FROM question_option_score;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);

                while (rdr.Read())
                {
                    list.Add(new Score(rdr.GetInt32(0), rdr.GetInt32(1), rdr.GetInt32(2)));
                }
                rdr.Close();
                return list;
            }
        }
    }
}
