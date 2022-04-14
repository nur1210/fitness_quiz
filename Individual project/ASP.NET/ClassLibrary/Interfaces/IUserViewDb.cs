using Logic.View;

namespace Logic.Interfaces;

public interface IUserViewDb
{
    public List<UserView> GetAllUsersForView();
}