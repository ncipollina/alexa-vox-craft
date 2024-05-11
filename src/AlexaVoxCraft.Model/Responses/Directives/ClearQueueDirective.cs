using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class ClearQueueDirective : Directive
{
    [JsonPropertyName("clearBehavior")]
    [JsonRequired]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ClearBehavior>))]
    public ClearBehavior ClearBehavior { get; set; }
}