using ClassLibrary.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

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
                var conn = Connection.OpenConn();
                string sql = "SELECT id, password, is_blocked FROM users WHERE email = @Email";
                var resault = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] 
                {new MySqlParameter("Email", credential.Email)});
                resault.Read();
                if (resault is not null)
                {
                    var match = Hashing.ValidatePassword(credential.Password, resault.GetString(1));
                    if (match && !resault.GetBoolean(2))
                    {
                        int id = resault.GetInt32(0);
                        return RedirectToPage("/Question");
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
        }
    }
}