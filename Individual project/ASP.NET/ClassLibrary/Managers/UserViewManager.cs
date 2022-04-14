using Logic.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;
using Logic.Interfaces;

namespace Logic.Managers
{
    public class UserViewManager : IUserViewDb
    {
        private readonly IDbUserView _repository;

        public UserViewManager()
        {
        }
        public UserViewManager(IDbUserView repository)
        {
            _repository = repository;
        }
        public List<UserView> GetAllUsersForView() => _repository.GetAllUsersForView();
    }
}
