using System.Text.Json;
using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Serialization.Converters;

public class MixedDateTimeConverter : JsonConverter<DateTime>
{
    static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.Number => UtcFromEpoch(reader.GetInt64()),
            _ => reader.GetDateTime()
        };
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }

    private DateTime UtcFromEpoch(long epochTime)
    {
        return UnixEpoch.AddMilliseconds(epochTime);
    }
}