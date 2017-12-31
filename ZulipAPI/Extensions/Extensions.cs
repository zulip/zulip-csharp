using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ZulipAPI {
    public static class Extensions {

        public static string AsQueryString(this List<KeyValuePair<string, string>> parameters) {
            if (!parameters.Any()) { return ""; }

            var sb = new StringBuilder();
            sb.Append("?");

            foreach (var pair in parameters.Where(kvp => kvp.Value != null)) {
                sb.Append(WebUtility.UrlEncode(pair.Key));
                sb.Append($"={WebUtility.UrlEncode(pair.Value)}");
                sb.Append("&");
            }
            var QueryString = sb.ToString();
            return QueryString.Remove(QueryString.Length - 1);
        }
    }
}
