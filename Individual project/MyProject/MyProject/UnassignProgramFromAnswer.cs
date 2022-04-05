﻿using ClassLibrary.Logic;
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
    public partial class UnassignProgramFromAnswer : MaterialForm
    {
        private int _programID;
        private AnswerManager answerManager = new AnswerManager();
        private ProgramManager programManager = new ProgramManager();   
        public UnassignProgramFromAnswer(int programID)
        {
            InitializeComponent();
            _programID = programID;
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
            var assignedAnswers = programManager.GetAllAnswersReferncedByProgram(programID);
            lbxAssignedAnswers.DataSource = assignedAnswers;
            lbxAssignedAnswers.DisplayMember = "Description";
            lbxAssignedAnswers.ValueMember = "ID";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
