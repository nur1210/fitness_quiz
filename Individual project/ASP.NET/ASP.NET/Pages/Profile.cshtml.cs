using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using AspNetCoreHero.ToastNotification.Abstractions;
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
        public Validation Validation { get; set; }
        public User User { get; set; }
        [BindProperty] public string FirstName { get; set; }
        [BindProperty] public string LastName { get; set; }

        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [Display(Name = "Current password")]
        [DataType(DataType.Password)]
        public string? CurrentPassword { get; set; }

        [BindProperty]
        [Display(Name = "New password")]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }

        [BindProperty]
        [Display(Name = "Repeat password")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]
        public string? RepeatPassword { get; set; }

        private readonly INotyfService _toastNotification;


        public ProfileModel(UserManager userManager, Validation validation, INotyfService toastNotification)
        {
            UserManager = userManager;
            Validation = validation;
            _toastNotification = toastNotification;
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
            if (NewPassword == RepeatPassword && !string.IsNullOrEmpty(NewPassword) && Hashing.ValidatePassword(CurrentPassword, User.Password))
            {
                User.FirstName = FirstName;
                User.LastName = LastName;
                if (Validation.ValidEmail(Email))
                {
                    User.Email = Email;
                }
                User.Password = Hashing.HashPassword(NewPassword);
                UserManager.UpdateUser(User);
                _toastNotification.Success("Updated successfully");
                return RedirectToPage(UserManager.HasProgram(User.ID) ? "/Programs" : "/Question");
            }

            User.FirstName = FirstName;
            User.LastName = LastName;
            if (Validation.ValidEmail(Email))
            {
                User.Email = Email;
            }
            UserManager.UpdateUser(User);
            _toastNotification.Success("Updated successfully");
            return RedirectToPage(UserManager.HasProgram(User.ID) ? "/Programs" : "/Question");
        }
    }
}
