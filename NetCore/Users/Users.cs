using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipNetCore {

    public class Users : EndPointBase {

        private static HttpClient _HttpClient;
        private ZulipClient _ZulipClient;

        public Users(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
        }

    }
}
