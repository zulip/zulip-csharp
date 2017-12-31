
namespace ZulipAPI {
    public class ResponseMessages : ResponseBase {

        [Newtonsoft.Json.JsonProperty("messages")]
        public object Messages { get; set; }

    }
}
