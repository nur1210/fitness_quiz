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
    public partial class EditQ : MaterialForm
    {
        private Question _question;
        private AnswerManager _aM;
        private QuestionManager _qM;
        private EditQuestion _eQ;
        public EditQ(Question question, AnswerManager aM, QuestionManager qM, EditQuestion eQ)
        {
            InitializeComponent();
            _question = question;
            _aM = aM;
            _qM = qM;
            _eQ = eQ;
            this.Text = $"Edit question number: {_question.ID}";
        }

        private void EditQ_Load(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new TextBox[4];

            textBoxes[0] = tbxAnswer1;
            textBoxes[1] = tbxAnswer2;
            textBoxes[2] = tbxAnswer3;
            textBoxes[3] = tbxAnswer4;

            tbxQuestion.Text = _question.Description;
            for (int i = 0; i < _aM.GetGetAllAnswersForQuestion(_question).Count; i++)
            {
                textBoxes[i].Text = _aM.GetGetAllAnswersForQuestion(_question)[i].Description;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string questionDescription = tbxQuestion.Text;

            _question.Description = questionDescription;
            _qM.EditQuestion(_question.ID, _question.Description);

            string[] descriptions = new string[4];
            descriptions[0] = tbxAnswer1.Text;
            descriptions[1] = tbxAnswer2.Text;
            descriptions[2] = tbxAnswer3.Text;
            descriptions[3] = tbxAnswer4.Text;
            List<Answer> answerList = new List<Answer>();
            for (int i = 0; i < _aM.GetGetAllAnswersForQuestion(_question).Count; i++)
            {
                answerList.Add(_aM.GetGetAllAnswersForQuestion(_question)[i]);
            }
            for (int i = 0; i < answerList.Count; i++)
            {
                answerList[i].Description = descriptions[i];
                _aM.EditAnswer(answerList[i]);
            }
            _eQ.UpdateDataGridView();
            this.Close();
        }
    }
}
