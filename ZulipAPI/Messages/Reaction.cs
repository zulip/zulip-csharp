using Newtonsoft.Json;

namespace ZulipAPI {
    public class Reaction {

        [JsonProperty("user")]
        public User User { get; set; }
        [JsonProperty("reaction_type")]
        public string ReactionType { get; set; }
        [JsonProperty("emoji_name")]
        public string EmojiName { get; set; }
        [JsonProperty("emoji_code")]
        public string EmojiCode { get; set; }

        public override string ToString() {
            return $"";
        }

    }
}
