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
        private ProgramManager pM = new ProgramManager();
        private AnswerManager aM = new AnswerManager();
        private UserManager uM = new UserManager();
        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            //lblTotalPrograms.Text = $"Total programs: {pM.GetAllPrograms.Count}";
            lblTotalQuestions.Text = $"Total questions: {qM.GetAllQuestions().Count}";
            lblTotalUsers.Text = $"Total users: {uM.GetAllUsers().Count}";
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            AddQuestion question = new AddQuestion(this.qM, this.aM);
            question.Show();
            question.Closed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnAddProgram_Click(object sender, EventArgs e)
        {
            AddProgram program = new AddProgram();
            program.Show();
            program.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnViewQuestion_Click(object sender, EventArgs e)
        {
            EditQuestion edit = new EditQuestion(this.qM, this.aM);
            edit.Show();
            edit.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnViewPrograms_Click(object sender, EventArgs e)
        {
            EditProgram edit = new EditProgram();
            edit.Show();
            edit.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnViewUsers_Click_1(object sender, EventArgs e)
        {
            ViewUsers users = new ViewUsers();
            users.Show();
            users.FormClosed += (s, args) => this.Show();
            this.Hide();
        }
    }
}