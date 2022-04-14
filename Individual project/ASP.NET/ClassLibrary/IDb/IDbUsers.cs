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
}