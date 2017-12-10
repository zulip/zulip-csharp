using System;
using System.Text;

namespace ZulipCSharp
{
    class ZulipClient {

        public ZulipServer Server { get; set; }
        public ZulipAuthentication Authentication { get; set; }

        public ZulipClient(ZulipServer Server, ZulipAuthentication UserLogin) {
            this.Server = Server;
            this.Authentication = UserLogin;
        }

    }


    class ZulipServer {

        public string ServerBaseURL { get; private set; }
        public ServerApiVersion ApiVersion { get; private set; } = ZulipServer.ServerApiVersion.v1;
        public const string ApiPathV1 = "/api/v1";
        public string ApiURL { get; private set; } = ApiPathV1;

        /// <summary>
        /// Specify the Zulip server ie. zulip.example.org
        /// </summary>
        /// <param name="ServerBaseURL"></param>
        /// <param name="ApiVersion">Optional parameter in case there are v2 or higher in the future.</param>
        public ZulipServer(string ServerBaseURL, ServerApiVersion ApiVersion = ServerApiVersion.v1) {
            this.ServerBaseURL = TidyUpURL(ServerBaseURL);

            switch (ApiVersion) {
                case ServerApiVersion.v1:
                    this.ApiURL = ApiPathV1;
                    break;
            }

            this.ApiVersion = ApiVersion;
        }

        private string TidyUpURL(string ServerURL) {

            string Result = ServerURL.StartsWith("https://") ? ServerURL : "https://" + ServerURL;
            Result = Result.EndsWith("/") ? Result.Remove(Result.LastIndexOf('/')) : Result;

            return Result;
        }

        // can be removed again if another version is years away
        public enum ServerApiVersion {
            v1
        }
        
    }

    class ZulipAuthentication {

        public string UserEmail { get; private set; }
        public string ApiKey { get; private set; }
        private string _Base64Authorisation;

        public ZulipAuthentication(string UserEmail, string ApiKey) {
            this.UserEmail = UserEmail;
            this.ApiKey = ApiKey;
            _Base64Authorisation = GetAuthorisationString(UserEmail, ApiKey);
        }

        private string GetAuthorisationString(string Username, string Password) {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(Username + ':' + Password));
        }

    }


}
