using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class EditProgram : MaterialForm
    {
        private TrainingProgram _program;
        private readonly ProgramManager _programManager;
        private readonly ExerciseManager _exerciseManager;
        private readonly ProgramTypeManager _programTypeManager;

        public EditProgram(TrainingProgram program, ProgramManager pM, ExerciseManager eM, ProgramTypeManager programTypeManager)
        {
            InitializeComponent();
            _program = program;
            _programManager = pM;
            _exerciseManager = eM;
            _programTypeManager = programTypeManager;

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

        public override void Refresh()
        {
            var exercises = _exerciseManager.GetAllExercisesForProgram(_program);
            lbxExercises.DataSource = exercises;
            lbxExercises.DisplayMember = "Name";
            lbxExercises.ValueMember = "ID";
        }
    }
}
