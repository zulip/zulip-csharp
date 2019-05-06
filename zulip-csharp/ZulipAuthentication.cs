using System;
using System.Net.Http;
using System.Text;

namespace ZulipAPI {

    public class ZulipAuthentication {

        public string UserEmail { get; }
        public string Password { get; }

        private string _apiKey;
        public string ApiKey {
            get => _apiKey;
            set {
                _apiKey = value;
                _Base64Authorisation = GetAuthorisationString(UserEmail, _apiKey);
            }
        }

        public bool UserSecretIsPassword { get; }
        private string _Base64Authorisation;

        /// <summary>
        /// Supply the user name (email address) and user secret. By default the constructor will expect the api key.
        /// Alternatively you can supply the password in order to fetch the api key automatically. In that case it is
        /// required to set the optional bool accordingly.
        /// </summary>
        /// <param name="UserEmail"></param>
        /// <param name="UserSecret">by default the api key but optionally the user password</param>
        /// <param name="UserSecretIsPassword"></param>
        public ZulipAuthentication(string UserEmail, string UserSecret, bool UserSecretIsPassword = false) {
            this.UserEmail = UserEmail;
            this.UserSecretIsPassword = UserSecretIsPassword;
            if (UserSecretIsPassword) {
                this.Password = UserSecret;
            } else {
                this.ApiKey = UserSecret;
            }
            _Base64Authorisation = GetAuthorisationString(UserEmail, UserSecret);
        }

        private string GetAuthorisationString(string Username, string ApiKey) {
            return $"{Username}:{ApiKey}".ToUTF8Base64();
        }

        /// <summary>
        /// Requires valid credentials (username, apikey) pasted in the contructor. Set the AuthenticationHeaderValue of the HttpClient.
        /// </summary>
        /// <param name="HttpClient"></param>
        public void SetAuthHeader(HttpClient HttpClient) {
            HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", _Base64Authorisation);
        }
    }
}
