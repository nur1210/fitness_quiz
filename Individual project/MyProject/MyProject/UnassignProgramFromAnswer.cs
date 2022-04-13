using Logic.Managers;
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
    public partial class UnassignProgramFromAnswer : MaterialForm
    {
        private int _programID;
        private AnswerManager answerManager;
        private ProgramManager programManager;
        private ViewPrograms _viewPrograms;
        public UnassignProgramFromAnswer(int programID, ViewPrograms vP)
        {
            InitializeComponent();
            _programID = programID;
            _viewPrograms = vP;
            Refresh();
        }

        private void btnUnassign_Click(object sender, EventArgs e)
        {
            if (lbxAssignedAnswers.SelectedIndex != -1)
            {
                var answerID = Convert.ToInt32(lbxAssignedAnswers.SelectedValue);
                answerManager.RemoveProgramReference(answerID);
                Refresh();
            }
        }

        private void Refresh()
        {
            var assignedAnswers = programManager.GetAllAnswersReferncedByProgram(_programID);
            lbxAssignedAnswers.DataSource = assignedAnswers;
            lbxAssignedAnswers.DisplayMember = "Description";
            lbxAssignedAnswers.ValueMember = "ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _viewPrograms.DisplayLabel();    
            this.Close();
        }
    }
}
