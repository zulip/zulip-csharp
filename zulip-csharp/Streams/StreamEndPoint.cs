using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZulipAPI.BaseClasses;

namespace ZulipAPI.Streams {
    public class StreamEndPoint : APIEndPoint {
        internal ZulipClient zulipClient;
        public StreamCollection Streams { get; } = new StreamCollection();
        internal StreamEndPoint(ZulipClient zulipClient) : base(zulipClient.restClient) {
            this.zulipClient = zulipClient;
        }

        public async Task<IList<Stream>> GetStreams() {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Streams}";
            var intermediateResponse = await Get<ResponseStreams>(route);
            Streams.Clear();
            Streams.AddRange(intermediateResponse.Streams);
            return intermediateResponse.Streams;
        }
    }
}
