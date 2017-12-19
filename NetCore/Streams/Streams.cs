using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZulipNetCore {

    public class Streams {

        private static HttpClient _httpClient;
        private static ZulipClient _ZulipClient;
        public string JsonOutput;
        public string ResponseMessage { get; private set; }
        public string ResponseResult { get; private set; }
        public StreamCollection StreamsCollection { get; set; }

        public Streams(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _httpClient = ZulipClient.Login();
        }

        public async Task<List<Stream>> GetStreamsAsync() {
            await GetJsonAsStringAsync();
            var Json = new JSONHelper();
            dynamic JObj = Json.ParseJSON(JsonOutput);
            ResponseMessage = JObj.msg;
            ResponseResult = JObj.result;
            object Streams = JObj.streams;

            return Json.ParseJArray<Stream>(Streams);
        }

        public async Task GetJsonAsStringAsync() {
            // extra string variable not needed but useful for debugging
            string TargetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath.Streams}";
            using (HttpResponseMessage Response = await _httpClient.GetAsync(TargetURL))
            using (HttpContent content = Response.Content) {
                JsonOutput = string.Copy(await content.ReadAsStringAsync());
            }
        }

    }
}
