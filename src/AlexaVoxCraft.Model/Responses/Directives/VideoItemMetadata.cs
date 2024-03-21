using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class VideoItemMetadata
{
    [JsonPropertyName("title")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Title { get; set; }

    [JsonPropertyName("subtitle")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Subtitle { get; set; }
}