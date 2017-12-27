using System;

namespace ZulipAPI {

    public class ZulipServer {

        public string ServerBaseURL { get; }
        public ServerApiVersion ApiVersion { get; } = ZulipServer.ServerApiVersion.v1;
        public const string ApiPathV1 = "/api/v1";
        public string ServerApiURL { get; } = ApiPathV1;
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
