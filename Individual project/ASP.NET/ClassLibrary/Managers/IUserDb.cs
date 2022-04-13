using Logic.Models;

namespace Logic.Managers;

public interface IUserDb
{
    public void AddUser(User u);
    public void UpdateUser(User u);
    public void DeleteUser(User u);
    public List<User> GetAllUsers();
    public User GetUserById(int id);
    public void BlockUser(int id);
    public void UnblockUser(int id);
    public void MakeAdmin(int id);
}