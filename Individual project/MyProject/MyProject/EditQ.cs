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

namespace MyProject
{
    public partial class EditQ : MaterialForm
    {
        private Question _question;
        private AnswerManager _answerManager;
        private QuestionManager _questionManager;
        private ViewQuestions _viewQuestion;

        public EditQ(Question question, AnswerManager answerManager, QuestionManager questionManager, ViewQuestions viewQuestion)
        {
            InitializeComponent();
            _question = question;
            _answerManager = answerManager;
            _questionManager = questionManager;
            _viewQuestion = viewQuestion;
            this.Text = $"Edit question number: {_question.ID}";
        }



        private void EditQ_Load(object sender, EventArgs e)
        {
            var answers = _answerManager.GetGetAllAnswersForQuestion(_question);
            TextBox[] textBoxes = new TextBox[4];

            textBoxes[0] = tbxAnswer1;
            textBoxes[1] = tbxAnswer2;
            textBoxes[2] = tbxAnswer3;
            textBoxes[3] = tbxAnswer4;

            tbxQuestion.Text = _question.Description;
            for (int i = 0; i < answers.Count; i++)
            {
                textBoxes[i].Text = answers[i].Description;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string questionDescription = tbxQuestion.Text;

            _question.Description = questionDescription;
            _questionManager.EditQuestion(_question.ID, _question.Description);

            string[] descriptions = new string[4];
            descriptions[0] = tbxAnswer1.Text;
            descriptions[1] = tbxAnswer2.Text;
            descriptions[2] = tbxAnswer3.Text;
            descriptions[3] = tbxAnswer4.Text;

            var answers = _answerManager.GetGetAllAnswersForQuestion(_question);
            List<Answer> answerList = new List<Answer>();
            for (int i = 0; i < answers.Count; i++)
            {
                answerList.Add(answers[i]);
            }
            for (int i = 0; i < answerList.Count; i++)
            {
                answerList[i].Description = descriptions[i];
                _answerManager.EditAnswer(answerList[i]);
            }
            _viewQuestion.UpdateDataGridView();
            this.Close();
        }
    }
}
