
using Logic.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Logic.Models;

namespace WebApp.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager _userManager;

        [BindProperty] public Registration RegisterForm { get; set; }

        public RegisterModel(UserManager userManager)
        {
            _userManager = userManager;
        }
        public void OnGet()
        {
            if (ModelState.IsValid)
            {
            }

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            var user = new User(RegisterForm.FirstName, RegisterForm.LastName, RegisterForm.Email, RegisterForm.Password);
            _userManager.AddUser(user);
            return RedirectToPage("/Index");
        }

        public class Registration
        {
            [Required]
            [Display(Name = "First name")]
            public string FirstName { get; set; }
            [Required]
            [Display(Name = "Last name")]
            public string LastName { get; set; }
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [Compare(nameof(Password), ErrorMessage = "Please make sure both passwords are identical")]
            public string RepeatPassword { get; set; }

            public Registration()
            {
            }

            public Registration(string firstName, string lastName, string email, string password, string repeatPassword)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                Password = password;
                RepeatPassword = repeatPassword;
            }
        }
    }
}
