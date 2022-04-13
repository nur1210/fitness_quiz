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
using System.Reflection;
using Logic.Models;
using Logic.Managers;

namespace MyProject
{
    public partial class AddProgram : MaterialForm
    {
        private readonly ProgramManager _programManager;
        private readonly ExerciseManager _exerciseManager;
        private readonly ViewPrograms _viewPrograms;
        public AddProgram(ProgramManager programManager, ExerciseManager exerciseManager, ViewPrograms viewPrograms, ProgramTypeManager programTypeManager)
        {
            InitializeComponent();
            _programManager = programManager;
            _exerciseManager = exerciseManager;
            _viewPrograms = viewPrograms;
            lblProgram.Text = $"Program number {_programManager.GetAllPrograms().Count + 1}";

            cbxType.DataSource = programTypeManager.GetAllProgramTypes();
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescription.Text;
            int typeID = Convert.ToInt32(cbxType.SelectedValue);
            //Add map later?
            TrainingProgram program = typeID switch
            {
                1 =>  new WeightLossProgram(description, typeID),
                2 =>  new MuscleGainProgram(description, typeID),
                3 =>  new StrengthProgram(description, typeID),
                4 => new BeActiveProgram(description, typeID),
                _ => new BeActiveProgram(description, typeID)
            };

            _programManager.AddProgram(program);
            AddExercises exercises = new AddExercises(_exerciseManager, _programManager);
            exercises.ShowDialog();
            tbxDescription.Clear();
            cbxType.SelectedIndex = -1;
            _viewPrograms.Refresh();
        }
    }
}
