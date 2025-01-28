using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Types;

public class SessionEndedRequest : RequestType
{
    [JsonPropertyName("reason")]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<Reason>))]
    public Reason Reason { get; set; }

    [JsonPropertyName("error")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Error? Error { get; set; }

}