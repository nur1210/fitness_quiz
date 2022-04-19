using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbUsers : IDbUsers
    {
        public void AddUser(User user)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO users (first_name, last_name, email, password, is_admin, is_blocked) VALUES (@FirstName, @LastName, @Email, @Password, @IsAdmin, @IsBlocked)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName), new MySqlParameter("Email", user.Email), new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("IsBlocked", user.IsBlocked));
            }
        }

        public void UpdateUser(User user)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET first_name = @FirstName, last_name = @LastName, email = @Email, password = @Password, is_admin = @IsAdmin, is_blocked = @IsBlocked WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName), new MySqlParameter("Email", user.Email), new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("IsBlocked", user.IsBlocked), new MySqlParameter("ID", user.ID));
            }
        }

        public void DeleteUser(User user)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM users WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("ID", user.ID));
            }
        }

        public List<User> GetAllUsers()
        {
            using (var conn = Connection.OpenConn())
            {
                List<User> users = new List<User>();
                string sql = "SELECT * FROM users;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);
                while (rdr.Read())
                {
                    User user = new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetBoolean(5), rdr.GetBoolean(6));
                    if (user is not null)
                    {
                        users.Add(user);
                    }
                }
                rdr.Close();
                return users;
            }
        }

        public User GetUserById(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT * FROM users WHERE id = @ID";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter("ID", userID));

                while (rdr.Read())
                {
                    return new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetBoolean(5), rdr.GetBoolean(6));
                }
                rdr.Close();
                return null;
            }
        }

        public void BlockUser(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET is_blocked = @IsBlocked WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("IsBlocked", true), new MySqlParameter("ID", userID));
            }
        }

        public void UnblockUser(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET is_blocked = @IsBlocked WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("IsBlocked", false), new MySqlParameter("ID", userID));
            }
        }

        public void MakeAdmin(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET is_admin = @IsAdmin WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("IsAdmin", true), new MySqlParameter("ID", userID));
            }
        }

        public void AddUserAnswer(int userID, int answerID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO user_answers (user_id, question_option_id) VALUES (@UserID, @AnswerID)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("UserID", userID), new MySqlParameter("AnswerID", answerID));
            }
        }

        public void UpdateUserAnswer(int userID, int questionID, int answerID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "update user_answers set question_option_id = @AnswerID where question_option_id = " +
                             "(select ua.question_option_id from user_answers as ua inner join question_options as qo " +
                             "on ua.question_option_id = qo.id inner join questions as q on qo.question_id = q.id " +
                             "where qo.question_id = q.id and ua.question_option_id = @QuestionID and ua.user_id = UserID); ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("UserID", userID), new MySqlParameter("QuestionID", questionID), 
                    new MySqlParameter("AnswerID", answerID));
            }
        }

        public void RemoveAllUserAnswers(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM user_answers WHERE user_id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter("ID", userID));
            }
        }
        public List<int> RecommendedPrograms(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "SELECT qos.program_id, SUM(qos.weight) score FROM question_option_score qos " +
                             "INNER JOIN question_options qo ON qo.id = qos.question_option_id INNER JOIN user_answers ua " +
                             "ON ua.question_option_id = qo.id WHERE ua.user_id = @UserID GROUP BY qos.program_id " +
                             "ORDER BY SUM(qos.weight) DESC;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter("UserID", userID));
                List<(int, int)> valuesList = new();
                while (rdr.Read())
                {
                    var programId = rdr.GetInt32(0);
                    var score = rdr.GetInt32(1);
                    valuesList.Add((programId, score));
                }

                List<int> programIds = new();
                int highestScore = 0;
                foreach (var item in valuesList)
                {
                    if (item.Item2 >= highestScore)
                    {
                        programIds.Add(item.Item1);
                        highestScore = item.Item2;
                    }
                    else break;
                }

                return programIds;
            }
        }

        public void AssignProgram(int userID, int programID)
        {
            using (var con = Connection.OpenConn())
            {
                string sql = "INSERT INTO user_program (user_id, program_id) VALUES (@ID, @ProgramID)";
                MySqlHelper.ExecuteNonQuery(con, sql, new MySqlParameter("ID", userID),
                    new MySqlParameter("ProgramID", programID));
            }
        }

        public void RemoveProgram(int userID)
        {
            using (var con = Connection.OpenConn())
            {
                string sql = "DELETE FROM user_program WHERE user_id = @ID;";
                MySqlHelper.ExecuteNonQuery(con, sql, new MySqlParameter("ID", userID));
            }
        }

        public bool HasProgram(int userID)
        {
            using (var con = Connection.OpenConn())
            {
                string sql = "SELECT * FROM user_program WHERE user_id = @ID;";
                var rdr = MySqlHelper.ExecuteReader(con, sql, new MySqlParameter("ID", userID));
                if (rdr.HasRows)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUserByEmail(string email)
        {
            using (var con = Connection.OpenConn())
            {
                string sql = "SELECT * FROM users WHERE email = @Email";
                var rdr = MySqlHelper.ExecuteReader(con, sql, new MySqlParameter("Email", email));
                while (rdr.Read())
                {
                    return new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3),
                        rdr.GetString(4), rdr.GetBoolean(5), rdr.GetBoolean(6));
                }
                rdr.Close();
                return null;
            }
        }
    }
}
