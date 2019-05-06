using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZulipAPI.BaseClasses {
    public class APIEndPoint {

        private RestClient _client;
        private JsonSerializerSettings jsonSettings;

        internal APIEndPoint(RestClient restClient) {
            _client = restClient;
            jsonSettings = new JsonSerializerSettings {
                ContractResolver = new DefaultContractResolver {
                    NamingStrategy = new SnakeCaseNamingStrategy()
                },
                Formatting = Formatting.Indented,
            };
        }
        protected async Task<T> Get<T>(string route) where T : new() {
            var request = CreateRequest(route, Method.GET);
            IRestResponse<T> response = await _client.ExecuteGetTaskAsync<T>(request);
            EvaluateResponse(response.StatusCode, response.Content);
            return response.Data;
        }

        protected async Task<T> Get<T>(string route, IList<KeyValuePair<string, object>> @params) where T : new() {
            var request = CreateRequest(route, Method.GET);
            request.AddParams(@params);
            IRestResponse<T> response = await _client.ExecuteGetTaskAsync<T>(request);
            EvaluateResponse(response.StatusCode, response.Content);
            if (response.Data == null) {
                var deserialised = JsonConvert.DeserializeObject<T>(response.Content, jsonSettings);
                return deserialised;
            } else {
                return response.Data;
            }
        }

        protected async Task<T> Post<T>(string route, IList<KeyValuePair<string, object>> @params) where T : new() {
            var request = CreateRequest(route, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddParams(@params);
            IRestResponse<T> response = await _client.ExecutePostTaskAsync<T>(request);
            EvaluateResponse(response.StatusCode, response.Content);
            return response.Data;
        }

        public async Task<T> Patch<T>(string route, IList<KeyValuePair<string, object>> @params) {
            var request = CreateRequest(route, Method.PATCH);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("accept-encoding", "gzip, deflate");
            request.AddParams(@params);
            IRestResponse<T> response = await _client.ExecuteTaskAsync<T>(request, CancellationToken.None, Method.PATCH);
            EvaluateResponse(response.StatusCode, response.Content);
            return response.Data;
        }

        public async Task<T> Delete<T>(string route, IList<KeyValuePair<string, object>> @params) {
            var request = CreateRequest(route, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddParams(@params);
            IRestResponse<T> response = await _client.ExecuteTaskAsync<T>(request, CancellationToken.None, Method.DELETE);
            EvaluateResponse(response.StatusCode, response.Content);
            return response.Data;
        }

        private RestRequest CreateRequest(string route, Method method) {
            return new RestRequest(route, method);
        }

        internal HttpStatusCode LastReceivedStatus { get; set; }
        public string LastReceivedApiContent { get; private set; }

        private HttpStatusCode EvaluateResponse(HttpStatusCode code, string content) {
            LastReceivedStatus = code;
            LastReceivedApiContent = content;
            switch (code) {
                case HttpStatusCode.Accepted:
                    break;
                case HttpStatusCode.Ambiguous:
                    break;
                case HttpStatusCode.BadGateway:
                    break;
                case HttpStatusCode.BadRequest:
                    break;
                case HttpStatusCode.Conflict:
                    break;
                case HttpStatusCode.Continue:
                    break;
                case HttpStatusCode.Created:
                    break;
                case HttpStatusCode.ExpectationFailed:
                    break;
                case HttpStatusCode.Forbidden:
                    break;
                case HttpStatusCode.Found:
                    break;
                case HttpStatusCode.GatewayTimeout:
                    break;
                case HttpStatusCode.Gone:
                    break;
                case HttpStatusCode.HttpVersionNotSupported:
                    break;
                case HttpStatusCode.InternalServerError:
                    break;
                case HttpStatusCode.LengthRequired:
                    break;
                case HttpStatusCode.MethodNotAllowed:
                    break;
                case HttpStatusCode.Moved:
                    break;
                //case HttpStatusCode.MultipleChoices:
                //    break;
                case HttpStatusCode.NoContent:
                    break;
                case HttpStatusCode.NonAuthoritativeInformation:
                    break;
                case HttpStatusCode.NotAcceptable:
                    break;
                case HttpStatusCode.NotFound:
                    break;
                case HttpStatusCode.NotImplemented:
                    break;
                case HttpStatusCode.NotModified:
                    break;
                case HttpStatusCode.OK:
                    break;
                case HttpStatusCode.PartialContent:
                    break;
                case HttpStatusCode.PaymentRequired:
                    break;
                case HttpStatusCode.PreconditionFailed:
                    break;
                case HttpStatusCode.ProxyAuthenticationRequired:
                    break;
                //case HttpStatusCode.Redirect:
                //    break;
                case HttpStatusCode.RedirectKeepVerb:
                    break;
                case HttpStatusCode.RedirectMethod:
                    break;
                case HttpStatusCode.RequestedRangeNotSatisfiable:
                    break;
                case HttpStatusCode.RequestEntityTooLarge:
                    break;
                case HttpStatusCode.RequestTimeout:
                    break;
                case HttpStatusCode.RequestUriTooLong:
                    break;
                case HttpStatusCode.ResetContent:
                    break;
                //case HttpStatusCode.SeeOther:
                //    break;
                case HttpStatusCode.ServiceUnavailable:
                    break;
                case HttpStatusCode.SwitchingProtocols:
                    break;
                //case HttpStatusCode.TemporaryRedirect:
                //    break;
                case HttpStatusCode.Unauthorized:
                    OnUnauthorizedOccurred(content);
                    break;
                case HttpStatusCode.UnsupportedMediaType:
                    break;
                case HttpStatusCode.Unused:
                    break;
                case HttpStatusCode.UpgradeRequired:
                    break;
                case HttpStatusCode.UseProxy:
                    break;
                default:
                    break;
            }
            return code;
        }

        public event EventHandler<string> UnauthorizedOccurred;
        protected virtual void OnUnauthorizedOccurred(string content) {
            UnauthorizedOccurred?.Invoke(this, content);
        }
    }
}
