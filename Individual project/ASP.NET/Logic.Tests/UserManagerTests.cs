using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Extras.Moq;
using Logic.IDb;
using Logic.Managers;
using Logic.Models;
using Moq;
using Xunit;

namespace Logic.Tests
{
    public class UserManagerTests
    {
        [Fact]
        public void GetAllUsers_ValidCall()
        {
            using var mock = AutoMock.GetLoose();
            mock.Mock<IDbUsers>()
                .Setup(x => x.GetAllUsers())
                .Returns(GetSampleUsers());

            var cls = mock.Create<UserManager>();
            var expected = GetSampleUsers();

            var actual = cls.GetAllUsers();

            Assert.True(actual != null);
            Assert.Equal(expected.Count, actual.Count);

            for (var i = 0; i < actual.Count; i++)
            {
                Assert.Equal(expected[i].FirstName, actual[i].FirstName);
                Assert.Equal(expected[i].Email, actual[i].Email);
            }
        }

        [Fact]
        public void GetUserById_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                foreach (var user in GetSampleUsers())
                {
                    mock.Mock<IDbUsers>()
                        .Setup(x => x.GetUserById(user.ID))
                        .Returns(GetSampleUsers().Find(x => x.ID == user.ID));

                    var cls = mock.Create<UserManager>();
                    var expected = GetSampleUsers().Find(x => x.ID == user.ID);

                    var actual = cls.GetUserById(user.ID);

                    Assert.True(actual != null);
                    Assert.Equal(expected.FirstName, actual.FirstName);
                    Assert.Equal(expected.LastName, actual.LastName);
                }
            }
        }

        [Fact]
        public void AddUser_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                foreach (var user in GetSampleUsers())
                {
                    mock.Mock<IDbUsers>()
                        .Setup(x => x.AddUser(user));

                    var cls = mock.Create<UserManager>();
                    cls.AddUser(user);

                    mock.Mock<IDbUsers>()
                        .Verify(x => x.AddUser(user), Times.Exactly(1));
                }
            }
        }

            
        private List<User> GetSampleUsers()
        {
            List<User> users = new List<User>
            {
                new(1, "Mariia", "Parakhina", "mariia@gmail.com", "12345", false, false),
                new(2, "Nur", "Nechuhstan", "nur@gmail.com", "12345", false, false),
                new(3, "Alex", "Dumi", "alex@gmail.com", "12345", false, false),
            };
            return users;
        }
    }
}
