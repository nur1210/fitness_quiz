namespace Logic.IDb;

public interface IDbLogin
{
    int Login(string email, string password);
}