using ClassLibrary.Logic;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace ASP.NET.Pages
{
    [Authorize]
    public class QuestionModel : PageModel
    {        
        private static QuestionViewModel model = new QuestionViewModel();
        [BindProperty]
        public QuestionViewModel question { get=> model; set=> model = value; }
        public int index { get; set; }
		public static int seeder { get; set; } = 1;
        [BindProperty]
        public int AnswerID { get; set; }
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
            var questionID = question.QuestionManager.GetAllQuestions().ElementAt(index).ID;
            //question.Statistics.AddAnswerStatistic(answerID, questionID);
            index = seeder++;
        }
    }

    public class QuestionViewModel
    {
        public QuestionManager QuestionManager { get; set; } = new QuestionManager();
        public AnswerManager answerManager { get; set; } = new AnswerManager();
        public AnswerStatisticManager Statistics { get; set; } = new AnswerStatisticManager();

        public QuestionViewModel()
        {

        }

    }
}
