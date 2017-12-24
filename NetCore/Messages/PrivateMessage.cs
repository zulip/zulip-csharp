using ZulipNetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ZulipNetCore {

    public class PrivateMessage : EndPointSendMessage {

        public PrivateMessage(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async void PostPrivateMessage(string RecipientEmail, string MessageText) {
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("type", "private"),
                new KeyValuePair<string, string>("to", RecipientEmail),
                new KeyValuePair<string, string>("content", MessageText)
            };
            await GetJsonAsStringAsync(FormData);
        }
    }
}
