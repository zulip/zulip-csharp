using System;
using System.Net.Http;
using System.Text;

namespace ZulipNetCore
{
    public class ZulipClient {

        public ZulipServer Server { get; set; }
        public ZulipAuthentication Authentication { get; set; }
        public static HttpClient httpClient;

        public Users Users { get { return new Users(this); } }
        public Messages Messages { get { return new Messages(this); } }
        public Streams Streams { get { return new Streams(this); } }


        public ZulipClient(ZulipServer Server, ZulipAuthentication UserLogin) {
            this.Server = Server;
            this.Authentication = UserLogin;
        }

        public void Login() {
            httpClient = new HttpClient();
            httpClient.BaseAddress = Server.BaseAddress;
            Authentication.SetAuthHeader(httpClient);
        }

    }


    public class ZulipServer {

        public string ServerBaseURL { get; private set; }
        public ServerApiVersion ApiVersion { get; private set; } = ZulipServer.ServerApiVersion.v1;
        public const string ApiPathV1 = "/api/v1";
        public string ApiURL { get; private set; } = ApiPathV1;
        public Uri BaseAddress { get; set; }

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
            this.BaseAddress = new Uri(this.ServerBaseURL);
        }

        /// <summary>
        /// Checks whether the URL includes https:// or not and adds it if necessary. Also removes any trailing slash.
        /// </summary>
        /// <param name="ServerURL"></param>
        /// <returns></returns>
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

    public class ZulipAuthentication {

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

        /// <summary>
        /// Requires valid credentials (username, apikey) pasted in the contrustor. Set the AuthenticationHeaderValue of the HttpClient.
        /// </summary>
        /// <param name="HttpClient"></param>
        public void SetAuthHeader(HttpClient HttpClient) {
            HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", _Base64Authorisation);
        }
    }
}
