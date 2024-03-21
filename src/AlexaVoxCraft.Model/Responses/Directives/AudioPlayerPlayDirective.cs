using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AudioPlayerPlayDirective : Directive
{
    [JsonPropertyName("playBehavior")]
    [JsonRequired]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<PlayBehavior>))]
    public PlayBehavior PlayBehavior { get; set; }

    [JsonPropertyName("audioItem")]
    [JsonRequired]
    public AudioItem AudioItem { get; set; }
}