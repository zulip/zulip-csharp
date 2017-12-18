using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZulipNetCore {

    public class Streams {

        private static HttpClient _httpClient;
        private static ZulipClient _ZulipClient;
        public string JsonOutput;
        public StreamCollection StreamsCollection { get; set; }

        public Streams(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _httpClient = ZulipClient.httpClient;
        }

        public async Task<List<Stream>> GetStreamsAsync() {
            await GetJsonAsStringAsync();
            // continue with JsonOutput
            return null;
        }

        private async Task GetJsonAsStringAsync() {
            // extra string variable not needed but useful for debugging
            string TargetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath.Streams}";
            using (HttpResponseMessage Response = await _httpClient.GetAsync(TargetURL))
            using (HttpContent content = Response.Content) {
                JsonOutput = await content.ReadAsStringAsync();
            }
        }

    }
}
