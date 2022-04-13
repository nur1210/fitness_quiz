using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    [Authorize(Roles = "admin")]
    public class UsersViewModel : PageModel
    {
        [BindProperty]
        public UserViewManager UserViewManager { get; set; }
        [BindProperty]
        public UserManager UserManager { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool IsBlocked { get; set; }
        [BindProperty(SupportsGet = true)]
        public bool IsAdmin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SelectedRow { get; set; }

        public UsersViewModel(UserManager uM, UserViewManager uVM)
        {
            UserViewManager = uVM;
            UserManager = uM;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var id = SelectedRow;
            if (!UserManager.GetUserById(id).IsBlocked)
            {
                UserManager.BlockUser(id);
                return;
            }
            UserManager.UnblockUser(id);
        }
        public void OnPostAdmin()
        {
            var id = SelectedRow;
            UserManager.MakeAdmin(id);
        }
    }
}
