using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Responses.Directives;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses;

public abstract class OutputSpeech
{
    [JsonPropertyName("playBehavior")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<PlayBehavior>))]
    public PlayBehavior? PlayBehavior { get; set; }
}