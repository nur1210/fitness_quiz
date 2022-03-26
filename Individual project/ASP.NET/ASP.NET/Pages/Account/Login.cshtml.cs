using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Credential credential { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {

            }
        }

        public class Credential
        {
            [Required]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}
