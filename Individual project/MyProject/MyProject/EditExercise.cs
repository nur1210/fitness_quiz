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
    public partial class EditExercise : MaterialForm
    {
        private Exercise _exercise;
        private ExerciseManager exerciseManager;
        private EditProgram _editProgram;
        public EditExercise(Exercise e, ExerciseManager eM, EditProgram ep)
        {
            InitializeComponent();
            _exercise = e;
            exerciseManager = eM;
            _editProgram = ep;
        }

        private void EditExercise_Load(object sender, EventArgs e)
        {
            tbxName.Text = _exercise.Name;
            tbxReps.Text = _exercise.Reps.ToString();
            tbxSets.Text = _exercise.Sets.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _exercise.Name = tbxName.Text;
            _exercise.Reps = Convert.ToInt32(tbxReps.Text);
            _exercise.Sets = Convert.ToInt32(tbxSets.Text);

            exerciseManager.EditExercise(_exercise);
            _editProgram.Refresh();
            this.Close();
        }
    }
}
