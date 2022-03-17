using MyProject.ManagerServices;
using MyProject.Questions;
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
    public partial class AddQuestion : Form
    {
        private QuestionManager _qM;
        private AnswerManager _aM;
        public AddQuestion(QuestionManager qM, AnswerManager aM)
        {
            InitializeComponent();
            _qM = qM;
            _aM = aM;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddQuestion_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Add question number: {(_qM.GetAllQuestions().Count)+1}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string questionDescription = tbxQuestion.Text;
            string answer1 = tbxAnswer1.Text;
            string answer2 = tbxAnswer2.Text;
            string answer3 = tbxAnswer3.Text;
            string answer4 = tbxAnswer4.Text;

            Question question = new Question(questionDescription);
            _qM.AddQuestion(question);

            Answer a1 = new Answer(_qM.GetInsertedQuestionID(), answer1);
            Answer a2 = new Answer(_qM.GetInsertedQuestionID(), answer2);
            Answer a3 = new Answer(_qM.GetInsertedQuestionID(), answer3);
            Answer a4 = new Answer(_qM.GetInsertedQuestionID(), answer4);

            _aM.AddAnswer(a1);
            _aM.AddAnswer(a2);
            _aM.AddAnswer(a3);
            _aM.AddAnswer(a4);

            tbxQuestion.Clear();
            tbxAnswer1.Clear();
            tbxAnswer2.Clear();
            tbxAnswer3.Clear();
            tbxAnswer4.Clear();
        }
    }
}
