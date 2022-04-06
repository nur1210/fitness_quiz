using ClassLibrary.Logic;
using ClassLibrary.Models;
using MaterialSkin.Controls;
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
    public partial class AssignProgramToAnswer : MaterialForm
    {
        private int _programID;
        private QuestionManager questionManager = new QuestionManager();
        private AnswerManager answerManager = new AnswerManager();
        private ViewPrograms _viewPrograms;
        public AssignProgramToAnswer(int programID, ViewPrograms vP)
        {
            InitializeComponent();
            _programID = programID;
            _viewPrograms = vP;
            var questions = questionManager.GetAllQuestions();
            cbxQuestion.DataSource = questions;
            cbxQuestion.DisplayMember = "Description";
            cbxQuestion.ValueMember = "ID";
        }

        private void cbxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = (Question)cbxQuestion.SelectedItem;
            cbxAnswer.DataSource = answerManager.GetGetAllAnswersForQuestion(q);
            cbxAnswer.DisplayMember = "Description";
            cbxAnswer.ValueMember = "ID";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbxAnswer.SelectedIndex != -1)
            {
                var answerID = Convert.ToInt32(cbxAnswer.SelectedValue);
                answerManager.AddProgramReference(answerID, _programID);
                _viewPrograms.DisplayLabel();
                this.Close();
            }
            
        }
    }
}
