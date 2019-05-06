using NUnit.Framework;
using System.IO;
using System.Threading.Tasks;
using ZulipAPI;
using ZulipAPI.Streams;

namespace ZulipNUnit {
    public class StreamTests {
        ZulipClient zclient;
        StreamEndPoint streamEndpoint;

        [SetUp]
        public async Task Setup() {
            if (File.Exists(".zuliprc")) {
                zclient = ZulipServer.Login(".zuliprc");
                streamEndpoint = zclient.GetStreamEndPoint();
            }
        }

        [Test]
        public async Task GetUsers() {
            var allStreams = await streamEndpoint.GetStreams();
            var count = allStreams.Count;

            Assert.IsTrue(count > 0);
        }
    }
}
