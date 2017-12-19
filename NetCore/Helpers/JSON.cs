using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ZulipNetCore {

    public class JSONHelper {

        public JObject ParseJSON(string JsonResponse) {
            return JObject.Parse(JsonResponse);
        }

        public List<T> ParseJArray<T>(object JSONArray) {
            JArray JArr = (JArray)JSONArray;

            return JsonConvert.DeserializeObject<List<T>>(JArr.ToString());
        }


    }
}
