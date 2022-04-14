using Logic.Managers;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class EditScore : MaterialForm
    {
        private readonly int _programID;
        private readonly AnswerManager _answerManager;
        private readonly ProgramManager _programManager;
        private readonly ViewPrograms _viewPrograms;
        private readonly ScoreManager _scoreManager;

        public EditScore(int programID, ViewPrograms vP, ScoreManager sM, AnswerManager answerManager, ProgramManager programManager)
        {
            InitializeComponent();
            _programID = programID;
            _viewPrograms = vP;
            _scoreManager = sM;
            _answerManager = answerManager;
            _programManager = programManager;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void EditScore_Load(object sender, EventArgs e)
        {
            var scores = _scoreManager.GetScoresForProgramByProgramID(_programID);
            var answers = scores.Select(x => _answerManager.GetAnswerByID(x.QuestionOptionID)).ToList();
            cbxQuestion.DataSource = answers;
            cbxQuestion.DisplayMember = "Description"; ;
        }
    }
}
