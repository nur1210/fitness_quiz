using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DB
{
    public class DbLogin
    {
        public int Login(string email, string password)
        {
            var conn = Connection.OpenConn();
            string sql = "SELECT id, password, is_admin FROM users WHERE email = @Email";
            try
            {
                var userInfo = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] { new MySqlParameter("Email", email) });
                userInfo.Read();
                if (!userInfo.GetBoolean(2))
                {
                    //MessageBox.Show("This application is for admin use only");
                }
                else
                {
                    int id = userInfo.GetInt32(0);
                    if (Hashing.ValidatePassword(password, userInfo.GetString(1)))
                    {
                        return id;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            conn.Close();
            return -1;
        }
    }
}
