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
    public partial class ViewPrograms : MaterialForm
    {
        BindingSource bindingSourcePrograms = new BindingSource();
        BindingSource bindingSourceExercises = new BindingSource();
        private ProgramManager _programManager;
        private ExerciseManager _exercisesManager;
        public ViewPrograms(ProgramManager pM, ExerciseManager eM)
        {
            InitializeComponent();
            _programManager = pM;
            _exercisesManager = eM;
        }

        private void ViewPrograms_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProgram add = new AddProgram(_programManager, _exercisesManager, this);
            add.Show();
            add.FormClosed += (s, args) => this.Show();
            this.Hide();
        }

        public void UpdateDataGridView()
        {
            //I will clean it and move it to a diffrent class later on
            DataSet ds = CreateQuestionSchema();
            DataTable programs = ds.Tables["Program"];
            DataTable exercises = ds.Tables["Exercise"];
            bindingSourcePrograms.DataSource = ds;
            bindingSourceExercises.DataSource = ds;
            bindingSourcePrograms.DataMember = programs.TableName;
            bindingSourceExercises.DataMember = exercises.TableName;

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

            dgvPrograms.DataSource = bindingSourcePrograms;
            dgvPrograms.AutoGenerateColumns = true;
            dgvPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingSourceExercises.DataSource = bindingSourcePrograms;
            bindingSourceExercises.DataMember = "Program_Exercise";
            lbxExercises.DataSource = bindingSourceExercises;
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
                EditProgram edit = new EditProgram(_programManager.GetProgramByID(programID) ,_programManager, _exercisesManager);
                edit.Show();
                edit.FormClosed += (s, args) => this.Show();
                this.Hide();
            }

        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            var i = dgvPrograms.CurrentCell.RowIndex;
            if (i != -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[i].Cells[0].Value);
                AssignProgramToAnswer assign = new AssignProgramToAnswer(programID);
                assign.Show();
                assign.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
        }

        private void btnRemoveReference_Click(object sender, EventArgs e)
        {
            var i = dgvPrograms.CurrentCell.RowIndex;
            if (i != -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[i].Cells[0].Value);
                UnassignProgramFromAnswer unassign = new UnassignProgramFromAnswer(programID);
                unassign.Show();
                unassign.FormClosed += (s, args) => this.Show();
                this.Hide();
            }
        }

        private void DisplayLabel()
        {
            var i = dgvPrograms.CurrentCell.RowIndex;
            if (i != -1)
            {
                int programID = Convert.ToInt32(dgvPrograms.Rows[i].Cells[0].Value);
                var assignedAnswers = _programManager.GetAllAnswersReferncedByProgram(programID);
                if (assignedAnswers.Count > 0)
                {
                    lblAssigned.Visible = true;
                    string info = "";
                    foreach (var answer in assignedAnswers)
                    {
                        string description = answer.Description;
                        info += $"{description}, ";
                    }
                    lblAssigned.Text = $"Assigned asnwers: {info}";
                }
                else
                {
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
