using Logic.Managers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace WebApp.Pages
{
    [Authorize(Roles = "user")]
    public class QuestionModel : PageModel
    {
        [BindProperty(SupportsGet = true)] public int Index { get; set; }
        [BindProperty] public int AnswerID { get; set; }
        public QuestionManager QuestionManager { get; }
        public AnswerManager AnswerManager { get; }
        public AnswerStatisticManager AnswerStatisticManager { get; }
        public UserManager UserManager { get; }

        public QuestionModel(QuestionManager qM, AnswerManager aM, AnswerStatisticManager aSM, UserManager uM)
        {
            QuestionManager = qM;
            AnswerManager = aM;
            AnswerStatisticManager = aSM;
            UserManager = uM;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var id = int.Parse(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                var answerID = AnswerID;
                //UserManager.AddUserAnswer(id, answerID);
                if (Index == QuestionManager.GetAllQuestions().Count-1)
                {
                    UserManager.AssignProgram(id, UserManager.RecommendedPrograms(id).First());
                    return RedirectToPage("/Programs");
                }

            }
            return RedirectToPage("/Question", new { Index = Index + 1});
        }
    }
}
