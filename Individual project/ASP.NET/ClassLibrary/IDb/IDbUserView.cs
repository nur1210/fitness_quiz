using Logic.View;

namespace Logic.IDb;

public interface IDbUserView
{
    List<UserView> GetAllUsersForView();
}