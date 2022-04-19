using Logic.Models;

namespace Logic.IDb;

public interface IDbUsers
{
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(User user);
    List<User> GetAllUsers();
    User GetUserById(int userID);
    void BlockUser(int userID);
    void UnblockUser(int userID);
    void MakeAdmin(int userID);
    void AddUserAnswer(int userID, int answerID);
    void UpdateUserAnswer(int userID, int questionID, int answerID);
    void RemoveAllUserAnswers(int userID);
    List<int> RecommendedPrograms(int userID);
    void AssignProgram(int userID, int programID);
    void RemoveProgram(int userID);
    bool HasProgram(int userID);
    User GetUserByEmail(string email);
}