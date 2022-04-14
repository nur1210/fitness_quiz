using Logic.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;

namespace Logic.Managers
{
    public class UserViewManager
    {
        private readonly IDbUserView _repository;
        public UserViewManager(IDbUserView repository)
        {
            _repository = repository;
        }
        public List<UserView> GetAllUsersForView() => _repository.GetAllUsersForView();
    }
}
