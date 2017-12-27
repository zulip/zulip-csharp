using System;

namespace ZulipNetCore {
    internal class InvalidZulipRCFileException : Exception {

        public InvalidZulipRCFileException() : base() {
        }

        public InvalidZulipRCFileException(string message) : base(message) {
        }

        public InvalidZulipRCFileException(string message, Exception innerException) : base(message, innerException) {
        }

        protected InvalidZulipRCFileException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) {
        }
    }
}
