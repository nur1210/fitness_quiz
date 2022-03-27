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
    public partial class EditProgram : MaterialForm
    {
        private TrainigProgram _program;
        private ProgramManager _programManager;
        private ExerciseManager _exerciseManager;
        private ProgramTypeManager manager = new ProgramTypeManager();

        public EditProgram(TrainigProgram program, ProgramManager pM, ExerciseManager eM)
        {
            InitializeComponent();
            _program = program;
            _programManager = pM;
            _exerciseManager = eM;

            lblProgram.Text = $"Program Number {_program.ID}";

            var programs = manager.GetAllProgramTypes();
            for (int i = 0; i < programs.Count; i++)
            {
                cbxType.Items.Add(programs[i].Name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _program.Description = tbxDescription.Text;
            _program.TypeID = ++cbxType.SelectedIndex;
            _programManager.EditProgram(_program);
        }

        private void EditProgram_Load(object sender, EventArgs e)
        {
            tbxDescription.Text = _program.Description;
            cbxType.SelectedIndex = (_program.TypeID-1);
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
