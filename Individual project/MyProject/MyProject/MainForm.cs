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
            var chartGender = new PieChart
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
            chartGender.Size = new Size(400, 400);
            panel2.Controls.Add(chartGender);

            var chartAge = new PieChart
            {
                Series = new ObservableCollection<ISeries>() {
                    new PieSeries<int> {
                        Name = "Under 20",
                        Values = new[] { _answerStatisticManager.SumOfUsersUnderTwenty() },
                        Fill = new SolidColorPaint { Color = SKColors.GreenYellow } },
                    new PieSeries<int> {
                        Name = "20-30",
                        Values = new[] { _answerStatisticManager.SumOfUsersBetweenTwentyToThirty() },
                        Fill = new SolidColorPaint { Color = SKColors.LightGreen }},
                    new PieSeries<int> {
                        Name = "30-40",
                        Values = new[] { _answerStatisticManager.SumOfUsersBetweenThirtyToForty() },
                        Fill = new SolidColorPaint { Color = SKColors.AliceBlue } },
                    new PieSeries<int> {
                        Name = "40-50",
                        Values = new[] { _answerStatisticManager.SumOfUsersBetweenFortyToFifty() },
                        Fill = new SolidColorPaint { Color = SKColors.BlueViolet } },
                    new PieSeries<int> {
                        Name = "50-60",
                        Values = new[] { _answerStatisticManager.SumOfUsersBetweenFiftyToSixty() },
                        Fill = new SolidColorPaint { Color = SKColors.Cyan } },
                    new PieSeries<int> {
                        Name = "Above 60",
                        Values = new[] { _answerStatisticManager.SumOfUsersAboveSixty() },
                        Fill = new SolidColorPaint { Color = SKColors.DarkGray },
                    }
                }
            };
            chartAge.Size = new Size(400, 400);
            panel3.Controls.Add(chartAge);
        }
    }
}