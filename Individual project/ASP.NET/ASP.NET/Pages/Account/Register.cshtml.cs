
using Logic.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using AspNetCoreHero.ToastNotification.Abstractions;
using Logic.Models;
using MySql.Data.MySqlClient;

namespace WebApp.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager _userManager;
        private readonly Validation _validation;
        private readonly INotyfService _toastNotification;

        [BindProperty] public Registration RegisterForm { get; set; }

        public RegisterModel(UserManager userManager, Validation validation, INotyfService toastNotification)
        {
            _userManager = userManager;
            _validation = validation;
            _toastNotification = toastNotification;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || _validation.ValidEmail(RegisterForm.Email)) return Page();
            var user = new User(RegisterForm.FirstName, RegisterForm.LastName, RegisterForm.Email, RegisterForm.Password);
            try
            {
                _userManager.AddUser(user);
            }
            catch (MySqlException)
            {
                _toastNotification.Warning("This email address is already registered");
                return Page();
            }
            _toastNotification.Success("Registered successfully", 3);
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
