using Newtonsoft.Json.Linq;

namespace ZulipNetCore
{
  class JSONHelper {
    public JObject ParseJSON(string JsonResponse) {
      var JSON = JObject.Parse(JsonResponse);
      return JSON;
    }
  }
}
