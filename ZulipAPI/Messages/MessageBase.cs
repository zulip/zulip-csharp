using System;
using Newtonsoft.Json;

namespace ZulipAPI {

    public class MessageBase {

        [JsonProperty("flags")]
        public string[] Flags { get; set; }
        [JsonProperty("client")]
        public string Client { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("sender_id")]
        public int SenderID { get; set; }
        [JsonProperty("sender_short_name")]
        public string SenderShortName { get; set; }
        [JsonProperty("avatar_url")]
        public string AvartarURL { get; set; }
        [JsonProperty("edit_history")]
        public EditHistory[] EditHistory { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("timestamp")]
        public long TimeStampUnix { get; set; }
        public DateTime TimeStamp { get { return UnixEpoch.Epoch.AddSeconds(TimeStampUnix);  } }
        [JsonProperty("sender_realm_str")]
        public string SenderRealmStr { get; set; }
        [JsonProperty("recipient_id")]
        public uint RecipientID { get; set; }
        [JsonProperty("is_me_message")]
        public bool IsMeMessage { get; set; }
        [JsonProperty("sender_full_name")]
        public string SenderFullName { get; set; }
        [JsonProperty("reactions")]
        public Reaction[] Reactions { get; set; }
        [JsonProperty("id")]
        public ulong MessageID { get; set; }
        [JsonProperty("subject_links")]
        public string[] SubjectLinks { get; set; }
        [JsonProperty("subject")]
        public string Subject { get; set; }
        [JsonProperty("sender_email")]
        public string SenderEmail { get; set; }
        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        public override string ToString() {
            return $"{MessageID} {SenderEmail}";
        }

    }
}
