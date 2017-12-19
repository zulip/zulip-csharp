using Newtonsoft.Json.Linq;

namespace ZulipNetCore {

    public class JSONHelper {

        public JObject ParseJSON(string JsonResponse) {
            return JObject.Parse(JsonResponse);
        }
    }
}
