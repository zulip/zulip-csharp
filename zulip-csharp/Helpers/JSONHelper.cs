using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZulipAPI {

    public static class JSONHelper {

        public static JObject ParseJSON(string JsonResponse) {
            return JObject.Parse(JsonResponse);
        }

        public static List<T> ParseJArray<T>(object JSONArray) {
            JArray JArr = (JArray)JSONArray;

            return JsonConvert.DeserializeObject<List<T>>(JArr.ToString());
        }

        public static T ParseJObject<T>(object JSONObject) {
            JObject JObj = (JObject)JSONObject;
            return JsonConvert.DeserializeObject<T>(JObj.ToString());
        }

        public static T Parse<T>(string json) {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
