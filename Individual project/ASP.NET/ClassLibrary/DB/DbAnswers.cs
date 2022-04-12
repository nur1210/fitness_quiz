using ClassLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DB
{
    public class DbAnswers
    {
        public static void AddAnswer(Answer answer)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO question_options(`question_id`, `description`) VALUES (@QuestionID, @Description)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("QuestionID", answer.QuestionId), new MySqlParameter("Description", answer.Description) });
            }
        }

        public static void UpdateAnswer(Answer answer)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE question_options SET description = @Description WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("Description", answer.Description), new MySqlParameter("ID", answer.ID) });
            }
        }

        public static void DeleteAnswer(Answer answer)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM question_options WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", answer.ID) });
            }
        }

        public static List<Answer> GetAllAnswers()
        {
            using (var conn = Connection.OpenConn())
            {
                List<Answer> list = new List<Answer>();

                string sql = "SELECT * FROM question_options ORDER BY id;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        list.Add(new Answer(rdr.GetInt32("id"), rdr.GetInt32("question_id"),
                            rdr.GetString("description"), rdr.GetInt32("program_id")));
                    }
                }
                rdr.Close();
                return list;
            }
        }

        public static List<Answer> GetAllAnswersForQuestion(Question question)
        {
            using (var conn = Connection.OpenConn())
            {
                List<Answer> answers = new List<Answer>();

                string sql = "SELECT id, question_id, description FROM question_options WHERE question_id = @ID;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", question.ID) });

                while (rdr.Read())
                {
                    var line = rdr;
                    if (line is not null)
                    {
                        //var programID = line?.GetFieldValue<System.DBNull>(3);
                        //if (programID is not System.DBNull)
                        //{
                        //    answers.Add(new Answer(rdr.GetInt32("id"), rdr.GetInt32("question_id"),
                        //        rdr.GetString("description"), Convert.ToInt32(programID)));
                        //}
                        //else
                        //{
                            answers.Add(new Answer(line.GetInt32(0), line.GetInt32(1),
                                line.GetString(2)));
                        //}
                    }
                }
                rdr.Close();
                return answers;
            }
        }

        public static void AddProgramReference(int answerID, int programID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE question_options SET program_id = @ProgramID WHERE id = @ID;";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ProgramID", programID),
                    new MySqlParameter("ID", answerID) });
            }
        }

        public static void RemoveProgramReference(int answerID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE question_options SET program_id = @ProgramID WHERE id = @ID;";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ProgramID", null),
                    new MySqlParameter("ID", answerID) });
            }
        }

        public static bool HasReference(int answerID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT program_id FROM question_options WHERE id = @ID;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", answerID)});
                while (rdr.Read())
                {
                    if (rdr.GetValue(0) is int)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static int GetReferencedProgramID(int answerID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT program_id FROM question_options WHERE id = @ID;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", answerID) });
                int id = -1;
                while (rdr.Read())
                {
                    id = rdr.GetInt32(0);
                }
                return id;
            }
        }
    }
}
