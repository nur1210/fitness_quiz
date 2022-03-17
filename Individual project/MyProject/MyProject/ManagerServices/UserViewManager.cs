using MyProject.DB;
using MyProject.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.ManagerServices
{
    public class UserViewManager
    {
        public List<UserView> GetAllUsersForView() => DbUserView.GetAllUsersForView(); 
    }
}
