using MaterialSkin.Controls;
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
    public partial class EditQuestion : MaterialForm
    {
        private QuestionManager _qM;
        private AnswerManager _aM;
        private QuestionViewManager _qvM = new QuestionViewManager();
        BindingSource bsQ = new BindingSource(); // Questions
        BindingSource bsA = new BindingSource(); // Answers

        public EditQuestion(QuestionManager qM, AnswerManager aM)
        {
            InitializeComponent();
            _aM = aM;
            _qM = qM;   
        }


        private void EditQuestion_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
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
            var i = dgvQuestions.CurrentCell.RowIndex;
            if (i > 0)
            {
                int questionID = Convert.ToInt32(dgvQuestions.Rows[i].Cells[0].Value);
                DbQuestions.DeleteQuestion(questionID);
                UpdateDataGridView();
            }
        }

        public void UpdateDataGridView()
        {
            //I will clean it and move it to a diffrent class later on
            DataSet ds = DGVFunctions.CreateQuestionSchema();
            DataTable questions = ds.Tables["Question"];
            DataTable answers = ds.Tables["Answer"];
            bsQ.DataSource = ds;
            bsA.DataSource = ds;
            bsQ.DataMember = questions.TableName;
            bsA.DataMember = answers.TableName;

            List<DataRow> rows = new List<DataRow>();
            for (int i = 0; i < _qM.GetAllQuestions().Count; i++)
            {
                rows.Add(questions.Rows.Add(_qM.GetAllQuestions()[i].ID, _qM.GetAllQuestions()[i].Description));
            }
            foreach (var question in _qM.GetAllQuestions())
            {
                for (int i = 0; i < _aM.GetGetAllAnswersForQuestion(question).Count; i++)
                {
                    answers.Rows.Add(null, question.ID, _aM.GetGetAllAnswersForQuestion(question)[i].Description);
                }
            }

            dgvQuestions.DataSource = bsQ;
            dgvQuestions.AutoGenerateColumns = true;
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bsA.DataSource = bsQ;
            bsA.DataMember = "Question_Answer";
            lbxQuestions.DataSource = bsA;
            lbxQuestions.DisplayMember = "Description";
        }
    }
}
