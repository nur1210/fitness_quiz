using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class AddQuestion : MaterialForm
    {
        private readonly QuestionManager _questionManager;
        private readonly AnswerManager _answerManager;
        public AddQuestion(QuestionManager questionManager, AnswerManager answerManager)
        {
            InitializeComponent();
            _questionManager = questionManager;
            _answerManager = answerManager;
            this.Text = $"Add question number: {_questionManager.GetAllQuestions().Count+ 1}";
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var questionDescription = tbxQuestion.Text;
            var answer1 = tbxAnswer1.Text;
            var answer2 = tbxAnswer2.Text;
            var answer3 = tbxAnswer3.Text;
            var answer4 = tbxAnswer4.Text;

            var question = new Question(questionDescription);
            _questionManager.AddQuestion(question);

            var questionID = _questionManager.GetInsertedQuestionID();
            var a1 = new Answer(questionID, answer1);
            var a2 = new Answer(questionID, answer2);
            var a3 = new Answer(questionID, answer3);
            var a4 = new Answer(questionID, answer4);

            _answerManager.AddAnswer(a1);
            _answerManager.AddAnswer(a2);
            _answerManager.AddAnswer(a3);
            _answerManager.AddAnswer(a4);

            Close();
        }
    }
}
