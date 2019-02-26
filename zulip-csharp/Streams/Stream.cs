using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {

    public class Stream {

        [JsonProperty("stream_id")]
        public uint StreamID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("invite_only")]
        public bool InviteOnly { get; set; }

        public Stream() {

        }

        public Stream(uint StreamID, string Name, string Description, bool InviteOnly) {
            this.StreamID = StreamID;
            this.Name = Name;
            this.Description = Description;
            this.InviteOnly = InviteOnly;
        }

        public override string ToString() {
            return $"{StreamID} {Name}";
        }

    }
}
