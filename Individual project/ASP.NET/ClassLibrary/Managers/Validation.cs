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
        private readonly IDbLogin _repositoryLogin;

        public Validation(IDbUsers repository, IDbLogin repositoryLogin)
        {
            _repository = repository;
            _repositoryLogin = repositoryLogin;
        }

        public bool ValidUser(string email, string password)
        {
            if (_repository.GetUserByEmail(email) == null) return false;
            var user = _repository.GetUserByEmail(email);
            return Hashing.ValidatePassword(password, user.Password) && !user.IsBlocked;
        }

        public bool ValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public int Login(string email, string password) => _repositoryLogin.Login(email, password);
    }
}
