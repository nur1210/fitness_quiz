using System.Data;
using Logic.Managers;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class ViewQuestions : MaterialForm
    {
        private readonly QuestionManager _questionManager;
        private readonly AnswerManager _answerManager;
        private readonly BindingSource _bindingSourceQuestions = new();
        private readonly BindingSource _bindingSourceAnswers = new();

        public ViewQuestions(QuestionManager qM, AnswerManager aM)
        {
            InitializeComponent();
            _answerManager = aM;
            _questionManager = qM;
        }


        private void EditQuestion_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var i = dgvQuestions.CurrentCell.RowIndex;
            if (i != -1)
            {
                int questionID = Convert.ToInt32(dgvQuestions.Rows[i].Cells[0].Value);
                EditQ edit = new EditQ(_questionManager.GetQuestionByID(questionID), _answerManager, _questionManager, this);
                edit.Show();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var i = dgvQuestions.CurrentCell.RowIndex;
            if (i != -1)
            {
                int questionID = Convert.ToInt32(dgvQuestions.Rows[i].Cells[0].Value);
                _questionManager.RemoveQuestion(questionID);
                UpdateDataGridView();
            }
        }

        public void UpdateDataGridView()
        {
            //I will clean it and move it to a different class later on
            DataSet ds = DGVFunctions.CreateQuestionSchema();
            DataTable questions = ds.Tables["Question"];
            DataTable answers = ds.Tables["Answer"];
            _bindingSourceQuestions.DataSource = ds;
            _bindingSourceAnswers.DataSource = ds;
            _bindingSourceQuestions.DataMember = questions.TableName;
            _bindingSourceAnswers.DataMember = answers.TableName;

            var questionsList = _questionManager.GetAllQuestions();
            List<DataRow> rows = questionsList.Select(t => questions.Rows.Add(t.ID, t.Description)).ToList();
            foreach (var question in questionsList)
            {
                var answersList = _answerManager.GetGetAllAnswersForQuestion(question);
                for (int i = 0; i < answersList.Count; i++)
                {
                    answers.Rows.Add(null, question.ID, answersList[i].Description);
                }
            }

            dgvQuestions.DataSource = _bindingSourceQuestions;
            dgvQuestions.AutoGenerateColumns = true;
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _bindingSourceAnswers.DataSource = _bindingSourceQuestions;
            _bindingSourceAnswers.DataMember = "Question_Answer";
            lbxQuestions.DataSource = _bindingSourceAnswers;
            lbxQuestions.DisplayMember = "Description";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddQuestion add = new AddQuestion(_questionManager, _answerManager, this);
            add.Show();
            add.Closed += (_, _) => Show();
            Hide();
        }
    }
}
