using System;
using System.Runtime.Serialization;

namespace ZulipAPI
{
    [Serializable]
    internal class FailedCallException : Exception
    {

        public ResponseMessages ZulipServerResponse { get; set; }

        public FailedCallException() {
        }

        public FailedCallException(string message) : base(message) {
        }

        public FailedCallException(string message, Exception innerException) : base(message, innerException) {
        }

        protected FailedCallException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }

    }
}
