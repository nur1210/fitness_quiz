using System.ComponentModel.DataAnnotations;

namespace ASP.NET.wwwroot.Registration
{
    public class Registration
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
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
