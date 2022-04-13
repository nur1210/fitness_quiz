using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class BeActiveProgram : TrainingProgram
    {
        public BeActiveProgram(string description, int typeID, int id = 0) : base(id, description, typeID)
        {
            RestBetweenSets = 45;
            RepRange = Enumerable.Range(15, 5);
            AgeRange = Enumerable.Range(0, 101);
        }

        public override string GetName()
        {
            return "Be active";
        }
    }
}
