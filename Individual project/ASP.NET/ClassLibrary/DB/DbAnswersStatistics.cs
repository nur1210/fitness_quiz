using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DB
{
    public static class DbAnswersStatistics
    {
        public static void AddAnswerStatistic(int userID,int answerID, int questionID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO answers_statistics (user_id ,answer_id, question_id) VALUES (@UserID, @AnswerID, @QuestionID)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] {new MySqlParameter("UserID", userID) ,new MySqlParameter("AnswerID", answerID), new MySqlParameter("QuestionID", questionID) });
            }
        }
    }
}
