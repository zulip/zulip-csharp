namespace ZulipAPI {
    public class ResponseStreams : ResponseBase {

        [Newtonsoft.Json.JsonProperty("streams")]
        public object Streams { get; set; }

    }
}
