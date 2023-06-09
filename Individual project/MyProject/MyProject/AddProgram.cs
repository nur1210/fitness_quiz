﻿using Logic.Managers;
using Logic.Models;
using MaterialSkin.Controls;

namespace WinFormApp
{
    public partial class AddProgram : MaterialForm
    {
        private readonly ProgramManager _programManager;
        //private readonly ViewPrograms _viewPrograms;
        private readonly ProgramTypeManager _programTypeManager;
        private readonly AddExercises _addExercises;
        public AddProgram(ProgramManager programManager, ProgramTypeManager programTypeManager, AddExercises addExercises)
        {
            InitializeComponent();
            _programManager = programManager;
            _programTypeManager = programTypeManager;
            _addExercises = addExercises;
            lblProgram.Text = $"Program number {_programManager.GetAllPrograms().Count + 1}";

            cbxType.DataSource = _programTypeManager.GetAllProgramTypes();
            cbxType.DisplayMember = "Name";
            cbxType.ValueMember = "ID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = tbxDescription.Text;
            int typeID = Convert.ToInt32(cbxType.SelectedValue);
            TrainingProgram program = typeID switch
            {
                1 =>  new WeightLossProgram(description, typeID),
                2 =>  new MuscleGainProgram(description, typeID),
                3 =>  new StrengthProgram(description, typeID),
                4 => new BeActiveProgram(description, typeID),
                _ => new BeActiveProgram(description, typeID)
            };

            _programManager.AddProgram(program);
            _addExercises.ShowDialog();
            tbxDescription.Clear();
            cbxType.SelectedIndex = -1;
            //_viewPrograms.UpdateDataGridView();
        }
    }
}
