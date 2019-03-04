using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZulipAPI
{
    /// <summary>
    /// This class is the core of every other connection. It implements an HttpClient object and
    /// the intention is to reuse the httpClient static field.
    /// see https://stackoverflow.com/questions/40187153/httpclient-in-using-statement#40187267
    /// </summary>
    public class ZulipClient {

        public ZulipServer Server { get; set; }
        public ZulipAuthentication Authentication { get; set; }

        public ZulipClient(string serverUrl, string userEmail, string password) {
            Server = new ZulipServer(serverUrl);
            Authentication = new ZulipAuthentication(userEmail, password, true);
        }

        /// <summary>
        /// Requires two objects that together enable the API user authentication.
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="ZulipAuth"></param>
        public ZulipClient(ZulipServer Server, ZulipAuthentication ZulipAuth) {
            this.Server = Server;
            this.Authentication = ZulipAuth;
        }

        /// <summary>
        /// Supply the path to your zuliprc file containing email, key and site URL.
        /// </summary>
        /// <param name="ZulipRCPath"></param>
        public ZulipClient(string ZulipRCPath) {
            var AuthHelper = new ZulipRCAuth(ZulipRCPath);
            this.Server = AuthHelper.Server;
            this.Authentication = AuthHelper.ZulipAuth;
        }

        public HttpClient Login() {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = Server.BaseAddress;
            if (Authentication.UserSecretIsPassword) {
                var parameters = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("username", Authentication.UserEmail),
                new KeyValuePair<string, string>("password", Authentication.Password)
                };
                var request = new HttpRequestMessage(HttpMethod.Post, $"{Server.ServerApiURL}/fetch_api_key");
                request.Content = new FormUrlEncodedContent(parameters);

                using (HttpResponseMessage response = hc.SendAsync(request).Result) {
                    using (var content = response.Content) {
                        var jsonAnswer = content.ReadAsStringAsync().Result;
                        var apiKey = JSONHelper.Parse<FetchApiKeyResult>(jsonAnswer);
                        if (apiKey.Result == "success") {
                            Authentication.ApiKey = string.Copy(apiKey.ApiKey);
                            Authentication.SetAuthHeader(hc);
                        }
                    }
                }

            } else {
                Authentication.SetAuthHeader(hc);
            }
            return hc;
        }
    }
}
