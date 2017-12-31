using Newtonsoft.Json;

namespace ZulipAPI {
    public class ResponseBase {

        [JsonProperty("msg")]
        public string Msg { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }

    }
}
