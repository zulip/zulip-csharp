using ZulipNetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ZulipNetCore {

    public class PrivateMessage : IParseResponse {

        private static ZulipClient _ZulipClient;
        private static HttpClient _HttpClient;
        public string JsonOutput;
        public bool StatusCode;
        public string ResponseMessage { get; protected set; }
        public string ResponseResult { get; protected set; }
        public string ResponseID { get; protected set; }
        private object ResponseArray;

        public PrivateMessage(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async void PostPrivateMessage(string RecipientEmail, string MessageText) {
            //https://stackoverflow.com/questions/30858890/how-to-use-httpclient-to-post-with-authentication
            string targetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath.Messages}";
            var request = new HttpRequestMessage(HttpMethod.Post, targetURL);
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("type", "private"),
                new KeyValuePair<string, string>("to", RecipientEmail),
                new KeyValuePair<string, string>("content", MessageText)
            };

            request.Content = new FormUrlEncodedContent(FormData);
            using (HttpResponseMessage Response = await _HttpClient.SendAsync(request))
            using (HttpContent content = Response.Content) {
                JsonOutput = string.Copy(await Response.Content.ReadAsStringAsync());
                StatusCode = Response.IsSuccessStatusCode;
            }
            ParseResponse();
        }

        // example response
        /*{{
         "result": "success",
         "msg": "",
         "id": 120162326
          }}*/
        public void ParseResponse() {
            var Json = new JSONHelper();
            dynamic JObj = Json.ParseJSON(JsonOutput);
            ResponseMessage = JObj.msg;
            ResponseResult = JObj.result;
            ResponseID = JObj.id;
        }
    }
}
