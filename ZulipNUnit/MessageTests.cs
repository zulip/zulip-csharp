using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZulipAPI;
using ZulipAPI.Messages;

namespace ZulipNUnit {
    public class MessageTests {

        ZulipClient zclient;
        MessageEndPoint messageEndpoint;

        [SetUp]
        public async Task Setup() {
            if (File.Exists(".zuliprc")) {
                zclient = ZulipServer.Login(".zuliprc");
                messageEndpoint = zclient.GetMessageEndPoint();
            }
        }

        [Test]
        public async Task GetMessages() {
            var allMessages = await messageEndpoint.GetMessages(120149363, 30, 30);
            var count = allMessages.Count;

            Assert.IsTrue(count > 0);
        }

        [Test]
        public async Task SendStreamMessage() {
            var id = await messageEndpoint.SendStreamMessage("Test Here", "API Test", DateTime.Now.ToLongDateString());

            Assert.IsTrue(id > 0);
        }

        [Test]
        public async Task SendPrivateMessage() {
            var id = await messageEndpoint.SendPrivateMessage(zclient.UserEmail, "Test " + DateTime.Now.ToLongTimeString());

            Assert.IsTrue(id > 0);
        }

    }
}
