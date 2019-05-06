using Newtonsoft.Json;

namespace ZulipAPI.Messages {
    public class DisplayRecipient {

        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        [JsonProperty("is_mirror_dummy")]
        public bool IsMirrorDummy { get; set; }
        public uint ID { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonIgnore]
        public string StreamName { get; set; }

        [JsonIgnore]
        public bool IsStreamRecipient => StreamName != null;
        [JsonIgnore]
        public bool IsPrivateRecipient => Email != null;

        public override string ToString() {
            if (IsStreamRecipient) {
                return StreamName;
            }
            return $"{FullName} {ID}";
        }
    }
}
