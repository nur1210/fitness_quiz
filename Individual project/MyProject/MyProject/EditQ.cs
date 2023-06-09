﻿using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class EditQ : MaterialForm
    {
        private readonly Question _question;
        private readonly AnswerManager _answerManager;
        private readonly QuestionManager _questionManager;
        private readonly ViewQuestions _viewQuestion;

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
            var answers = _answerManager.GetAllAnswersForQuestion(_question);
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

            var answers = _answerManager.GetAllAnswersForQuestion(_question);
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
            Close();
        }
    }
}
