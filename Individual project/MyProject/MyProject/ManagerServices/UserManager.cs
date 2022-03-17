using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ManagerServices
{
    public class UserManager
    {
        public void AddUser(User u) => DbUsers.AddUser(u);
        public void UpdateUser(User u) => DbUsers.UpdateUser(u);
        public void DeleteUser(User u) => DbUsers.DeleteUser(u);
        public List<User> GetAllUsers() => DbUsers.GetAllUsers();
    }
}
