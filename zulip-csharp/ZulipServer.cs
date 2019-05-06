using RestSharp;
using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ZulipAPI {

    public class ZulipServer {

        public string ServerBaseURL { get; }
        public ServerApiVersion ApiVersion { get; } = ZulipServer.ServerApiVersion.v1;
        internal const string ApiPathV1 = "/api/v1";
        public string ServerApiURL { get; }
        public Uri BaseAddress { get; }

        /// <summary>
        /// Specify the Zulip server ie. zulip.example.org
        /// </summary>
        /// <param name="ServerBaseURL"></param>
        /// <param name="ApiVersion">Optional parameter in case there are v2 or higher in the future.</param>
        public ZulipServer(string ServerBaseURL, ServerApiVersion ApiVersion = ServerApiVersion.v1) {
            this.ServerBaseURL = TidyUpURL(ServerBaseURL);

            switch (ApiVersion) {
                case ServerApiVersion.v1:
                    this.ServerApiURL = this.ServerBaseURL + ApiPathV1;
                    break;
            }

            this.ApiVersion = ApiVersion;
            this.BaseAddress = new Uri(this.ServerBaseURL);
        }

        public async Task<ZulipClient> LoginAsync(string userEmail, string password) {
            var RestClient = new RestClient(ServerApiURL);
            var apiKey = "";
            if (!string.IsNullOrEmpty(userEmail) && !string.IsNullOrEmpty(password)) {
                var request = new RestRequest("fetch_api_key", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("username", userEmail);
                request.AddParameter("password", password);
                IRestResponse<FetchApiKeyResult> response = await RestClient.ExecutePostTaskAsync<FetchApiKeyResult>(request);
                apiKey = response.Data?.ApiKey;
            }
            return new ZulipClient(userEmail, apiKey) {
                ServerApiURL = ServerApiURL,
            };
        }

        public static ZulipClient Login(string pathZulipRCFile) {
            var zrc = new ZulipRCAuth(pathZulipRCFile);

            return new ZulipClient(zrc.Username, zrc.UserSecret) {
                ServerApiURL = new ZulipServer(zrc.ServerURL).ServerApiURL,
            };
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

        // can be removed again if another API version is years away
        public enum ServerApiVersion {
            v1
        }
    }
}
