using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {

    public class ResponseUsers : ResponseBase {

        [Newtonsoft.Json.JsonProperty("members")]
        public object Members { get; set; }

    }
}
