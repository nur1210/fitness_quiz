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
    public class DbUsers
    {
        public static void AddUser(User user)
        {
            var conn = Connection.OpenConn();
            string sql = "INSERT INTO users (first_name, last_name, email, password, is_admin, is_blocked) VALUES (@FirstName, @LastName, @Email, @Password, @IsAdmin, @IsBlocked)";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] {new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName),
                new MySqlParameter("Email", user.Email), new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("IsBlocked", user.IsBlocked)});
            conn.Close();
        }

        public static void UpdateUser(User user)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE users SET first_name = @FirstName, last_name = @LastName, email = @Email, password = @Password, is_admin = @IsAdmin, is_blocked = @IsBlocked WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName), new MySqlParameter("Email", user.Email),
                new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("IsBlocked", user.IsBlocked), new MySqlParameter("ID", user.ID) });
            conn.Close();
        }

        public static void DeleteUser(User user)
        {
            var conn = Connection.OpenConn();
            string sql = "DELETE FROM users WHERE id = @ID";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", user.ID) });
            conn.Close();
        }

        public static List<User> GetAllUsers()
        {
            var conn = Connection.OpenConn();
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
            conn.Close();
            return users;
        }

        public static User GetUserByID(int userID)
        {
            var conn = Connection.OpenConn();
            string sql = "SELECT * FROM users WHERE id = @ID";
            var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", userID) });

            while (rdr.Read())
            {
                if (rdr is not null)
                {
                    return new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetBoolean(5), rdr.GetBoolean(6));
                }
            }
            rdr.Close();
            conn.Close();
            return null;
        }

        public static void BlockUser(int userID)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE users SET is_blocked = @IsBlocked WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("IsBlocked", true), new MySqlParameter("ID", userID) });
            conn.Close();
        }

        public static void UnblockUser(int userID)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE users SET is_blocked = @IsBlocked WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("IsBlocked", false), new MySqlParameter("ID", userID) });
            conn.Close();
        }
        public static void MakeAdmin(int userID)
        {
            var conn = Connection.OpenConn();
            string sql = "UPDATE users SET is_admin = @IsAdmin WHERE id = @ID ";
            MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("IsAdmin", true), new MySqlParameter("ID", userID) });
            conn.Close();
        }
    }
}
