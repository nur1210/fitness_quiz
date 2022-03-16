using ASP.NET.wwwroot.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
    }
}
