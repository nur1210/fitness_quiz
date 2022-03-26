using ClassLibrary.DB;
using ClassLibrary.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Logic
{
    public class UserViewManager
    {
        public List<UserView> GetAllUsersForView() => DbUserView.GetAllUsersForView();
    }
}
