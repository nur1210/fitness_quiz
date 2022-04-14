using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class AddQuestion : MaterialForm
    {
        private readonly QuestionManager _questionManager;
        private readonly AnswerManager _answerManager;
        private readonly ViewQuestions _viewQuestions;
        public AddQuestion(QuestionManager questionManager, AnswerManager answerManager, ViewQuestions viewQuestions)
        {
            InitializeComponent();
            _questionManager = questionManager;
            _answerManager = answerManager;
            _viewQuestions = viewQuestions;
            this.Text = $"Add question number: {_questionManager.GetAllQuestions().Count+ 1}";
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string questionDescription = tbxQuestion.Text;
            string answer1 = tbxAnswer1.Text;
            string answer2 = tbxAnswer2.Text;
            string answer3 = tbxAnswer3.Text;
            string answer4 = tbxAnswer4.Text;

            Question question = new Question(questionDescription);
            _questionManager.AddQuestion(question);

            var questionID = _questionManager.GetInsertedQuestionID();
            Answer a1 = new Answer(questionID, answer1);
            Answer a2 = new Answer(questionID, answer2);
            Answer a3 = new Answer(questionID, answer3);
            Answer a4 = new Answer(questionID, answer4);

            _answerManager.AddAnswer(a1);
            _answerManager.AddAnswer(a2);
            _answerManager.AddAnswer(a3);
            _answerManager.AddAnswer(a4);

            _viewQuestions.UpdateDataGridView();
            Close();
        }
    }
}
