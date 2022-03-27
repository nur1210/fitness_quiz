using MaterialSkin;
using MaterialSkin.Controls;
using ClassLibrary.Logic;
using ClassLibrary.Models;

namespace MyProject
{
    public partial class MainForm : MaterialForm
    {
        private QuestionManager _questionManager = new QuestionManager();
        private AnswerManager _answerManager = new AnswerManager();
        private ProgramManager _programManager = new ProgramManager();
        private ExerciseManager _exerciseManager = new ExerciseManager();
        private UserManager _userManager = new UserManager();
        public MainForm()
        {
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
            ViewUsers view = new ViewUsers();
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            this.Hide();
        }
    }
}