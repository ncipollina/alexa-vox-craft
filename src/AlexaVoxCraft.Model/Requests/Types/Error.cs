using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Types;

public class Error
{
    [JsonPropertyName("type")]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ErrorType>))]
    public ErrorType Type { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}