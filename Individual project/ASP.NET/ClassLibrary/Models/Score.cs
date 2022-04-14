using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Score
    {
        private int _questionOptionID;
        private int _programID;
        private int _weight;

        public int QuestionOptionID { get => _questionOptionID; set => _questionOptionID = value; }
        public int ProgramID { get => _programID; set => _programID = value; }
        public int Weight { get => _weight; set => _weight = value; }

        public Score(int questionOptionId, int programId, int weight)
        {
            _questionOptionID = questionOptionId;
            ProgramID = programId;
            Weight = weight;
        }
    }
}
