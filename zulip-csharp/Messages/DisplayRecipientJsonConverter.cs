using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZulipAPI.Messages {
    internal class DisplayRecipientJsonConverter : JsonConverter<DisplayRecipient[]> {

        public override bool CanRead => true;
        public override bool CanWrite => true;

        public override DisplayRecipient[] ReadJson(JsonReader reader, Type objectType, DisplayRecipient[] existingValue, bool hasExistingValue, JsonSerializer serializer) {
            var json = (string)reader.Value;
            if (json.Contains("{")) {
                return JsonConvert.DeserializeObject<DisplayRecipient[]>(json);
            } else {
                return new DisplayRecipient[] { /*StreamName = json*/ };
            }
        }

        public override void WriteJson(JsonWriter writer, DisplayRecipient[] value, JsonSerializer serializer) {
            if (value[0].IsStreamRecipient) {
                serializer.Serialize(writer, value[0].StreamName);
            } else {
                var json = JsonConvert.SerializeObject(value);
                serializer.Serialize(writer, json);
            }
        }
    }
}
