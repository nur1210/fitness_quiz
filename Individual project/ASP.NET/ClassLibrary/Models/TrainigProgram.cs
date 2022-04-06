using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class TrainigProgram
    {
        private int _id;
        private string _description;
        private int _typeID;

        public int ID { get => _id; set => _id = value; }
        public string Description { get => _description; set => _description = value; }
        public int TypeID { get => _typeID; set => _typeID = value; }

        public TrainigProgram()
        {

        }

        public TrainigProgram(string description, int typeID)
        {
            _description = description;
            _typeID = typeID;
        }

        public TrainigProgram(int id, string description, int typeID)
        {
            _id = id;
            _description = description;
            _typeID = typeID;
        }
    }
}
