using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZulipAPI {

    public class StreamMessage : EndPointSendMessage {

        [Newtonsoft.Json.JsonProperty("display_recipient")]
        public string DisplayRecipient { get; set; }

        public StreamMessage() {

        }

        public StreamMessage(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task PostStreamMessage(string StreamName, string Topic, string MessageText) {
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
