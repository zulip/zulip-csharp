using Newtonsoft.Json;

namespace ZulipAPI {

    public class User {

        [JsonProperty("user_id")]
        public uint UserID { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("is_admin")]
        public bool IsAdmin { get; set; }
        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarURL { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
        [JsonProperty("bot_type")]
        public int? BotType { get; set; }
        [JsonProperty("is_guest")]
        public bool IsGuest { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("bot_owner")]
        public string BotOwner { get; set; }

        public User() {

        }

        //public User(uint StreamID, string Name, string Description, bool InviteOnly) {
        //    this.StreamID = StreamID;
        //    this.Name = Name;
        //    this.Description = Description;
        //    this.InviteOnly = InviteOnly;
        //}

        public override string ToString() {
            return $"{UserID} {FullName}";
        }

    }
}
