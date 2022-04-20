using System.Collections.ObjectModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Logic.Managers;
using MaterialSkin;
using MaterialSkin.Controls;
using SkiaSharp;


namespace WinFormApp
{
    public partial class MainForm : MaterialForm
    {
        private readonly QuestionManager _questionManager;
        private readonly AnswerManager _answerManager;
        private readonly ProgramManager _programManager;
        private readonly ExerciseManager _exerciseManager;
        private readonly UserManager _userManager;
        private readonly UserViewManager _userViewManager;
        private readonly ProgramTypeManager _programTypeManager;
        private readonly ScoreManager _scoreManager;
        private readonly AnswerStatisticManager _answerStatisticManager;

        public MainForm(AnswerManager answerManager, ExerciseManager exerciseManager, QuestionManager questionManager, ProgramManager programManager, UserManager userManager, UserViewManager userViewManager, ProgramTypeManager programTypeManager, ScoreManager scoreManager, AnswerStatisticManager answerStatisticManager)
        {
            _answerManager = answerManager;
            _exerciseManager = exerciseManager;
            _questionManager = questionManager;
            _programManager = programManager;
            _userManager = userManager;
            _userViewManager = userViewManager;
            _programTypeManager = programTypeManager;
            _scoreManager = scoreManager;
            _answerStatisticManager = answerStatisticManager;
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
            ViewQuestions view = new ViewQuestions(_questionManager, _answerManager);
            view.Show();
            view.FormClosed += (_, _) => Show();
            Hide();
        }

        private void btnViewPrograms_Click(object sender, EventArgs e)
        {
            ViewPrograms view = new ViewPrograms(_programManager, _exerciseManager, _programTypeManager, _questionManager, _answerManager, _scoreManager);
            view.Show();
            view.FormClosed += (_, _) => Show();
            Hide();
        }

        private void btnViewUsers_Click_1(object sender, EventArgs e)
        {
            ViewUsers view = new ViewUsers(_userViewManager,_userManager);
            view.Show();
            view.FormClosed += (_, _) => Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var chart = new PieChart
            {
                Series = new ObservableCollection<ISeries>() {
                    new PieSeries<int> {
                        Values = new[] { _answerStatisticManager.SumOfMaleUsers() },
                        Stroke = null,
                        Fill = new SolidColorPaint { Color = SKColors.DarkOliveGreen } },
                    new PieSeries<int> {
                        Values = new[] { _answerStatisticManager.SumOfFemaleUsers() },
                        Stroke = null,
                        Fill = new SolidColorPaint { Color = SKColors.Aquamarine }
                    }
                }
            };
            panel2.Controls.Add(chart);
        }
    }
}