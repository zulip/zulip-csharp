using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ZulipAPI {

    public class Users : EndPointBase {

        public UserCollection UserCollection { get; set; }
        public ResponseUsers Response { get; set; }

        public Users(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task GetUsersAsync() {
            await GetJsonAsStringAsync(EndPointPath.Users);
        }

        public async Task CreateUserAsync(string UserEmail, string FullName, string Password, string ShortName) {
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("email", UserEmail),
                new KeyValuePair<string, string>("password", Password),
                new KeyValuePair<string, string>("full_name", FullName),
                new KeyValuePair<string, string>("short_name", ShortName)
            };
            await PostJsonAsStringAsync(EndPointPath.Users, FormData);
        }

        public async Task DeactivateUserAsync(string UserEmail) {
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("email", UserEmail)
            };
            await DeleteJsonAsStringAsync(EndPointPath.Users, FormData);
        }

        public async Task ReactivateUserAsync(string UserEmail) {
            var FormData = new List<KeyValuePair<string, string>>() {
                new KeyValuePair<string, string>("email", UserEmail)
            };
            await PostJsonAsStringAsync(EndPointPath.Users, FormData);
        }

        protected override void ParseResponsePost() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            Response = JSONHelper.ParseJObject<ResponseUsers>(JObj);

            if (Response.Result == "success") {

            } else {
                throw new FailedCallException(Response);
            }
        }

        protected override void ParseResponseGet() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            Response = JSONHelper.ParseJObject<ResponseUsers>(JObj);

            if (Response.Result == "success") {
                UserCollection = new UserCollection();
                var result = JSONHelper.ParseJArray<User>(Response.Members);
                if (result != null) {
                    foreach (var user in result) {
                        this.UserCollection.Add(user);
                    }
                }
            } else {
                throw new FailedCallException(Response);
            }
        }

        protected override void ParseResponseDelete() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            Response = JSONHelper.ParseJObject<ResponseUsers>(JObj);

            if (Response.Result == "success") {

            } else {
                throw new FailedCallException(Response);
            }
        }
    }
}
