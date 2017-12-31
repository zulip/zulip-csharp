namespace ZulipAPI {

    public class ResponseUsers : ResponseBase {

        [Newtonsoft.Json.JsonProperty("members")]
        public object Members { get; set; }

    }
}
