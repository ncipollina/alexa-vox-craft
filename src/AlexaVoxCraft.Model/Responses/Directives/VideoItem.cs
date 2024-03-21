using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class VideoItem
{
    [JsonPropertyName("source")]
    [JsonRequired]
    public string Source { get; set; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VideoItemMetadata Metadata { get; set; }
}