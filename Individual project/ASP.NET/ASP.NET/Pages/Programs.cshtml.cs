using System.Security.Claims;
using Logic.Managers;
using Logic.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    [Authorize]
    public class ProgramsModel : PageModel
    {
        [BindProperty] public List<int> ProgramIDs { get; set; }

        public ProgramManager ProgramManager { get; set; }
        public ExerciseManager ExerciseManager { get; set; }
        public UserManager UserManager { get; set; }
        public ProgramsModel(ProgramManager pM, ExerciseManager eM, UserManager uM)
        {
            ProgramManager = pM;
            ExerciseManager = eM;
            UserManager = uM;
        }
        public void OnGet()
        {
            var userID = int.Parse(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            ProgramIDs = UserManager.RecommendedPrograms(userID);
        }
    }
}
