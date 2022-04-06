using ClassLibrary.DB;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ASP.NET.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Credential credential { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                using (var conn = Connection.OpenConn())
                {
                    string sql = "SELECT id, password, is_admin, is_blocked FROM users WHERE email = @Email";
                    var resault = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] {
                    new MySqlParameter("Email", credential.Email)
                });
                    resault.Read();
                    if (resault is not null)
                    {
                        var match = Hashing.ValidatePassword(credential.Password, resault.GetString(1));
                        if (match && !resault.GetBoolean(3))
                        {
                            int id = resault.GetInt32(0);
                            credential.IsAdmin = resault.GetBoolean(2);
                            List<Claim> claims = new List<Claim>();
                            claims.Add(new Claim(ClaimTypes.Name, credential.Email));
                            claims.Add(new Claim(ClaimTypes.NameIdentifier, id.ToString()));
                            claims.Add(new Claim(ClaimTypes.Role, credential.IsAdmin ? "admin" : "user"));
                            var claimsidentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            HttpContext.SignInAsync(new ClaimsPrincipal(claimsidentity));
                            if (credential.IsAdmin)
                            {
                                return RedirectToPage("/UsersView");
                            }
                            return RedirectToPage("/Question");
                        }
                    }
                }
            }
            return Page();
        }

        public class Credential
        {
            [Required]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            public bool IsAdmin { get; set; }
        }
    }
}