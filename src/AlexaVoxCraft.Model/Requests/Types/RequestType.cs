using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Types;

public abstract class RequestType
{
    [JsonPropertyName("requestId")]
    public string? RequestId { get; set; }

    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    [JsonPropertyName("timestamp"),JsonConverter(typeof(MixedDateTimeConverter))]
    public DateTime Timestamp { get; set; }
}