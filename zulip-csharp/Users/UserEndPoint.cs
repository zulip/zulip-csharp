using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZulipAPI.BaseClasses;

namespace ZulipAPI.Users {
    public class UserEndPoint : APIEndPoint {
        internal ZulipClient zulipClient;
        public UserCollection Users { get; } = new UserCollection();

        internal UserEndPoint(ZulipClient zulipClient) : base(zulipClient.restClient) {
            this.zulipClient = zulipClient;
        }

        public async Task<IList<User>> GetUsers() {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Users}";
            var intermediateResponse = await Get<ResponseUsers>(route);
            Users.Clear();
            Users.AddRange(intermediateResponse.Members);
            return intermediateResponse.Members;
        }

        //public async Task<User> GetUserById(uint id) {
        //    var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Users}/{id}";
        //    var intermediateResponse = await Get<ResponseUsers>(route);
        //    return new User();
        //}

        /// <summary>
        /// Requires the user of the User(string, string, string, string) constructor.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task CreateUser(User user) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Users}";
            var formData = new List<KeyValuePair<string, object>>() {
                new KeyValuePair<string, object>("email", user.Email),
                new KeyValuePair<string, object>("password", user.Password),
                new KeyValuePair<string, object>("full_name", user.FullName),
                new KeyValuePair<string, object>("short_name", user.Shortname),
            };
            var intermediateResponse = await Post<ResponseBase>(route, formData);
        }

        public async Task EditUser(User user) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Users}/{user.UserID}";
            var formData = new List<KeyValuePair<string, object>>() {
                new KeyValuePair<string, object>("full_name", $"\"{user.FullName}\""),
                new KeyValuePair<string, object>("is_admin", user.IsAdmin.ToString().ToLower()),
                new KeyValuePair<string, object>("is_guest", user.IsGuest.ToString().ToLower()),
            };

            var intermediateResponse = await Patch<ResponseBase>(route, formData);
        }

        public async Task ReactivateUser(User user) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Users}/{user.UserID}/reactivate";
            var intermediateResponse = await Post<ResponseBase>(route, null);
        }

        public async Task ReactivateUser(uint userId) {
            await ReactivateUser(new User { UserID = userId });
        }

        public async Task DeactivateUser(User user) {
            var route = $"{zulipClient.ServerApiURL}/{EndPointPaths.Users}/{user.UserID}";
            //var formData = new List<KeyValuePair<string, object>>() {
            //    new KeyValuePair<string, object>("user_id", user.UserID),
            //};
            var intermediateResponse = await Delete<ResponseBase>(route, null);
        }

        public async Task DeactivateUser(uint userId) {
            await DeactivateUser(new User { UserID = userId });
        }

    }
}
