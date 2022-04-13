using Logic.View;

namespace Logic.Interfaces;

public interface IDbUserView
{
    List<UserView> GetAllUsersForView();
}