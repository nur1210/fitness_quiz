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
    public partial class AddExercises : Form
    {
        private TrainigProgram _program;
        public AddExercises(TrainigProgram program)
        {
            InitializeComponent();
            _program = program;
            lblExercises.Text = $"Exercises for program number {_program.ID}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int reps = Convert.ToInt32(tbxReps.Text);
            int sets = Convert.ToInt32(tbxSets.Text);

            Exercise exercise = new Exercise(_program.ID, name, reps, sets);
            _program.ExerciseList.Add(exercise);
            lbxExercises.Items.Add(exercise.Name);
            tbxName.Clear();
            tbxReps.Clear();
            tbxSets.Clear();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            TrainigProgram fullProgram = new TrainigProgram(_program, this._program.ExerciseList);
            Database.Programs.Add(fullProgram);
            MessageBox.Show($"{Database.Programs.Count}");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
