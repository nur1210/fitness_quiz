using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class UserManager : IUserDb
    {
        private readonly IDbUsers _repository;

        public UserManager()
        {
        }
        public UserManager(IDbUsers repository)
        {
            _repository = repository;
        }
        public void AddUser(User u) => _repository.AddUser(u);
        public void UpdateUser(User u) => _repository.UpdateUser(u);
        public void DeleteUser(User u) => _repository.DeleteUser(u);
        public List<User> GetAllUsers() => _repository.GetAllUsers();
        public User GetUserById(int id) => _repository.GetUserById(id);
        public void BlockUser(int id) => _repository.BlockUser(id);
        public void UnblockUser(int id) => _repository.UnblockUser(id);
        public void MakeAdmin(int id) => _repository.MakeAdmin(id);
    }
}
