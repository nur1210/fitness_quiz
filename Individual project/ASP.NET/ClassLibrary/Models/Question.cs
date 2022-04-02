using ClassLibrary.Logic;

namespace ClassLibrary.Models
{
    public class Question
    {
        private int _id;
        private string _description;

        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }

        public Question(int id, string description)
        {
            _id = id;
            _description = description;
        }

        public Question(string description)
        {
            Description = description;
        }
    }
}
