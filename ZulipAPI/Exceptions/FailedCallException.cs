using System;
using System.Runtime.Serialization;

namespace ZulipAPI
{
    [Serializable]
    internal class FailedCallException : Exception
    {

        public ResponseBase ZulipServerResponse { get; private set; }
        public new string Message { get; private set; }

        public FailedCallException() {
        }

        public FailedCallException(ResponseBase ZulipServerResponse) {
            this.ZulipServerResponse = ZulipServerResponse;
            this.Message = $"The API call returned with an error.\r\nAPI Returned: {ZulipServerResponse?.Result} = {ZulipServerResponse?.Msg}";
        }

        public FailedCallException(string message) : base(message) {
        }

        public FailedCallException(string message, Exception innerException) : base(message, innerException) {
        }

        protected FailedCallException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
