using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace ZulipAPI.Messages {

    public class MessageBase {

        public ulong Id { get; set; }
        public string Subject { get; set; }
        public string[] Flags { get; set; }
        public string Client { get; set; }
        public string Content { get; set; }
        public int SenderID { get; set; }
        public string SenderShortName { get; set; }
        public string AvartarURL { get; set; }
        public EditHistory[] EditHistory { get; set; }
        public string Type { get; set; }

        public  ulong TimeStamp { get; set; }
        public DateTime TimeStampUnix { get { return UnixEpoch.Epoch.AddSeconds(TimeStamp);  } }
        public string SenderRealmStr { get; set; }
        public uint RecipientID { get; set; }
        public bool IsMeMessage { get; set; }
        public string SenderFullName { get; set; }
        public Reaction[] Reactions { get; set; }
        public string[] SubjectLinks { get; set; }
        public string SenderEmail { get; set; }
        public string ContentType { get; set; }
        [JsonProperty("display_recipient")]
        internal object Recipient { get; set; }
        [JsonIgnore]
        //[JsonConverter(typeof(DisplayRecipientJsonConverter))]
        public DisplayRecipient[] DisplayRecipient { get; set; }

        public override string ToString() {
            return $"{Id} {SenderEmail} {Subject}";
        }

    }
}
