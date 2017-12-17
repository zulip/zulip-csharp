
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZulipNetCore {

    public class Streams : EndPointBase {

        private static HttpClient _Client;
        private static ZulipClient _ZulipClient;
        public string JsonOutput;
        public StreamCollection StreamsCollection { get; set; }


        public Streams(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _Client = ZulipClient.httpClient;
        }

        public async Task<string> GetStreams() {
            JsonOutput  = await ConnectAsync(_Client, EndPointPath.Streams);
            return JsonOutput;
        }
    }
}
