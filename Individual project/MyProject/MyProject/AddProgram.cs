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

namespace MyProject
{
    public partial class AddProgram : MaterialForm
    {
        public AddProgram()
        {
            InitializeComponent();
            cbxType.Items.Add(ProgramType.WEIGHTLOSS);
            cbxType.Items.Add(ProgramType.WEIGHTGAIN);
            cbxType.Items.Add(ProgramType.STRENGHT);
            cbxType.Items.Add(ProgramType.BEACTIVE);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescription.Text;
            ProgramType type = (ProgramType)cbxType.SelectedItem;
            
            TrainigProgram program = new TrainigProgram(description, type);
            AddExercises exercises = new AddExercises(program);
            exercises.ShowDialog();
            tbxDescription.Clear();
            cbxType.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
