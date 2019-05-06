using Newtonsoft.Json;
using System;

namespace ZulipAPI.Messages {
    public class EditHistory {

        public uint UserID { get; set; }
        public string PrevRenderedContent { get; set; }
        public uint PrevRenderedContentVersion { get; set; }
        public DateTime TimeStampUnix { get { return UnixEpoch.Epoch.AddSeconds(TimeStamp); } }
        public ulong TimeStamp { get; set; }
        public string PrevContent { get; set; }

        public override string ToString() {
            return $"{PrevContent}";
        }

    }
}
