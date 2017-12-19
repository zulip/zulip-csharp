using System.Threading.Tasks;
using System.Net.Http;

namespace ZulipNetCore {

    public abstract class EndPointBase {

        public ZulipClient _ZulipClient { get; set; }
        private HttpClient _HttpClient;

        public EndPointBase() {

        }

        public EndPointBase(ZulipClient ZulipClient) {
            this._ZulipClient = ZulipClient;
            this._HttpClient = ZulipClient.Login();
        }

        public async Task<string> GetJsonString(string EndPointPath) {
            // extra string variable not needed but useful for debugging
            string TargetURL = $"{_ZulipClient.Server.BaseAddress.AbsoluteUri}/{EndPointPath}";
            using (HttpResponseMessage Response = await _HttpClient.GetAsync(TargetURL))
            using (HttpContent content = Response.Content) {
                return await content.ReadAsStringAsync();
            }
        }
    }
}
