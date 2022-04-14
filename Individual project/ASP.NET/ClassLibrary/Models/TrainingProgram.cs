using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class TrainingProgram
    {
        private int _id;
        protected string _description;
        private int _typeID;
        protected int _restBetweenSets;
        protected IEnumerable<int> _repRange;
        protected IEnumerable<int> _ageRange;


        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int TypeID { get => _typeID; set => _typeID = value; }
        public int RestBetweenSets { get => _restBetweenSets; set => _restBetweenSets = value; }
        public IEnumerable<int> RepRange { get => _repRange; set => _repRange = value; }
        public IEnumerable<int> AgeRange { get => _ageRange; set => _ageRange = value; }

        public TrainingProgram()
        {

        }

        public TrainingProgram(int id, string description, int typeID)
        {
            _id = id;
            _description = description;
            _typeID = typeID;
        }

        public virtual TrainingProgram ToBeActiveProgram()
        {
            return new BeActiveProgram(Description, TypeID, _id);
        }

        public virtual TrainingProgram ToBeStrengthProgram()
        {
            return new StrengthProgram(Description, TypeID, _id);
        }

        public virtual TrainingProgram ToBeWeightLossProgram()
        {
            return new WeightLossProgram(Description, TypeID, _id);
        }

        public virtual TrainingProgram ToBeMuscleGainProgram()
        {
            return new MuscleGainProgram(Description, TypeID, _id);
        }

        public virtual string GetName()
        {
            return "BaseClass";
        }
    }
}
