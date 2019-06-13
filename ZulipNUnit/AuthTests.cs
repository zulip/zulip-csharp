using NUnit.Framework;
using System.Diagnostics;
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
        public void TestZulipRC() {
            var zuliprc = ".zuliprc";
            var apiKey = "";
            if (File.Exists(zuliprc)) {
                var zulipClient = ZulipServer.Login(zuliprc);
                apiKey = zulipClient.APIKey;
            }
            Assert.IsTrue(!string.IsNullOrEmpty(apiKey));
        }

        [Test]
        public async Task ZulipWithPassword() {
            const string passwordPath = "zulipcredentials.txt";
            var passwordFromFile = "";
            var serverURL = "";
            var email = "";
            if (!File.Exists(passwordPath)) {
                await File.WriteAllTextAsync(passwordPath, "mysecrethere\nhttps://chat.zulip.org\nemail@domain.com");
            }
            if (File.Exists(passwordPath)) {
                var lines = await File.ReadAllLinesAsync(passwordPath);
                passwordFromFile = lines[0];
                serverURL = lines[1];
                email = lines[2];
            }

            var client = await new ZulipServer(serverURL).LoginAsync(email, passwordFromFile);

            Assert.IsTrue(!string.IsNullOrEmpty(client.APIKey));
        }

        [TestCase("https://chat.zulip.org", "", "")]
        public async Task ZulipLoginWithEmailAndApiKeyTest(string serverURL, string userEmail, string apiKey) {
            var srv = new ZulipServer(serverURL);
            var client = srv.Login(userEmail, apiKey);
            var sEndPoint = client.GetStreamEndPoint();
            var streams = await sEndPoint.GetStreams();
            Assert.IsTrue(streams?.Count > 0);
        }
    }
}
