using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Logic.Managers;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty] public Credential credential { get; set; }

        public UserManager UserManager { get; set; }
        public Validation Validation { get; set; }
        public IndexModel(UserManager uM, Validation v)
        {
            UserManager = uM;
            Validation = v;
        }

        public IActionResult OnGet()
        {
            if (HttpContext.User.Identity is not {IsAuthenticated: true}) return Page();
            return HttpContext.User.FindFirstValue(ClaimTypes.Role) switch
            {
                "user" => RedirectToPage(
                    UserManager.HasProgram(Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)))
                        ? "/Programs"
                        : "/Question"),
                "admin" => RedirectToPage("/UsersView"),
                _ => Page()
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            if (!Validation.ValidUser(credential.Email, credential.Password)) return Page();
            var user = UserManager.GetUserByEmail(credential.Email);
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, credential.Email),
                new(ClaimTypes.NameIdentifier, user.ID.ToString()),
                new(ClaimTypes.Role, user.IsAdmin ? "admin" : "user")
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
            if (user.IsAdmin)
            {
                return RedirectToPage("/UsersView");
            }

            return RedirectToPage(UserManager.HasProgram(user.ID) ? "/Programs" : "/Question");
        }


    public class Credential
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
}