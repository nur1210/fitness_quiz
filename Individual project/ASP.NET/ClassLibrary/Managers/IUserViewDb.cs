using Logic.View;

namespace Logic.Managers;

public interface IUserViewDb
{
    public List<UserView> GetAllUsersForView();
}