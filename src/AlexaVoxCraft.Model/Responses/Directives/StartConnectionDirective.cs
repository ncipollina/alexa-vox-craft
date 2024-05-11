using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class StartConnectionDirective : Directive
{
    [JsonPropertyName("uri")]
    public string Uri { get; set; }

    [JsonPropertyName("input")]
    public Payload Input { get; set; }

    [JsonPropertyName("token")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Token { get; set; }

    [JsonPropertyName("onComplete")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<OnCompleteAction>))]
    public OnCompleteAction? OnComplete { get; set; }
}