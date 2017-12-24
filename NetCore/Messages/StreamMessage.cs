using System.Collections.Generic;
using System.Net.Http;
using ZulipNetCore.Interfaces;

namespace ZulipNetCore {

    public class StreamMessage : EndPointSendMessage {

        public StreamMessage(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async void PostStreamMessage(string StreamName, string Topic, string MessageText) {
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("type", "stream"),
                new KeyValuePair<string, string>("to", StreamName),
                new KeyValuePair<string, string>("subject", Topic),
                new KeyValuePair<string, string>("content", MessageText)
            };
            await GetJsonAsStringAsync(FormData);
        }
    }
}
