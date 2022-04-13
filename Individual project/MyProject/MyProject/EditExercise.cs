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
using Logic.Models;
using Logic.Managers;

namespace MyProject
{
    public partial class EditExercise : MaterialForm
    {
        private readonly Exercise _exercise;
        private readonly ExerciseManager _exerciseManager;
        private readonly EditProgram _editProgram;
        public EditExercise(Exercise e, ExerciseManager eM, EditProgram ep)
        {
            InitializeComponent();
            _exercise = e;
            _exerciseManager = eM;
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

            _exerciseManager.EditExercise(_exercise);
            _editProgram.Refresh();
            Close();
        }
    }
}
