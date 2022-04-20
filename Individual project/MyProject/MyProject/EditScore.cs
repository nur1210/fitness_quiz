using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class EditScore : MaterialForm
    {
        private readonly int _programID;
        private readonly ScoreManager _scoreManager;

        public EditScore(int programID, ScoreManager sM, AnswerManager answerManager)
        {
            InitializeComponent();
            _programID = programID;
            _scoreManager = sM;

            var scores = _scoreManager.GetScoresForProgramByProgramID(_programID);
            var answers = scores.Select(x => answerManager.GetAnswerByID(x.QuestionOptionID)).ToList();
            cbxAnswer.DisplayMember = "Description";
            cbxAnswer.ValueMember = "ID";
            cbxAnswer.DataSource = answers;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var qID = (int)cbxAnswer.SelectedValue;
            var score = _scoreManager.GetScore(_programID, qID);
            score.Weight = (int)nudScore.Value;
            _scoreManager.UpdateScore(score);
            Close();
        }

        private void cbxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var weight = _scoreManager.GetScoresForProgramByProgramID(_programID)
                    .Where(x => x.QuestionOptionID == (int)cbxAnswer.SelectedValue).Select(x => x.Weight).SingleOrDefault();
            nudScore.Value = weight;
        }
    }
}
