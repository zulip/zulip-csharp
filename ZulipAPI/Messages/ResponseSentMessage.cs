using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {
    public class ResponseSentMessage : ResponseBase {

        [Newtonsoft.Json.JsonProperty("id")]
        public object ID { get; set; }

    }
}
