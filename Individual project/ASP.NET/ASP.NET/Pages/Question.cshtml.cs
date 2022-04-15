using Logic.Managers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace WebApp.Pages
{
    [Authorize]
    public class QuestionModel : PageModel
    {
        [BindProperty] public int index { get; set; }
        public static int seeder { get; set; } = 1;
        [BindProperty] public int AnswerID { get ; set; }
        public QuestionManager QuestionManager { get; set; }
        public AnswerManager AnswerManager { get; set; }
        public AnswerStatisticManager AnswerStatisticManager { get; set; }

        public QuestionModel(QuestionManager qM, AnswerManager aM, AnswerStatisticManager aSM)
        {
            QuestionManager = qM;
            AnswerManager = aM;
            AnswerStatisticManager = aSM;
        }

        public void OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var id = int.Parse(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            }
        }

        public void OnPost()
        {
            var answerID = AnswerID;
            var questionID = QuestionManager.GetAllQuestions().ElementAt(index).ID;
            //AnswerManager.Statistics.AddAnswerStatistic(answerID, questionID);
            index = seeder++;
        }
    }
}
