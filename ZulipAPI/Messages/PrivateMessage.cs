using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZulipAPI {

    public class PrivateMessage : EndPointSendMessage {

        [Newtonsoft.Json.JsonProperty("display_recipient")]
        public Recipient[] DisplayRecipient { get; set; }

        public PrivateMessage() {

        }

        public PrivateMessage(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task PostPrivateMessage(string RecipientEmail, string MessageText) {
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("type", "private"),
                new KeyValuePair<string, string>("to", RecipientEmail),
                new KeyValuePair<string, string>("content", MessageText)
            };
            await GetJsonAsStringAsync(FormData);
        }
    }
}
