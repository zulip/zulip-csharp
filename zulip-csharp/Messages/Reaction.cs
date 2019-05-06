using Newtonsoft.Json;

namespace ZulipAPI.Messages {
    public class Reaction {

        public User User { get; set; }
        public string ReactionType { get; set; }
        public string EmojiName { get; set; }
        public string EmojiCode { get; set; }

        public override string ToString() {
            return $"{User?.UserID} {EmojiName}";
        }

    }
}
