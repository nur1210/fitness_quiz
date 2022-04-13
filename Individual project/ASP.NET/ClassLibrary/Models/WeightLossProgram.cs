using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class WeightLossProgram : TrainingProgram
    {
        public WeightLossProgram(string description, int typeID, int id = 0) : base(id, description, typeID)
        {
            Description = description;
            TypeID = typeID;
            RestBetweenSets = 60;
            AgeRange = Enumerable.Range(16, 85);
        }

        public override string GetName()
        {
            return "Weight loss";
        }
    }
}
