using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Models;
using MySql.Data.MySqlClient;

namespace ClassLibrary.DB
{
    public static class DbQuestionOptionScore
    {
        public static void AddOptionScore(Score s)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO question_option_score (question_option_id, program_id, weight) VALUES (@QuestionOptionID, @ProgramID, @Weight)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("QuestionOptionID", s.QuestionOptionID), 
                    new MySqlParameter("ProgramID", s.ProgramID), new MySqlParameter("Weight", s.Weight) });
            }
        }

        public static void RemoveOptionScore(Score s)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE question_option_score SET weight = @Weight WHERE question_option_id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Weight", s.Weight), 
                    new MySqlParameter("ID", s.QuestionOptionID) });
            }
        }

        public static void DeleteAnswer(Score s)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM answers WHERE question_option_id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", s.QuestionOptionID) });
            }
        }
    }
}
