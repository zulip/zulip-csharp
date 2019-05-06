
using System.Collections;
using System.Collections.Generic;

namespace ZulipAPI.Messages {
    public class ResponseMessages : ResponseBase {

        public IList<MessageBase> Messages { get; set; }
        public bool HistoryLimited { get; set; }
        public bool FoundAnchor { get; set; }
        public bool FoundOldest { get; set; }
        public ulong Anchor { get; set; }
        public bool FoundNewest { get; set; }
        

    }
}
