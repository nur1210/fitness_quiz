using Logic.IDb;
using Logic.Interfaces;
using Logic.Managers;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbAnswersStatistics : IAnswerStatisticDb, IDbAnswersStatistics
    {
        public void AddAnswerStatistic(int userID, int answerID, int questionID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO answers_statistics (user_id ,answer_id, question_id) VALUES (@UserID, @AnswerID, @QuestionID)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("UserID", userID), new MySqlParameter("AnswerID", answerID), new MySqlParameter("QuestionID", questionID) });
            }
        }
    }
}
