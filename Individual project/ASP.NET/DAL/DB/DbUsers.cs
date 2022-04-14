﻿using Logic.IDb;
using Logic.Interfaces;
using Logic.Managers;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbUsers : IUserDb, IDbUsers
    {
        public void AddUser(User user)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "INSERT INTO users (first_name, last_name, email, password, is_admin, is_blocked) VALUES (@FirstName, @LastName, @Email, @Password, @IsAdmin, @IsBlocked)";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] {new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName),
                new MySqlParameter("Email", user.Email), new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("IsBlocked", user.IsBlocked)});
            }
        }

        public void UpdateUser(User user)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET first_name = @FirstName, last_name = @LastName, email = @Email, password = @Password, is_admin = @IsAdmin, is_blocked = @IsBlocked WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("FirstName", user.FirstName), new MySqlParameter("LastName", user.LastName), new MySqlParameter("Email", user.Email),
                new MySqlParameter("Password", Hashing.HashPassword(user.Password)), new MySqlParameter("IsAdmin", user.IsAdmin), new MySqlParameter("IsBlocked", user.IsBlocked), new MySqlParameter("ID", user.ID) });
            }
        }

        public void DeleteUser(User user)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "DELETE FROM users WHERE id = @ID";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", user.ID) });
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
                var rdr = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("ID", userID) });

                while (rdr.Read())
                {
                    if (rdr is not null)
                    {
                        return new User(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetBoolean(5), rdr.GetBoolean(6));
                    }
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
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("IsBlocked", true), new MySqlParameter("ID", userID) });
            }
        }

        public void UnblockUser(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET is_blocked = @IsBlocked WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("IsBlocked", false), new MySqlParameter("ID", userID) });
            }
        }

        public void MakeAdmin(int userID)
        {
            using (var conn = Connection.OpenConn())
            {
                string sql = "UPDATE users SET is_admin = @IsAdmin WHERE id = @ID ";
                MySqlHelper.ExecuteNonQuery(conn, sql, new MySqlParameter[] { new MySqlParameter("IsAdmin", true), new MySqlParameter("ID", userID) });
            }
        }
    }
}