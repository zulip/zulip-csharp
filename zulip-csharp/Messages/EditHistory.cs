using Newtonsoft.Json;
using System;

namespace ZulipAPI {
    public class EditHistory {

        [JsonProperty("user_id")]
        public uint UserID { get; set; }
        [JsonProperty("prev_rendered_content_version")]
        public uint PrevRenderedContentVersion { get; set; }
        [JsonProperty("timestamp")]
        public ulong TimeStampUnix { get; set; }
        public DateTime TimeStamp { get { return UnixEpoch.Epoch.AddSeconds(TimeStampUnix); } }
        [JsonProperty("prev_rendered_content")]
        public string PrevRenderedContent { get; set; }
        [JsonProperty("prev_content")]
        public string PrevContent { get; set; }

        public override string ToString() {
            return $"{PrevContent}"; 
        }

    }
}
