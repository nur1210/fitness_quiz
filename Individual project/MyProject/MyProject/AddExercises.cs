using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class AddExercises : MaterialForm
    {
        private readonly ExerciseManager _exerciseManager;
        private readonly ProgramManager _programManager;
        public AddExercises(ExerciseManager exerciseManager, ProgramManager programManager)
        {
            InitializeComponent();
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

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
