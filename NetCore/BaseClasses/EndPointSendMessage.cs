using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZulipNetCore {

    public abstract class EndPointSendMessage {

        protected static HttpClient _HttpClient;
        protected static ZulipClient _ZulipClient;
        public string JsonOutput;
        public bool StatusCode;
        virtual public string ResponseMessage { get; protected set; }
        virtual public string ResponseResult { get; protected set; }
        virtual public string ResponseID { get; protected set; }

        public EndPointSendMessage() {

        }

        public EndPointSendMessage(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

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
