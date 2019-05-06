using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI {
    public class ZulipClient {

        internal RestClient restClient;
        public string ServerApiURL { get; internal set; }

        public ZulipClient(string userEmail, string apiKey) {
            UserEmail = userEmail;
            APIKey = apiKey;
            restClient = new RestClient();
            restClient.Authenticator = new HttpBasicAuthenticator(UserEmail,
                                                                  APIKey);
        }

        public string UserEmail { get; }
        public string APIKey { get; }

        public Users.UserEndPoint GetUserEndPoint() {
            return new Users.UserEndPoint(this);
        }

        public Streams.StreamEndPoint GetStreamEndPoint() {
            return new Streams.StreamEndPoint(this);
        }

        public Messages.MessageEndPoint GetMessageEndPoint() {
            return new Messages.MessageEndPoint(this);
        }


    }
}
