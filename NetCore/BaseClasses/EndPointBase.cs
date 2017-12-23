using System.Threading.Tasks;
using System.Net.Http;

namespace ZulipNetCore {

    public abstract class EndPointBase {

        protected static HttpClient _HttpClient;
        protected static ZulipClient _ZulipClient;
        public string JsonOutput;
        virtual public string ResponseMessage { get; protected set; }
        virtual public string ResponseResult { get; protected set; }
        protected object ResponseArray;

        public EndPointBase() {

        }

        protected EndPointBase(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        protected virtual async Task GetJsonAsStringAsync(string EndPointPath) {
            string TargetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath}";
            using (HttpResponseMessage Response = await _HttpClient.GetAsync(TargetURL))
            using (HttpContent content = Response.Content) {
                JsonOutput = string.Copy(await content.ReadAsStringAsync());
            }
            ParseResponse();
        }

        abstract protected void ParseResponse();

    }
}
