using MyProject.ManagerServices;
using MyProject.Questions;
using MyProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditQuestion : Form
    {
        private QuestionManager _qM;
        private AnswerManager _aM;
        private QuestionViewManager _qvM = new QuestionViewManager();

        public EditQuestion(QuestionManager qM, AnswerManager aM)
        {
            InitializeComponent();
            lbxQuestions.SelectedIndex = -1;
            _aM = aM;
            _qM = qM;   
        }

        private void lbxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxQuestions.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                var question = (Question)lbxQuestions.SelectedItem;
                lblInfo.Text = $"Question ID: {question.ID}\nQuestion description: {question.Description}\nNumber of answers: {_aM.GetGetAllAnswersForQuestion(question).Count}";
            }
        }

        private void EditQuestion_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            QuestionManager manager = new QuestionManager();
            var data = manager.GetAllQuestions();
            lbxQuestions.DataSource = data;
            lbxQuestions.DisplayMember = "description";
            lbxQuestions.ValueMember = "id";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var question = (Question)lbxQuestions.SelectedItem;
            EditQ edit = new EditQ(question, this._aM, this._qM);
            edit.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var question = (Question)lbxQuestions.SelectedItem;
            DbQuestions.DeleteQuestion(question);
        }
        public void UpdateGridView()
        {
            dgvQuestions.Rows.Clear();
            List<string[]> data = new List<string[]>();

            var list = _qvM.GetAllQuestionsForView();
            foreach (var item in list)
            {
                data.Add(new string[] { item.ID.ToString(), item.Description, item.Answers[0].Description, item.Answers[1].Description, item.Answers[2].Description, item.Answers[3].Description });
            }
            var bindingList = new BindingList<QuestionView>(list);
            var source = new BindingSource(bindingList, null);
            dgvQuestions.DataSource = source;
            dgvQuestions.AutoGenerateColumns = true;
        }
    }
}
