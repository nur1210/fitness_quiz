using MaterialSkin;
using MaterialSkin.Controls;
using Logic.Managers;

namespace MyProject
{
    public partial class MainForm : MaterialForm
    {
        private QuestionManager _questionManager;
        private AnswerManager _answerManager;
        private ProgramManager _programManager;
        private ExerciseManager _exerciseManager;
        private UserManager _userManager;
        private UserViewManager _userViewManager;
        public MainForm(AnswerManager answerManager, ExerciseManager exerciseManager, QuestionManager questionManager, ProgramManager programManager, UserManager userManager, UserViewManager userViewManager)
        {
            _answerManager = answerManager;
            _exerciseManager = exerciseManager;
            _questionManager = questionManager;
            _programManager = programManager;
            _userManager = userManager;
            _userViewManager = userViewManager;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lblTotalPrograms.Text = $"Total programs: {_programManager.GetAllPrograms().Count}";
            lblTotalQuestions.Text = $"Total questions: {_questionManager.GetAllQuestions().Count}";
            lblTotalUsers.Text = $"Total users: {_userManager.GetAllUsers().Count}";
        }

        private void btnViewQuestion_Click(object sender, EventArgs e)
        {
            ViewQuestions view = new ViewQuestions(this._questionManager, this._answerManager);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnViewPrograms_Click(object sender, EventArgs e)
        {
            ViewPrograms view = new ViewPrograms(_programManager, _exerciseManager);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnViewUsers_Click_1(object sender, EventArgs e)
        {
            ViewUsers view = new ViewUsers(_userViewManager,_userManager);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            this.Hide();
        }
    }
}