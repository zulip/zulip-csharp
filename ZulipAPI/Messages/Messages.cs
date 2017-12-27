using System.Threading.Tasks;

namespace ZulipAPI {

    public class Messages : EndPointBase {

        public PrivateMessage Private { get; set; }
        public StreamMessage Stream { get; set; }
        public MessageCollection MessageCollection { get; private set; }

        public Messages(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task GetMessagesAsync() {
            await GetJsonAsStringAsync(EndPointPath.Messages);
        }

        protected override void ParseResponse() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            ResponseMessage = JObj.msg;
            ResponseResult = JObj.result;
            ResponseArray = JObj.messages;

            MessageCollection = new MessageCollection();
            foreach (var msg in JSONHelper.ParseJArray<Message>(ResponseArray)) {
                this.MessageCollection.Add(msg);
            }
        }
    }
}
