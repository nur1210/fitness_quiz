using Logic.IDb;
using Logic.Managers;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbLogin : IDbLogin
    {
        public int Login(string email, string password)
        {
            using (var conn = Connection.OpenConn())
            {
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
                return -1;
            }
        }
    }
}
