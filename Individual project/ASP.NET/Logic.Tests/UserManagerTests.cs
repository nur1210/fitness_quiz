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
    public class UserManagerTests
    {
        [Fact]
        public void GetAllUsers_ValidCall()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IDbUsers>()
                    .Setup(x => x.GetAllUsers())
                    .Returns(GetSampleUsers());

                var cls = mock.Create<UserManager>();
                var expected = GetSampleUsers();

                var actual = cls.GetAllUsers();

                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);
            }
        }

        private List<User> GetSampleUsers()
        {
            List<User> users = new List<User>
            {
                new User(1, "Mariia", "Parakhina", "mariia@gmail.com", "12345", false, false),
                new User(2, "Nur", "Parakhina", "nur@gmail.com", "12345", false, false),
                new User(3, "Alex", "Parakhina", "alex@gmail.com", "12345", false, false),
            };
            return users;
        }
    }
}
