using ClassLibrary.DB;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class UserManager
    {
        public void AddUser(User u) => DbUsers.AddUser(u);
        public void UpdateUser(User u) => DbUsers.UpdateUser(u);
        public void DeleteUser(User u) => DbUsers.DeleteUser(u);
        public List<User> GetAllUsers() => DbUsers.GetAllUsers();
        public User GetUserById(int id) => DbUsers.GetUserByID(id);
        public void BlockUser(int id) => DbUsers.BlockUser(id);
        public void MakeAdmin(int id) => DbUsers.MakeAdmin(id);
    }
}
