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
        private ProgramManager _pM;
        private ExerciseManager _eM;
        private ViewPrograms _vp;
        public AddProgram(ProgramManager pM, ExerciseManager eM, ViewPrograms vp)
        {
            InitializeComponent();
            _pM = pM;
            _eM = eM;
            _vp = vp;
            lblProgram.Text = $"Program number {_pM.GetAllPrograms().Count+1}";
            for (int i = 0; i < manager.GetAllProgramTypes().Count; i++)
            {
                cbxType.Items.Add(manager.GetAllProgramTypes()[i].Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescription.Text;
            int typeID = ++cbxType.SelectedIndex;
            
            TrainigProgram program = new TrainigProgram(description, typeID);
            _pM.AddProgram(program);
            AddExercises exercises = new AddExercises(program, _eM, _pM);
            exercises.ShowDialog();
            tbxDescription.Clear();
            cbxType.SelectedIndex = -1;
            _vp.Refresh();
        }
    }
}
