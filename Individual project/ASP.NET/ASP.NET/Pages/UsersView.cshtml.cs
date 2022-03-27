using ClassLibrary.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET.Pages
{
    public class UsersViewModel : PageModel
    {
        [BindProperty]
		public UserViewModel UserView { get; set; }
		public void OnGet()
        {
            UserView = new UserViewModel();
            UserView.UserManager = new UserViewManager();
        }

		public void OnPost() 
        {
        }
    }

    public class UserViewModel
	{
		public UserViewManager UserManager { get; set; }
	}
}
