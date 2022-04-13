using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Exercise : IExercise
    {
        private int _id;
        private int _programID;
        private string _name;
        private int _reps;
        private int _sets;

        public int ID { get => _id; set => _id = value; }
        public int ProgramID { get => _programID; set => _programID = value; }
        public string Name { get => _name; set => _name = value; }
        public int Reps { get => _reps; set => _reps = value; }
        public int Sets { get => _sets; set => _sets = value; }

        public Exercise(int id, int programID, string name, int reps, int sets)
        {
            _id = id;
            _programID = programID;
            _name = name;
            _reps = reps;
            _sets = sets;
        }

        public Exercise(int programID, string name, int reps, int sets)
        {
            _programID = programID;
            _name = name;
            _reps = reps;
            _sets = sets;
        }

    }
}
