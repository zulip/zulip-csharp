using Newtonsoft.Json.Linq;

namespace ZulipAPI
{
  class JSONHelper {
    public JObject ParseJSON(string JsonResponse) {
      var JSON = JObject.Parse(JsonResponse);
      return JSON;
    }
  }
}
