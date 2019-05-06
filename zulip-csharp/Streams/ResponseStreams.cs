using System.Collections;
using System.Collections.Generic;

namespace ZulipAPI.Streams {
    public class ResponseStreams : ResponseBase {

        public IList<Stream> Streams { get; set; }

    }
}
