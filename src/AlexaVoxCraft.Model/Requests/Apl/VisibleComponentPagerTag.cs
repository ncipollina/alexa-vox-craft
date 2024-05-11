using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class VisibleComponentPagerTag
{
    [JsonPropertyName("index"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Index { get; set; }

    [JsonPropertyName("pageCount"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? PageCount { get; set; }

    [JsonPropertyName("allowForward"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowForward { get; set; }

    [JsonPropertyName("allowBackwards"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AllowBackwards { get; set; }
}