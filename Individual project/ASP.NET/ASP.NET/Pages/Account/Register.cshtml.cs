using ClassLibrary.DB;
using ClassLibrary.Logic;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Registration RegisterForm { get; set; }
        public void OnGet()
        {
            if (ModelState.IsValid)
            {

            }

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new User(RegisterForm.FirstName, RegisterForm.LastName, RegisterForm.Email, RegisterForm.Password);
                UserManager manager = new UserManager();
                manager.AddUser(user);
                return RedirectToPage("/Index");
            }
            return Page();
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
            //[Remote]
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
