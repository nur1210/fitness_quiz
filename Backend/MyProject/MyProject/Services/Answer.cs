using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Answer
    {
        private int _id;
        private int _questionId;
        private string _description;

        public int ID { get=> _id; set=> _id = value; }
        public int QuestionId { get=> _questionId; set=> _questionId = value; }
        public string Description { get => _description; set => _description = value; }

        public Answer(int questionId, string description)
        {
            _questionId = questionId;
            _description = description;
        }

        public Answer(int id, int questionId, string description)
        {
            _id = id;
            _questionId = questionId;
            _description = description;
        }
    }
}
