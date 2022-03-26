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

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                var conn = Connection.OpenConn();
                string sql = "SELECT id, password FROM users WHERE email = @Email";
                var resault = MySqlHelper.ExecuteReader(conn, sql, new MySqlParameter[] {new MySqlParameter("Email", credential.Email)});
                resault.Read();
                if (resault is not null)
                {
                    var match = Hashing.ValidatePassword(credential.Password, resault.GetString(1));
                    if (match)
                    {
                        int id = resault.GetInt32(0);
                    }
                }
            //duhsu
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