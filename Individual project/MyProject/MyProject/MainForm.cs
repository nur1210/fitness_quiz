using System.Collections.ObjectModel;
using LiveChartsCore;
using LiveChartsCore.Measure;
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
        private readonly AnswerStatisticManager _answerStatisticManager;
        private readonly ViewQuestions _viewQuestions;
        private readonly ViewUsers _viewUsers;
        private readonly ViewPrograms _viewPrograms;


        public MainForm(QuestionManager questionManager, ProgramManager programManager, UserManager userManager, AnswerStatisticManager answerStatisticManager, ViewQuestions viewQuestions, ViewUsers viewUsers, ViewPrograms viewPrograms)
        {
            _answerStatisticManager = answerStatisticManager;
            _viewQuestions = viewQuestions;
            _viewUsers = viewUsers;
            _viewPrograms = viewPrograms;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            lblTotalPrograms.Text = $"Total programs: {programManager.GetAllPrograms().Count}";
            lblTotalQuestions.Text = $"Total questions: {questionManager.GetAllQuestions().Count}";
            lblTotalUsers.Text = $"Total users: {userManager.GetAllUsers().Count}";
        }

        private void btnViewQuestion_Click(object sender, EventArgs e)
        {
            _viewQuestions.Show();
            _viewQuestions.FormClosed += (_, _) => Show();
            Hide();
        }

        private void btnViewPrograms_Click(object sender, EventArgs e)
        {
            _viewPrograms.Show();
            _viewPrograms.FormClosed += (_, _) => Show();
            Hide();
        }

        private void btnViewUsers_Click_1(object sender, EventArgs e)
        {
            _viewUsers.Show();
            _viewUsers.FormClosed += (_, _) => Show();
            Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var chart = new PieChart
            {
                Series = new ObservableCollection<ISeries>() {
                    new PieSeries<int> {
                        Name = "Males",
                        Values = new[] { _answerStatisticManager.SumOfMaleUsers() },
                        Fill = new SolidColorPaint { Color = SKColors.DarkOliveGreen } },
                    new PieSeries<int> {
                        Name = "Females",
                        Values = new[] { _answerStatisticManager.SumOfFemaleUsers() },
                        Fill = new SolidColorPaint { Color = SKColors.Aquamarine }
                    }
                }
            };
            chart.Size = new Size(400, 400);
            panel2.Controls.Add(chart);

            var barChart = new CartesianChart()
            {
                Series = new ISeries[]
                {
                    new ColumnSeries<int>
                    {
                        Name = "bar",
                        Values = new[] {4, 4, 7, 2, 8},
                        Stroke = new SolidColorPaint(SKColors.Blue) {StrokeThickness = 4}, // mark
                        Fill = null,
                    }
                }
            };
            //panel2.Controls.Add(barChart);
        }

    }
}