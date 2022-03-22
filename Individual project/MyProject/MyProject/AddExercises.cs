using MaterialSkin.Controls;
using MyProject.ManagerServices;
using MyProject.Programs;
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
        private TrainigProgram _program;
        private ExerciseManager _eM;
        private ProgramManager _pM;
        public AddExercises(TrainigProgram program, ExerciseManager eM, ProgramManager pM)
        {
            InitializeComponent();
            _program = program;
            _eM = eM;
            _pM = pM;
            this.Text = $"Exercises for program number {_pM.GetInsertedProgramID()}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            int reps = Convert.ToInt32(tbxReps.Text);
            int sets = Convert.ToInt32(tbxSets.Text);

            Exercise exercise = new Exercise(_pM.GetInsertedProgramID(), name, reps, sets);
            _eM.AddExercise(exercise);
            lbxExercises.Items.Add(exercise.Name);
            tbxName.Clear();
            tbxReps.Clear();
            tbxSets.Clear();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExercises_Load(object sender, EventArgs e)
        {

        }

    }
}
