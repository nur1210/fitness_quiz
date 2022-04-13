using Logic.Interfaces;
using Logic.Managers;
using Logic.View;
using MySql.Data.MySqlClient;

namespace DAL.DB
{
    public class DbUserView : IUserViewDb, IDbUserView
    {
        public List<UserView> GetAllUsersForView()
        {
            using (var conn = Connection.OpenConn())
            {
                List<UserView> users = new List<UserView>();
                string sql = "SELECT id, first_name, last_name, email FROM users;";
                var rdr = MySqlHelper.ExecuteReader(conn, sql);
                while (rdr.Read())
                {
                    UserView user = new UserView(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
                    if (user is not null)
                    {
                        users.Add(user);
                    }
                }
                rdr.Close();
                return users;
            }
        }
    }
}
