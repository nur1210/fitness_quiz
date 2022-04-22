using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using Xunit;

namespace Logic.Tests
{
    public class ValidationTests
    {
        [Fact]
        public void ValidUser_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                foreach (var user in GetSampleUsers())
                {
                    mock.Mock<IDbUsers>()
                        .Setup(x => x.GetUserByEmail(user.Email))
                        .Returns(GetSampleUsers().Find(x => x.Email == user.Email));

                    var cls = mock.Create<Validation>();
                    var expected = true;
                    var actual = false;
                    switch (user.ID)
                    {
                        case 1: actual = cls.ValidUser(user.Email, "12345");
                            break;
                        case 2: actual = cls.ValidUser(user.Email, "23232");
                            break;
                        case 3: actual = cls.ValidUser(user.Email, "asdfg");
                            break;
                    }
                    Assert.True(actual != null);
                    Assert.Equal(expected, actual);
                }
            }
        }

        [Fact]
        public void Login_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                foreach (var user in GetSampleUsersForLogin())
                {
                    mock.Mock<IDbLogin>()
                        .Setup(x => x.Login(user.Email, user.Password))
                        .Returns(user.ID);

                    var cls = mock.Create<Validation>();
                    var expected = user.ID;
                    var actual = 0;
                    switch (user.ID)
                    {
                        case 1:
                            actual = cls.Login(user.Email, user.Password);
                            break;
                        case 2:
                            actual = cls.Login(user.Email, user.Password);
                            break;
                        case 3:
                            actual = cls.Login(user.Email, user.Password);
                            break;
                    }
                    Assert.True(actual != null);
                    Assert.Equal(expected, actual);
                }
            }
        }

        private List<User> GetSampleUsers()
        {
            List<User> users = new List<User>
            {
                new(1, "Mariia", "Parakhina", "mariia@gmail.com", Hashing.HashPassword("12345"), false, false),
                new(2, "Nur", "Nechuhstan", "nur@gmail.com", Hashing.HashPassword("23232"), false, false),
                new(3, "Alex", "Parakhina", "alex@gmail.com", Hashing.HashPassword("asdfg"), false, false),
            };
            return users;
        }

        private List<User> GetSampleUsersForLogin()
        {
            List<User> users = new List<User>
            {
                new(1, "Mariia", "Parakhina", "mariia@gmail.com", "12345", false, false),
                new(2, "Nur", "Nechuhstan", "nur@gmail.com", "fgg43", false, false),
                new(3, "Alex", "Parakhina", "alex@gmail.com", "asdfg", false, false),
            };
            return users;
        }
    }
}
