using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.View
{
    public class UserView
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;

        public int ID { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }

        public UserView(int id, string firstName, string lastName, string email)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }
    }
}
