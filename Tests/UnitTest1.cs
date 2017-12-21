using Xunit;
using System;
using ZulipNetCore;

namespace ZulipAPITests
{

    public class ConstructorTests {

        [Fact]
        [Trait("Category", "Serverless")]
        [Trait("Category", "ConstructorTests")]
        public void NoZulipAuth() {
            Console.WriteLine("NoZulipAuth");
        }

    }
}
