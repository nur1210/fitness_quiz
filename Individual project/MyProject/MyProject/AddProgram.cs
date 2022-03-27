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
    public partial class AddProgram : MaterialForm
    {
        private ProgramTypeManager manager = new ProgramTypeManager();
        private ProgramManager _programManager;
        private ExerciseManager _exerciseManager;
        private ViewPrograms _viewPrograms;
        public AddProgram(ProgramManager programManager, ExerciseManager exerciseManager, ViewPrograms viewPrograms)
        {
            InitializeComponent();
            _programManager = programManager;
            _exerciseManager = exerciseManager;
            _viewPrograms = viewPrograms;
            lblProgram.Text = $"Program number {_programManager.GetAllPrograms().Count+1}";

            var programs = manager.GetAllProgramTypes();
            for (int i = 0; i < programs.Count; i++)
            {
                cbxType.Items.Add(programs[i].Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescription.Text;
            int typeID = ++cbxType.SelectedIndex;
            
            TrainigProgram program = new TrainigProgram(description, typeID);
            _programManager.AddProgram(program);
            AddExercises exercises = new AddExercises(program, _exerciseManager, _programManager);
            exercises.ShowDialog();
            tbxDescription.Clear();
            cbxType.SelectedIndex = -1;
            _viewPrograms.Refresh();
        }
    }
}
