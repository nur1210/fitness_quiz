using Logic.Managers;
using Logic.Models;
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
    public partial class AddExercises : MaterialForm
    {
        private TrainingProgram _program;
        private ExerciseManager _exerciseManager;
        private ProgramManager _programManager;
        public AddExercises(TrainingProgram program, ExerciseManager exerciseManager, ProgramManager programManager)
        {
            InitializeComponent();
            _program = program;
            _exerciseManager = exerciseManager;
            _programManager = programManager;
            this.Text = $"Exercises for program number {_programManager.GetInsertedProgramID()}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int reps = Convert.ToInt32(tbxReps.Text);
            int sets = Convert.ToInt32(tbxSets.Text);

            Exercise exercise = new Exercise(_programManager.GetInsertedProgramID(), name, reps, sets);
            _exerciseManager.AddExercise(exercise);
            lbxExercises.Items.Add(exercise.Name);
            tbxName.Clear();
            tbxReps.Clear();
            tbxSets.Clear();
        }
    }
}
