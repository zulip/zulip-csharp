using Newtonsoft.Json;

namespace ZulipAPI {
    public class Recipient {

        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        [JsonProperty("is_mirror_dummy")]
        public bool IsMirrorDummy { get; set; }
        [JsonProperty("id")]
        public uint ID { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }

    }
}
