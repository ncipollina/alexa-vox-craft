using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AudioItem
{
    [JsonRequired]
    [JsonPropertyName("stream")]
    public AudioItemStream Stream { get; set; }

    [JsonPropertyName("metadata")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AudioItemMetadata Metadata { get; set; }
}