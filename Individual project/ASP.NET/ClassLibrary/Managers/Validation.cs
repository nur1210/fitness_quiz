using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.IDb;
using Logic.Models;

namespace Logic.Managers
{
    public class Validation
    {
        private readonly IDbUsers _repository;

        public Validation(IDbUsers repository)
        {
            _repository = repository;
        }

        public bool ValidUser(string email, string password)
        {
            var user = _repository.GetUserByEmail(email);
            return Hashing.ValidatePassword(password, user.Password) && !user.IsBlocked;
        }
    }
}
