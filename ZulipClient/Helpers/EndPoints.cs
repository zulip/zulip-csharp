namespace ZulipNetCore
{
    public enum EndPoint {
        FetchApiKey,
        RealmEmoji,
        Events,
        Messages,
        Register,
        Streams,
        UsersMeSubscriptions,
        Typing,
        Users,
        UsersMePointer
    }

    /// <summary>
    /// Returns end point URL parts with beginning or trailing '/'
    /// </summary>
    public struct EndPointPath {
        public const string FetchApiKey = "fetch_api_key";
        public const string RealmEmoji = "realm/emoji";
        public const string Events = "events";
        public const string Messages = "messages";
        public const string Register = "register";
        public const string Streams = "streams";
        public const string UsersMeSubscriptions = "users/me/subscriptions";
        public const string Typing = "typing";
        public const string Users = "users";
        public const string UsersMePointer = "users/me/pointer";
    }
}
