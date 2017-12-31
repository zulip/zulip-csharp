using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;

namespace ZulipAPI {

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
            ParseResponseGet();
        }

        protected virtual async Task PostJsonAsStringAsync(string EndPointPath, List<KeyValuePair<string, string>> FormData) {
            string TargetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath}";
            var request = new HttpRequestMessage(HttpMethod.Post, TargetURL);
            request.Content = new FormUrlEncodedContent(FormData);

            using (HttpResponseMessage Response = await _HttpClient.SendAsync(request))
            using (HttpContent content = Response.Content) {
                JsonOutput = string.Copy(await content.ReadAsStringAsync());
            }
            ParseResponsePost();
        }

        abstract protected void ParseResponseGet();
        abstract protected void ParseResponsePost();

    }
}
