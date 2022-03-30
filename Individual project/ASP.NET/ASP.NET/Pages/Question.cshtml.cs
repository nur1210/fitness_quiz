using ClassLibrary.Logic;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET.Pages
{
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
        }

        public void OnPost()
        {
            index = seeder++;
            var id = AnswerID;
        }
    }

    public class QuestionViewModel
    {
        public QuestionManager QuestionManager { get; set; } = new QuestionManager();
        public AnswerManager answerManager { get; set; } = new AnswerManager();
        public Question? Q { get; set; }


        public QuestionViewModel()
        {

        }

    }
}
