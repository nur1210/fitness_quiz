using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DB
{
    public class DbLogin
    {
        public int Login(string email, string password)
        {

            string query = "SELECT id, password FROM `users` WHERE email = @Email";
            try
            {
                var userInfo = MySqlHelper.ExecuteReader(Connection.OpenConn(), query, new MySqlParameter[] { new MySqlParameter("Email", email) });
                userInfo.Read();
                int id = (int)userInfo.GetInt64(0);
                if (Hashing.ValidatePassword(password, userInfo.GetString(1)))
                {
                    return id;
                }
                else return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
            Connection.OpenConn().Close();
        }
    }
}
