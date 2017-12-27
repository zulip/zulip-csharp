using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ZulipNetCore {

    public class Users : EndPointBase {

        public UserCollection UserCollection { get; set; }

        public Users(ZulipClient ZulipClient) {
            _ZulipClient = ZulipClient;
            _HttpClient = ZulipClient.Login();
        }

        public async Task GetUsersAsync() {
            await GetJsonAsStringAsync(EndPointPath.Users);
        }

        protected override void ParseResponse() {
            dynamic JObj = JSONHelper.ParseJSON(JsonOutput);
            ResponseMessage = JObj.msg;
            ResponseResult = JObj.result;
            ResponseArray = JObj.members;

            UserCollection = new UserCollection();
            var result = JSONHelper.ParseJArray<User>(ResponseArray);
            if (result != null) {
                foreach (var user in result) {
                    this.UserCollection.Add(user);
                }
            }
        }
    }
}
