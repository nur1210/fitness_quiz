using System.Data;
using Logic.Managers;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class ViewPrograms : MaterialForm
    {
        private readonly BindingSource _bindingSourcePrograms = new();
        private readonly BindingSource _bindingSourceExercises = new();
        private readonly ProgramManager _programManager;
        private readonly ExerciseManager _exercisesManager;
        private readonly ProgramTypeManager _programTypeManager;
        private readonly QuestionManager _questionManager;
        private readonly AnswerManager _answerManager;
        private readonly ScoreManager _scoreManager;

        public ViewPrograms(ProgramManager pM, ExerciseManager eM, ProgramTypeManager pTM, QuestionManager qM, AnswerManager aM, ScoreManager sM)
        {
            InitializeComponent();
            _programManager = pM;
            _exercisesManager = eM;
            _programTypeManager = pTM;
            _questionManager = qM;
            _answerManager = aM;
            _scoreManager = sM;
        }

        private void ViewPrograms_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProgram add = new AddProgram(_programManager, _exercisesManager, this, _programTypeManager);
            add.Show();
            add.FormClosed += (_, _) => Show();
            Hide();
        }

        public void UpdateDataGridView()
        {
            //I will clean it and move it to a diffrent class later on
            DataSet ds = CreateQuestionSchema();
            DataTable programs = ds.Tables["Program"];
            DataTable exercises = ds.Tables["Exercise"];
            _bindingSourcePrograms.DataSource = ds;
            _bindingSourceExercises.DataSource = ds;
            _bindingSourcePrograms.DataMember = programs.TableName;
            _bindingSourceExercises.DataMember = exercises.TableName;

            List<DataRow> rows = new List<DataRow>();
            var programsList = _programManager.GetAllPrograms();

            for (int i = 0; i < programsList.Count; i++)
            {
                rows.Add(programs.Rows.Add(programsList[i].ID, programsList[i].Description, programsList[i].TypeID));
            }
            foreach (var program in programsList)
            {
                var exercisesList = _exercisesManager.GetAllExercisesForProgram(program);
                for (int i = 0; i < exercisesList.Count; i++)
                {
                    exercises.Rows.Add(null, program.ID, exercisesList[i].Name);
                }
            }

            dgvPrograms.DataSource = _bindingSourcePrograms;
            dgvPrograms.AutoGenerateColumns = true;
            dgvPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _bindingSourceExercises.DataSource = _bindingSourcePrograms;
            _bindingSourceExercises.DataMember = "Program_Exercise";
            lbxExercises.DataSource = _bindingSourceExercises;
            lbxExercises.DisplayMember = "name";
        }

        private DataSet CreateQuestionSchema()
        {
            DataSet ds = new DataSet();

            DataTable programs = ds.Tables.Add("Program");
            DataColumn p_id = programs.Columns.Add("ID", typeof(int));
            programs.Columns.Add("Name", typeof(string));
            programs.Columns.Add("TypeID", typeof(int));

            DataTable exercises = ds.Tables.Add("Exercise");
            DataColumn e_id = exercises.Columns.Add("ID", typeof(int));
            exercises.Columns.Add("ProgramID", typeof(int));
            exercises.Columns.Add("Name", typeof(string));
            exercises.Columns.Add("Reps", typeof (int));
            exercises.Columns.Add("Sets", typeof(int));

            DataRelation relation = ds.Relations.Add("Program_Exercise",
                programs.Columns["ID"],
                exercises.Columns["ProgramID"], true);

            return ds;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var i = dgvPrograms.CurrentCell.RowIndex;
            if (i != -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[i].Cells[0].Value);
                EditProgram edit = new EditProgram(_programManager.GetProgramByID(programID) ,_programManager, _exercisesManager, _programTypeManager);
                edit.Show();
                edit.FormClosed += (_, _) => Show();
                Hide();
            }

        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            var i = dgvPrograms.CurrentCell.RowIndex;
            if (i != -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[i].Cells[0].Value);
                AddScore assign = new AddScore(programID, this, _questionManager, _answerManager, _scoreManager);
                assign.Show();
                assign.FormClosed += (_, _) => Show();
                Hide();
            }
        }

        private void btnRemoveReference_Click(object sender, EventArgs e)
        {
            var i = dgvPrograms.CurrentCell.RowIndex;
            if (i != -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[i].Cells[0].Value);
                EditScore editScore = new EditScore(programID, _scoreManager, _answerManager);
                editScore.Show();
                editScore.FormClosed += (_, _) => Show();
                Hide();
            }
        }

        public void DisplayLabel()
        {
            int? i = dgvPrograms.CurrentCell?.RowIndex;
            if (i is int idx and > -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[idx].Cells[0].Value);
                var scoreList = _scoreManager.GetScoresForProgramByProgramID(programID);
                if (scoreList.Count > 0)
                {
                    lblAssigned.Visible = true;
                    btnRemoveReference.Visible = true;
                }
                else
                {
                    btnRemoveReference.Visible=false;
                    lblAssigned.Visible=false;
                }
            }
        }

        private void dgvPrograms_SelectionChanged(object sender, EventArgs e)
        {
            DisplayLabel();
        }
    }
}
