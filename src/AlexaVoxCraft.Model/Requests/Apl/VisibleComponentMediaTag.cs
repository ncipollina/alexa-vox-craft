using System.Text.Json.Serialization;
using AlexaVoxCraft.Model.Serialization.Converters;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VisibleComponentMediaTag
{
    [JsonPropertyName("positionInMilliseconds"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? PositionInMilliseconds { get; set; }

    [JsonPropertyName("allowAdjustSeekPositionForward"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowAdjustSeekPositionForward { get; set; }

    [JsonPropertyName("allowAdjustSeekPositionBackwards"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowAdjustSeekPositionBackwards { get; set; }

    [JsonPropertyName("allowNext"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowNext { get; set; }

    [JsonPropertyName("allowPrevious"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowPrevious { get; set; }

    [JsonPropertyName("url"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Url { get; set; }

    [JsonPropertyName("state"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<MediaTagState>))]
    public MediaTagState? State { get; set; }

    [JsonPropertyName("entities"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VisibleComponentEntity[] Entities { get; set; }
}