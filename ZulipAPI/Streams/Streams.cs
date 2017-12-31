using System.Threading.Tasks;

namespace ZulipAPI {

    public class Streams : EndPointBase {

        public StreamCollection StreamCollection { get; private set; }
        public ResponseStreams Response { get; private set; }
        
        public Streams(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task GetStreamsAsync() {
            await GetJsonAsStringAsync(EndPointPath.Streams);
        }

        protected override void ParseResponse() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            Response = JSONHelper.ParseJObject<ResponseStreams>(JObj);

            if (Response.Result == "success") {
                StreamCollection = new StreamCollection();
                var result = JSONHelper.ParseJArray<Stream>(Response.Streams);
                if (result != null) {
                    foreach (var stream in result) {
                        this.StreamCollection.Add(stream);
                    }
                }
            } else {
                throw new FailedCallException("The API call returned with an error.") { ZulipServerResponse = Response };
            }
        }
    }
}
