using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ZulipNetCore {

    public class PrivateMessage {

        private ZulipClient ZulipClient;

        public PrivateMessage() {
            
        }

        public async void PostPrivateMessage(string RecipientEmail, string MessageText) {
            //_HttpClient = new HttpClient();
            //_HttpClient.BaseAddress = Server.BaseAddress;
            //Authentication.SetAuthHeader(_HttpClient);

            ////https://stackoverflow.com/questions/30858890/how-to-use-httpclient-to-post-with-authentication
            //string targetURL = $"/{EndPointPath.Messages}";
            //var request = new HttpRequestMessage(HttpMethod.Post, Server.BaseAddress.AbsoluteUri + targetURL);
            //var FormData = new List<KeyValuePair<string, string>>() {
            //    new KeyValuePair<string, string>("type", "private"),
            //    new KeyValuePair<string, string>("to", RecipientEmail),
            //    new KeyValuePair<string, string>("content", MessageText)
            //};

            //request.Content = new FormUrlEncodedContent(FormData);
            //using (HttpResponseMessage Response = await _HttpClient.SendAsync(request))
            //using (HttpContent content = Response.Content) {
            //    this.ContentResponse = await Response.Content.ReadAsStringAsync() + Response.IsSuccessStatusCode;
            //}
        }


    }
}
