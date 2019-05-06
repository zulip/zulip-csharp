using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI.Streams {

    public class Stream {

        public bool IsAnnouncementOnly { get; set; }
        public uint StreamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RenderedDescription { get; set; }
        public bool InviteOnly { get; set; }
        public ulong FirstMessageID { get; set; }
        public bool HistoryPublicToSubscribers { get; set; }

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
