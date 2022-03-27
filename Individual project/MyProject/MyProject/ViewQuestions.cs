using MaterialSkin.Controls;
using ClassLibrary.Logic;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.DB;

namespace MyProject
{
    public partial class ViewQuestions : MaterialForm
    {
        private QuestionManager _questionManager;
        private AnswerManager _answerManager;
        BindingSource bindingSourceQuestions = new BindingSource(); 
        BindingSource bindingSourceAnswers = new BindingSource(); 

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
                EditQ edit = new EditQ(_questionManager.GetQuestionByID(questionID), this._answerManager, this._questionManager, this);
                edit.Show();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var i = dgvQuestions.CurrentCell.RowIndex;
            if (i != -1)
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
            bindingSourceQuestions.DataSource = ds;
            bindingSourceAnswers.DataSource = ds;
            bindingSourceQuestions.DataMember = questions.TableName;
            bindingSourceAnswers.DataMember = answers.TableName;

            List<DataRow> rows = new List<DataRow>();
            var questionsList = _questionManager.GetAllQuestions();
            for (int i = 0; i < questionsList.Count; i++)
            {
                rows.Add(questions.Rows.Add(questionsList[i].ID, questionsList[i].Description));
            }
            foreach (var question in questionsList)
            {
                var answersList = _answerManager.GetGetAllAnswersForQuestion(question);
                for (int i = 0; i < answersList.Count; i++)
                {
                    answers.Rows.Add(null, question.ID, answersList[i].Description);
                }
            }

            dgvQuestions.DataSource = bindingSourceQuestions;
            dgvQuestions.AutoGenerateColumns = true;
            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSourceAnswers.DataSource = bindingSourceQuestions;
            bindingSourceAnswers.DataMember = "Question_Answer";
            lbxQuestions.DataSource = bindingSourceAnswers;
            lbxQuestions.DisplayMember = "Description";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddQuestion add = new AddQuestion(_questionManager, _answerManager, this);
            add.Show();
            add.Closed += (s, args) => this.Show();
            this.Hide();
        }
    }
}
