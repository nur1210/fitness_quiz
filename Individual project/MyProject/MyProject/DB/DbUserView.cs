using MyProject.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.DB
{
    public static class DbUserView
    {
        public static List<UserView> GetAllUsersForView()
        {
            List<UserView> users = new List<UserView>();
            string sql = "SELECT id, first_name, last_name, email FROM users;";
            var rdr = MySqlHelper.ExecuteReader(Connection.OpenConn(), sql);
            while (rdr.Read())
            {
                UserView user = new UserView(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3));
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
