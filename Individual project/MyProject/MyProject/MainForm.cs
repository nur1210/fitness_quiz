using MaterialSkin;
using MaterialSkin.Controls;
using MyProject.ManagerServices;
using MyProject.Programs;
using MyProject.Questions;

namespace MyProject
{
    public partial class MainForm : MaterialForm
    {
        private QuestionManager qM = new QuestionManager();
        private AnswerManager aM = new AnswerManager();
        private ProgramManager pM = new ProgramManager();
        private ExerciseManager eM = new ExerciseManager();
        private UserManager uM = new UserManager();
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lblTotalPrograms.Text = $"Total programs: {pM.GetAllPrograms().Count}";
            lblTotalQuestions.Text = $"Total questions: {qM.GetAllQuestions().Count}";
            lblTotalUsers.Text = $"Total users: {uM.GetAllUsers().Count}";
        }

        private void btnViewQuestion_Click(object sender, EventArgs e)
        {
            ViewQuestions view = new ViewQuestions(this.qM, this.aM);
            view.Show();
            view.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnViewPrograms_Click(object sender, EventArgs e)
        {
            ViewPrograms view = new ViewPrograms(this.pM, this.eM);
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