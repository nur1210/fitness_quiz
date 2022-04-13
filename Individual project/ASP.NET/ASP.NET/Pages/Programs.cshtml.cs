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
        [BindProperty(SupportsGet = true)]
        public int ProgramID { get; set; }

        [BindProperty] public TrainingProgram Program { get; set; }
        [BindProperty] public ProgramManager ProgramManager { get; set; }
        [BindProperty] public ExerciseManager ExerciseManager { get; set; }
        public ProgramsModel(ProgramManager pM, TrainingProgram tP, ExerciseManager eM)
        {
            ProgramManager = pM;
            Program = tP;
            ExerciseManager = eM;
        }
        public void OnGet()
        {
        }
    }
}
