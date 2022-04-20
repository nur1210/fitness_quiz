using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class AddScore : MaterialForm
    {
        private readonly int _programId;
        private readonly AnswerManager _answerManager;
        private readonly ScoreManager _scoreManager;
        private readonly ViewPrograms _viewPrograms;
        public AddScore(int programID, ViewPrograms vP, QuestionManager questionManager, AnswerManager answerManager, ScoreManager scoreManager)
        {
            InitializeComponent();
            _programId = programID;
            _viewPrograms = vP;
            _answerManager = answerManager;
            _scoreManager = scoreManager;
            var questions = questionManager.GetAllQuestions();
            cbxQuestion.DisplayMember = "Description";
            cbxQuestion.ValueMember = "ID";
            cbxQuestion.DataSource = questions;
        }

        private void cbxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = (Question)cbxQuestion.SelectedItem;
            var dataSource = new List<Answer>();
            foreach (var answer in _answerManager.GetAllAnswersForQuestion(q))
            {
                if (!_scoreManager.HasScore(answer.ID, _programId))
                {
                    dataSource.Add(answer);
                }
            }
            cbxAnswer.DataSource = dataSource;
            cbxAnswer.DisplayMember = "Description";
            cbxAnswer.ValueMember = "ID";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbxAnswer.SelectedIndex != -1)
            {
                var answerID = Convert.ToInt32(cbxAnswer.SelectedValue);
                int score = Convert.ToInt32(nudScore.Value);
                int questionID = Convert.ToInt32(cbxQuestion.SelectedValue);
                Score s = new(questionID, answerID, _programId, score);
                _scoreManager.AddScore(s);
                Close();
            }
        }
    }
}
