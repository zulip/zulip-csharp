using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZulipNetCore {

    public class Streams : EndPointBase {

        public StreamCollection StreamCollection { get; private set; }

        public Streams(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task GetStreamsAsync() {
            await GetJsonAsStringAsync(EndPointPath.Streams);
        }

        protected override void ParseResponse() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            ResponseMessage = JObj.msg;
            ResponseResult = JObj.result;
            ResponseArray = JObj.streams;

            StreamCollection = new StreamCollection();
            var result = JSONHelper.ParseJArray<Stream>(ResponseArray);
            if (result != null) {
                foreach (var stream in result) {
                    this.StreamCollection.Add(stream);
                }
            }
        }
    }
}
