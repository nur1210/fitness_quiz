using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Answer
    {
        private int _id;
        private int _questionID;
        private string _description;
        private int _programID;

        public int ID { get => _id; set => _id = value; }
        public int QuestionId { get => _questionID; set => _questionID = value; }
        public string Description { get => _description; set => _description = value; }
        public int ProgramID { get => _programID; set => _programID = value; }

        public Answer(int questionId, string description)
        {
            _questionID = questionId;
            _description = description;
        }

        public Answer(int id, int questionID, string description)
        {
            _id = id;
            _questionID = questionID;
            _description = description;
        }

        public Answer(int id, int questionId, string description, int programID)
        {
            _id = id;
            _questionID = questionId;
            _description = description;
            _programID = programID;
        }
    }
}
