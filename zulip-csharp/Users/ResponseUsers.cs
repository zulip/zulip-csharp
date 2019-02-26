namespace ZulipAPI {

    public class ResponseUsers : ResponseBase {

        [Newtonsoft.Json.JsonProperty("members")]
        public object Members { get; set; }
        [Newtonsoft.Json.JsonProperty("code")]
        public object Code { get; set; }

    }
}
