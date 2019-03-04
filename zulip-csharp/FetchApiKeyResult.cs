using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {
    public class FetchApiKeyResult : ApiResult {
        [JsonProperty("api_key")]
        public string ApiKey { get; set; }
        public string Email { get; set; }
    }
}
