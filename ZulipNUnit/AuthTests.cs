using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZulipAPI;

namespace ZulipNUnit {
    public class AuthTests {

        [SetUp]
        public void Setup() {
        }

        [Test]
        public async Task TestZulipRC() {
            var count = 0;
            if (File.Exists(".zuliprc")) {
                var client = new ZulipClient(".zuliprc");
                var userEndpoint = new Users(client);
                await userEndpoint.GetUsersAsync();
                count = userEndpoint.UserCollection.Count;
            }
            Assert.IsTrue(count > 0);
        }
    }
}
