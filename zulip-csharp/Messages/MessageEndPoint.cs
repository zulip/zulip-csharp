using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ZulipAPI.BaseClasses;

namespace ZulipAPI.Messages {
    public class MessageEndPoint : APIEndPoint {

        internal ZulipClient zulipClient;
        public MessageCollection Messages { get; } = new MessageCollection();

        internal MessageEndPoint(ZulipClient zulipClient) : base(zulipClient.restClient) {
            this.zulipClient = zulipClient;
        }

        public async Task<IList<MessageBase>> GetMessages(ulong anchor,
                                                          int msgBefore,
                                                          int msgAfter,
                                                          bool useFirstUnreadAnchor = false,
                                                          bool clientGravatar = true,
                                                          bool applyMarkdown = true) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Messages}";
            var Parameters = new List<KeyValuePair<string, object>>() {
                new KeyValuePair<string, object>("anchor", anchor),
                new KeyValuePair<string, object>("num_before", msgBefore),
                new KeyValuePair<string, object>("num_after", msgAfter),
                new KeyValuePair<string, object>("client_gravatar",  clientGravatar.ToString().ToLower()),
                new KeyValuePair<string, object>("apply_markdown", applyMarkdown.ToString().ToLower()),
                new KeyValuePair<string, object>("use_first_unread_anchor", useFirstUnreadAnchor.ToString().ToLower()),
            };
            var intermediateResponse = await Get<ResponseMessages>(route, Parameters);
            Messages.Clear();
            Messages.AddRange(ConvertRecipients(intermediateResponse.Messages));
            return Messages.Items;
        }

        public async Task<ulong> SendStreamMessage(string streamName, string topic, string msgText) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Messages}";
            var formData = new List<KeyValuePair<string, object>>() {
                                new KeyValuePair<string, object>("type", "stream"),
                                new KeyValuePair<string, object>("to", streamName),
                                new KeyValuePair<string, object>("subject", topic),
                                new KeyValuePair<string, object>("content", msgText)
                            };
            var intermediateResponse = await Post<ResponseSentMessage>(route, formData);
            return intermediateResponse.Id;
        }

        public async Task<ulong> SendPrivateMessage(string recipientEmail, string messageText) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Messages}";
            var formData = new List<KeyValuePair<string, object>>() {
                                new KeyValuePair<string, object>("type", "private"),
                                new KeyValuePair<string, object>("to", recipientEmail),
                                new KeyValuePair<string, object>("content", messageText)
                            };
            var intermediateResponse = await Post<ResponseSentMessage>(route, formData);
            return intermediateResponse.Id;
        }

        private IEnumerable<MessageBase> ConvertRecipients(IList<MessageBase> msgs) {
            foreach (var msg in msgs) {
                var json = JsonConvert.SerializeObject(msg.Recipient);
                try {
                    if (json.Contains("{")) {
                        msg.DisplayRecipient = JsonConvert.DeserializeObject<DisplayRecipient[]>(json);
                    } else {
                        msg.DisplayRecipient = new DisplayRecipient[] { new DisplayRecipient() { StreamName = json.Replace("\"", "") } };
                    }
                } catch {
                    msg.DisplayRecipient = new DisplayRecipient[] { new DisplayRecipient() { StreamName = json.Replace("\"", "") } };
                }
                yield return msg;
            }
        }
    }
}
