using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {
    public class ResponseMessages : ResponseBase {

        [Newtonsoft.Json.JsonProperty("messages")]
        public object Messages { get; set; }

    }
}
