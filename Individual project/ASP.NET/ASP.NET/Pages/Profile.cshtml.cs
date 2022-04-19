using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Logic.Managers;
using Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        public UserManager UserManager { get; set; }
        public User User { get; set; }
        [BindProperty] public string FirstName { get; set; }
        [BindProperty] public string LastName { get; set; }

        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [Display(Name = "New password")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [BindProperty]
        [Display(Name = "Repeat password")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]
        public string RepeatPassword { get; set; }

        public ProfileModel(UserManager userManager)
        {
            UserManager = userManager;
        }

        public void OnGet()
        {
            if (!HttpContext.User.Identity.IsAuthenticated) return;
            var id = int.Parse(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            User = UserManager.GetUserById(id);
            FirstName = User.FirstName;
            LastName = User.LastName;
            Email = User.Email;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || !HttpContext.User.Identity.IsAuthenticated) return Page();
            var id = int.Parse(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            User = UserManager.GetUserById(id);
            if (NewPassword == RepeatPassword && !string.IsNullOrEmpty(NewPassword))
            {
                User.FirstName = FirstName;
                User.LastName = LastName;
                User.Email = Email;
                User.Password = NewPassword; 
                UserManager.UpdateUser(User);
                return RedirectToPage(UserManager.HasProgram(User.ID) ? "/Programs" : "/Question");
            }

            User.FirstName = FirstName;
            User.LastName = LastName;
            User.Email = Email;
            UserManager.UpdateUser(User);
            return RedirectToPage(UserManager.HasProgram(User.ID) ? "/Programs" : "/Question");
        }
    }
}
