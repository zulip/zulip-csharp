using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipNetCore {

    public class Stream {

        public uint StreamID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool InviteOnly { get; set; }

        public Stream() {

        }

        public Stream(uint StreamID, string Name, string Description, bool InviteOnly) {
            this.StreamID = StreamID;
            this.Name = Name;
            this.Description = Description;
            this.InviteOnly = InviteOnly;
        }

    }
}
