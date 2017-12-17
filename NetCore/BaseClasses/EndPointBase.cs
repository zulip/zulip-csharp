using System.Threading.Tasks;
using System.Net.Http;

namespace ZulipNetCore {

    public abstract class EndPointBase {

        private static HttpClient _HttpClient;
        public ZulipClient ZulipClient { get; set; }

        public EndPointBase() {

        }

        public EndPointBase(ZulipClient ZulipClient) {
            this.ZulipClient = ZulipClient;
        }

        public async Task<string> ConnectAsync(HttpClient _HttpClient, string EndPointPath) {
            // extra string variable not needed but useful for debugging
            string TargetURL = $"{ZulipClient.Server.BaseAddress.AbsoluteUri}/{EndPointPath}";
            using (HttpResponseMessage Response = await _HttpClient.GetAsync(TargetURL))
            using (HttpContent content = Response.Content) {
                return await content.ReadAsStringAsync();
            }
        }
    }
}
