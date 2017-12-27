using System;
using Xunit;
using ZulipAPI;

namespace ZulipAPITests.Serveless
{

    public class AuthTests {

      public string UserEmail = "TestingAuth@ZulipApi.net";
      public string Password = "TestingPassword";
      public string UserSecret = "TestingAPISecret";

      [Fact]
      [Trait("Category", "AuthTests")]
      public void SetUp() {
        this.UserEmail = "TestingAuth@ZulipApi.net";
        this.Password = "TestingPassword";
        this.UserSecret = "TestingAPISecret";
      }

      [Fact]
      [Trait("Category", "AuthTests")]
      public void GenralTests() {
        ZulipAuthentication Auth = new ZulipAuthentication(UserEmail, UserSecret);

        Assert.Equal(Auth.UserEmail, UserEmail);
        Assert.Null(Auth.Password);
        Assert.Equal(Auth.UserSecret, UserSecret);
      }

      [Fact]
      [Trait("Category", "AuthTests")]
      public void SecretIsPasswordTest() {
        Assert.Throws<Exception>(() => {
          ZulipAuthentication Auth =
            new ZulipAuthentication(UserEmail, UserSecret, true);
        });
      }

    }

}