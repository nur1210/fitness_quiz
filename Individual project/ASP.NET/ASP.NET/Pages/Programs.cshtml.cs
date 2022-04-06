using ClassLibrary.Logic;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET.Pages
{
    [Authorize]
    public class ProgramsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int ProgramID { get; set; }

        [BindProperty] public TrainigProgram Program { get; set; }
        [BindProperty] public ProgramManager ProgramManager { get; set; }
        public ProgramsModel(ProgramManager pM, TrainigProgram tP)
        {
            ProgramManager = pM;
            Program = tP;
        }
        public void OnGet()
        {
        }
    }
}
