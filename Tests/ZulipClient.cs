using Xunit;
using System;
using ZulipNetCore;

namespace ZulipAPITests.Serverless
{

    public class ConstructorTests {

        public static ZulipAuthentication Auth { get; set; }
        public static ZulipServer Server { get; set; }

        [Fact]
        [Trait("Category", "ClientTests")]
        public void SetUp() {
            Auth = new ZulipAuthentication("email", "api_token");
            Server = new ZulipServer("https://localhost:9991");
        }

        [Fact]
        [Trait("Category", "ClientTests")]
        public void BasicTest() {
            ZulipClient Client = new ZulipClient(Server, Auth);
        }

        [Fact]
        [Trait("Category", "ClientTests")]
        public void TestZulipRCPath() {
            Assert.Throws<Exception>(() => {
                ZulipClient client = new ZulipClient("RCPath");
            });
        }

    }
}
