using MyProject.ManagerServices;
using MyProject.Programs;
using MyProject.Questions;

namespace MyProject
{
    public partial class MainForm : Form
    {
        private QuestionManager qM = new QuestionManager();
        private ProgramManager pM = new ProgramManager();
        private AnswerManager aM = new AnswerManager();
        private UserManager uM = new UserManager();
        public MainForm()
        {
            InitializeComponent();
            //lblTotalPrograms.Text = $"Total programs: {pM.GetAllPrograms.Count}";
            lblTotalQuestions.Text = $"Total questions: {qM.GetAllQuestions().Count}";
            //lblTotalUsers.Text = $"Total users: {uM.GetAllUsers().Count}";
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

        private void btnEditProgram_Click(object sender, EventArgs e)
        {
            EditProgram edit = new EditProgram();
            edit.Show();
            edit.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            EditQuestion edit = new EditQuestion(this.qM, this.aM);
            edit.Show();
            edit.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}