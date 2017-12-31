using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZulipAPI {

    public abstract class EndPointSendMessage : MessageBase {

        protected static HttpClient _HttpClient;
        protected static ZulipClient _ZulipClient;
        public string JsonOutput;
        public bool StatusCode;
        public string ResponseMessage;
        public string ResponseResult;
        public string ResponseID;

        protected virtual async Task GetJsonAsStringAsync(List<KeyValuePair<string, string>> FormData) {
            string TargetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath.Messages}";
            var request = new HttpRequestMessage(HttpMethod.Post, TargetURL);
            request.Content = new FormUrlEncodedContent(FormData);

            using (HttpResponseMessage Response = await _HttpClient.SendAsync(request))
            using (HttpContent content = Response.Content) {
                JsonOutput = string.Copy(await content.ReadAsStringAsync());
            }
            ParseResponse();
        }

        protected virtual void ParseResponse() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            ResponseMessage = JObj.msg;
            ResponseResult = JObj.result;
            ResponseID = JObj.id;
        }

    }
}
