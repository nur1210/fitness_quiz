using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.View
{
    public class QuestionView
    {
        private int _id;
        private string _description;
        private List<Answer> _answers;

        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public List<Answer> Answers { get => _answers; set => _answers = value; }

        public QuestionView(int id, string description, List<Answer> answers)
        {
            _id = id;
            _description = description;
            _answers = answers;
        }
    }
}
