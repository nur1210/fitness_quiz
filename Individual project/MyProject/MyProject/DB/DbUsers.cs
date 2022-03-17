using MyProject.DB;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class DbUsers
    {
        public static void AddUser(User user)
        {
            string sql = "INSERT INTO users (first_name, last_name, email, password, is_admin) VALUES (@FirstName, @LastName, @Email, @Password, @IsAdmin)";
            MySqlHelper.ExecuteNonQuery(Connection.OpenConn(), sql, new MySqlParameter[] {new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName), new MySqlParameter("Email", user.Email), new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin)});
            Connection.OpenConn().Close();
        }

        public static void UpdateUser(User user)
        {
            string sql = "UPDATE users SET first_name = @FirstName, last_name = @LastName, email = @Email, password = @Password, is_admin = @IsAdmin WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(Connection.OpenConn(), sql, new MySqlParameter[] { new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName), new MySqlParameter("Email", user.Email), new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("ID", user.ID) });
            Connection.OpenConn().Close();
        }

        public static void DeleteUser(User user)
        {
            string sql = "DELETE FROM users WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(Connection.OpenConn(), sql, new MySqlParameter[] { new MySqlParameter("ID", user.ID) });
            Connection.OpenConn().Close();
        }

        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            string sql = "SELECT * FROM users;";
            var rdr = MySqlHelper.ExecuteReader(Connection.OpenConn(), sql);
            while (rdr.Read())
            {
                User user = new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetBoolean(5));
                if (user is not null)
                {
                    users.Add(user);
                }
            }
            rdr.Close();
            Connection.OpenConn().Close();
            return users;
        }
    }
}
