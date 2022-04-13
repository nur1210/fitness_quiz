using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class StrengthProgram : TrainingProgram
    {
        public StrengthProgram(string description, int typeID, int id = 0) : base(id, description, typeID)
        {
            Description = description;
            TypeID = typeID;
            RestBetweenSets = 180;
            RepRange = Enumerable.Range(1, 5);
            AgeRange = Enumerable.Range(18, 33);
        }

        public override string GetName()
        {
            return "Strength";
        }
    }
}
