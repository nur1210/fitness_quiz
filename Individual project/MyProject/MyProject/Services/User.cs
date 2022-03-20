using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class User
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;
        private bool _isAdmin;
        private bool _isBlocked;

        public int ID { get=> _id; set=> _id = value; }
        public string FirstName { get=> _firstName; set=> _firstName = value; }
        public string LastName { get=> _lastName; set=> _lastName = value; }
        public string Email { get=> _email; set=> _email = value; }
        public string Password { get=> _password; set=> _password = value; }
        public bool IsAdmin { get=> _isAdmin; set=> _isAdmin = value; }
        public bool IsBlocked { get=> _isBlocked; set=> _isBlocked = value; }


        //Create new user
        public User(string firstName, string lastName, string email, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _isAdmin = false;
            _isBlocked = false;
        }

        //Get\set user from\to the database
        public User(int id, string firstName, string lastName, string email, string password, bool isAdmin, bool isBlocked)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
            _isAdmin = isAdmin;
            _isBlocked = isBlocked;
        }
    }
}
