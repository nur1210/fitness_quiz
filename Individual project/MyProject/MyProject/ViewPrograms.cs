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
        BindingSource bsP = new BindingSource(); // Programs
        BindingSource bsE = new BindingSource(); // Exercises
        private ProgramManager _pM;
        private ExerciseManager _eM;
        public ViewPrograms(ProgramManager pM, ExerciseManager eM)
        {
            InitializeComponent();
            _pM = pM;
            _eM = eM;
        }

        private void ViewPrograms_Load(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddProgram add = new AddProgram(_pM, _eM, this);
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
            bsP.DataSource = ds;
            bsE.DataSource = ds;
            bsP.DataMember = programs.TableName;
            bsE.DataMember = exercises.TableName;

            List<DataRow> rows = new List<DataRow>();
            for (int i = 0; i < _pM.GetAllPrograms().Count; i++)
            {
                rows.Add(programs.Rows.Add(_pM.GetAllPrograms()[i].ID, _pM.GetAllPrograms()[i].Description, _pM.GetAllPrograms()[i].TypeID));
            }
            foreach (var program in _pM.GetAllPrograms())
            {
                for (int i = 0; i < _eM.GetAllExercisesForProgram(program).Count; i++)
                {
                    exercises.Rows.Add(null, program.ID, _eM.GetAllExercisesForProgram(program)[i].Name);
                }
            }

            dgvPrograms.DataSource = bsP;
            dgvPrograms.AutoGenerateColumns = true;
            dgvPrograms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bsE.DataSource = bsP;
            bsE.DataMember = "Program_Exercise";
            lbxExercises.DataSource = bsE;
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
                EditProgram edit = new EditProgram(_pM.GetProgramByID(programID) ,_pM, _eM);
                edit.Show();
                edit.FormClosed += (s, args) => this.Show();
                this.Hide();
            }

        }
    }
}
