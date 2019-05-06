using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZulipAPI;
using ZulipAPI.Users;

namespace ZulipNUnit {
    public class UserTests {

        ZulipClient zclient;
        UserEndPoint userEndpoint;
        private string _demoMail = "somemail@someprovider.com";
        private IList<User> _users;
        private User _user;

        [SetUp]
        public async Task Setup() {
            if (File.Exists(".zuliprc")) {
                zclient = ZulipServer.Login(".zuliprc");
                userEndpoint = zclient.GetUserEndPoint();
                await RefreshData();
            }
        }

        private async Task RefreshData() {
            _users = await userEndpoint.GetUsers();
            _user = _users.FirstOrDefault(x => x.Email == _demoMail);
        }

        [Test]
        public void GetUsers() {
            var count = _users.Count;

            Assert.IsTrue(count > 0);
        }

        //[Test]
        //public async Task GetUserById() {
        //    User user = await userEndpoint.GetUserById(220720);

        //    Assert.IsTrue(user?.FullName?.Length > 0);
        //}

        [Test]
        public async Task CreateUser() {
            var countBefore = _users.Count;
            var user = new User(_demoMail, DateTime.Now.Ticks.ToString(), "Johnny", "John Dough");
            await userEndpoint.CreateUser(user);
            _users = await userEndpoint.GetUsers();
            var countAfter = _users.Count;

            Assert.IsTrue(countBefore < countAfter);
        }

        [Test]
        public async Task EditUser() {
            _user.FullName += "1";
            //userToEdit.IsAdmin = !userToEdit.IsAdmin;
            var newName = string.Copy(_user.FullName);
            await userEndpoint.EditUser(_user);
            var againAllUsers = await userEndpoint.GetUsers();
            var userAfterEdit = againAllUsers.FirstOrDefault(x => x.UserID == _user.UserID);

            //Assert.IsTrue(userToEdit.IsAdmin == userAfterEdit.IsAdmin);
            Assert.IsTrue(againAllUsers.Any(x => x.FullName == newName));
        }

        [Test]
        public async Task DeactivateUser() {
            await userEndpoint.DeactivateUser(_user);
            await RefreshData();
            Assert.IsFalse(_user.IsActive);
        }

        [Test]
        public async Task ReactivateUser() {
            await userEndpoint.ReactivateUser(_user);
            await RefreshData();
            Assert.IsTrue(_user.IsActive);
        }
    }
}
