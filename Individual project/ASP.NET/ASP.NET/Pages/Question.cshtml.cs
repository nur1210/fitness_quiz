using ClassLibrary.Logic;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Pages
{
    public class QuestionModel : PageModel
    {
        [BindProperty]
        public QuestionViewModel question { get; set; }
        public void OnGet()
        {
            question = new QuestionViewModel();
            question.QuestionManager = new QuestionManager();
            question.answerManager = new AnswerManager();
        }

        public void OnPost()
        {

        }
    }

    public class QuestionViewModel
    {
        public QuestionManager QuestionManager { get; set; }
        public AnswerManager answerManager { get; set; }
    }
}
