using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class UserManager
    {
        private readonly IDbUsers _repository;
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
        public void AddUserAnswer(int userID, int answerID) => _repository.AddUserAnswer(userID, answerID);
        public void UpdateUserAnswer(int userID, int questionID, int answerID) => _repository.UpdateUserAnswer(userID, questionID, answerID);
        public List<int> RecommendedPrograms(int userID) => _repository.RecommendedPrograms(userID);
        public bool HasProgram(int userID) => _repository.HasProgram(userID);
        public void AssignProgram(int userID, int programID) => _repository.AssignProgram(userID, programID);

        public void RemoveUserProgramAndAnswers(int userID)
        {
            _repository.RemoveProgram(userID);
            _repository.RemoveAllUserAnswers(userID);
        }
        public User GetUserByEmail(string email) => _repository.GetUserByEmail(email);
    }
}
