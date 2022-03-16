using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class TrainigProgram
    {
        private int _id;
        private string _description;
        private ProgramType _type;
        private List<Exercise> _exerciseList = new List<Exercise>();

        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set=> _description = value; }
        public ProgramType Type { get => _type; set => _type = value; }
        public List<Exercise> ExerciseList { get => _exerciseList; set => _exerciseList = value; }

        public TrainigProgram(string description, ProgramType type)
        {
            _description = description;
            _type = type;
        }

        public TrainigProgram(int id, string description, ProgramType type)
        {
            _id = id;
            _description = description;
            _type = type;
        }

        public TrainigProgram(TrainigProgram program, List<Exercise> exercises)
        {
            _id = program.ID;
            _description = program._description;
            _type = program._type;
            _exerciseList = exercises;
        }
    }
}
