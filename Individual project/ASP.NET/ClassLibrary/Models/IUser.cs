namespace Logic.Models;

public interface IUser
{
    int ID { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Email { get; set; }
    string Password { get; set; }
    bool IsAdmin { get; set; }
    bool IsBlocked { get; set; }
}