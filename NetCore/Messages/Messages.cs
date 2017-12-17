using System.Net.Http;

namespace ZulipNetCore {

    public class Messages {

        private static HttpClient _HttpClient;
        private static ZulipClient _ZulipClient;
        public string JsonOutput;

        public PrivateMessage Private { get; set; }
        public StreamMessage Stream { get; set; }

        public Messages(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
        }



    }
}
