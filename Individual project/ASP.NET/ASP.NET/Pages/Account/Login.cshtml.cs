using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {

            }
        }

    }
}
