using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VisibleComponentScrollableTag
{
    [JsonPropertyName("direction"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<ScrollableTagDirection>))]
    public ScrollableTagDirection Direction { get; set; }

    [JsonPropertyName("allowForward"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowForward { get; set; }

    [JsonPropertyName("allowBackward"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowBackward { get; set; }
}