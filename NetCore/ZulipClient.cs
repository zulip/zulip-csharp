using System;
using System.Net.Http;
using System.Text;

namespace ZulipNetCore
{
    /// <summary>
    /// This class is the core of every other connection. It implements an HttpClient object and
    /// the intention is to reuse the httpClient static field.
    /// see https://stackoverflow.com/questions/40187153/httpclient-in-using-statement#40187267
    /// </summary>
    public class ZulipClient {

        public ZulipServer Server { get; set; }
        public ZulipAuthentication Authentication { get; set; }
        public static HttpClient httpClient;

        /// <summary>
        /// Requires two objects that together enable the API user authentication.
        /// </summary>
        /// <param name="Server"></param>
        /// <param name="UserLogin"></param>
        public ZulipClient(ZulipServer Server, ZulipAuthentication UserLogin) {
            this.Server = Server;
            this.Authentication = UserLogin;

            httpClient = Login(UserLogin.UserSecretIsPassword);
        }

        /// <summary>
        /// Supply the path to your zuliprc file containing email, key and site URL.
        /// </summary>
        /// <param name="ZulipRCPath"></param>
        public ZulipClient(string ZulipRCPath) {
            throw new Exception("feature not implemented yet");
            /* requires System.IO namespace
             * needs to be parsed with Json.NET
             * includes the server URL which needs to initialise the ZulipServer object
             */
        }

        /// <summary>
        /// Dev comment: this probably needs to work differently when the user supplies the password rather than the api key as user secret.
        /// </summary>
        /// <returns></returns>
        public HttpClient Login(bool UserSecretIsPassword = false) {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = Server.BaseAddress;
            if (UserSecretIsPassword) {
                throw new Exception("feature not yet implemented");
            } else {
                Authentication.SetAuthHeader(hc);
            }
            return hc;
        }
    }
}
