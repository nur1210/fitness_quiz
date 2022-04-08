using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class MuscleGainProgram : TrainingProgram
    {

        public MuscleGainProgram(string description, int typeID, int id = 0) : base(id, description, typeID)
        {
            RestBetweenSets = 90;
            RepRange = Enumerable.Range(8, 4);
            AgeRange = Enumerable.Range(16, 85);
        }

        public override string GetName()
        {
            return "Muscle gain";
        }
    }
}
