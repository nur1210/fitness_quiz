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
using Logic.Models;
using WinFormApp;
using Logic.Managers;

namespace MyProject
{
    public partial class EditProgram : MaterialForm
    {
        private TrainingProgram _program;
        private ProgramManager _programManager;
        private ExerciseManager _exerciseManager;
        private ProgramTypeManager _programTypeManager;
        private ViewPrograms _viewPrograms;

        public EditProgram(TrainingProgram program, ProgramManager pM, ExerciseManager eM, ViewPrograms vP)
        {
            InitializeComponent();
            _program = program;
            _programManager = pM;
            _exerciseManager = eM;
            _viewPrograms = vP;

            lblProgram.Text = $"Program Number {_program.ID}";

            cbxType.DataSource = _programTypeManager.GetAllProgramTypes();
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "ID";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _program.Description = tbxDescription.Text;
            _program.TypeID = Convert.ToInt32(cbxType.SelectedValue);
            _program = _program.TypeID switch
            {
                1 => _program.ToBeWeightLossProgram(),
                2 => _program.ToBeMuscleGainProgram(),
                3 => _program.ToBeStrengthProgram(),
                4 => _program.ToBeActiveProgram(),
                _ => _program
            };
            _programManager.EditProgram(_program);
            this.Close();
        }

        private void EditProgram_Load(object sender, EventArgs e)
        {
            tbxDescription.Text = _program.Description;
            foreach (var type in _programTypeManager.GetAllProgramTypes())
            {
                if (_program.TypeID == type.ID)
                {
                    cbxType.SelectedValue = type.ID;
                }
            }
            Refresh();
        }

        private void lbxExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxExercises.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
            }
            else
            {
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int exerciseID = Convert.ToInt32(lbxExercises.SelectedValue);
            EditExercise edit = new EditExercise(_exerciseManager.GetExerciseByID(exerciseID), _exerciseManager, this);
            edit.Show();
        }

        public void Refresh()
        {
            var exercises = _exerciseManager.GetAllExercisesForProgram(_program);
            lbxExercises.DataSource = exercises;
            lbxExercises.DisplayMember = "Name";
            lbxExercises.ValueMember = "ID";
        }
    }
}
