using MaterialSkin.Controls;
using MyProject.ManagerServices;
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
        private Exercise _e;
        private ExerciseManager _eM;
        private EditProgram _ep;
        public EditExercise(Exercise e, ExerciseManager eM, EditProgram ep)
        {
            InitializeComponent();
            _e = e;
            _eM = eM;
            _ep = ep;
        }

        private void EditExercise_Load(object sender, EventArgs e)
        {
            tbxName.Text = _e.Name;
            tbxReps.Text = _e.Reps.ToString();
            tbxSets.Text = _e.Sets.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _e.Name = tbxName.Text;
            _e.Reps = Convert.ToInt32(tbxReps.Text);
            _e.Sets = Convert.ToInt32(tbxSets.Text);

            _eM.EditExercise(_e);
            _ep.Refresh();
            this.Close();
        }
    }
}
