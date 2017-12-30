using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZulipAPI {

    public class Messages : EndPointBase {

        public PrivateMessage Private { get; set; }
        public StreamMessage Stream { get; set; }
        public MessageCollection MessageCollection { get; private set; }
        public ResponseMessages Response { get; private set; }

        public Messages(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task GetMessagesAsync(long Anchor = 9999999999999999,
                                           long NumBefore = 9999999999999999,
                                           long NumAfter = 1/*,
                                           string Narrow = null,
                                           bool UseFirstUnreadAnchor = false,
                                           bool client_gravatar,
                                           bool apply_markdown*/) {
            var Parameters = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("anchor", Anchor.ToString()),
                new KeyValuePair<string, string>("num_before", NumBefore.ToString()),
                new KeyValuePair<string, string>("num_after", NumAfter.ToString())/*,
                new KeyValuePair<string, string>("narrow", Narrow),
                new KeyValuePair<string, string>("use_first_unread_anchor", UseFirstUnreadAnchor.ToString()),
                new KeyValuePair<string, string>("client_gravatar", ClientGravatar.ToString()),
                new KeyValuePair<string, string>("apply_markdown", ApplyMarkdown.ToString()),*/
            };

            //https://github.com/zulip/zulip/blob/185fd99816eba15cb714b4c3a3f111cc40fde63f/zerver/views/messages.py#L558

            await GetJsonAsStringAsync(Parameters);
        }

        protected async Task GetJsonAsStringAsync(List<KeyValuePair<string, string>> Parameters) {
            string TargetURL = $"{_ZulipClient.Server.ServerApiURL}/{EndPointPath.Messages}";

            using (HttpResponseMessage Response = await _HttpClient.GetAsync(TargetURL + Parameters.AsQueryString()))
            using (HttpContent content = Response.Content) {
                JsonOutput = string.Copy(await content.ReadAsStringAsync());
            }
            ParseResponse();
        }

        protected override void ParseResponse() {
            object JObj = JSONHelper.ParseJSON(JsonOutput);
            Response = JSONHelper.ParseJObject<ResponseMessages>(JObj);

            if (Response.Result == "success") {
                List<object> lst = JSONHelper.ParseJArray<object>(Response.Messages);

                MessageCollection = new MessageCollection();
                foreach (dynamic msg in lst) {
                    if (msg.type == "stream") {
                        var sm = JSONHelper.ParseJObject<StreamMessage>(msg);
                        MessageCollection.Add(sm);
                    } else if (msg.type == "private") {
                        var pm = JSONHelper.ParseJObject<PrivateMessage>(msg);
                        MessageCollection.Add(pm);
                    }
                }
            } else {
                throw new FailedCallException("The API call returned with an error.") { ZulipServerResponse = Response };
            }

            
        }
    }
}
