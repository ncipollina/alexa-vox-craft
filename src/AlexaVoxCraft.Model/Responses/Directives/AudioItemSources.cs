using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AudioItemSources
{
    [JsonPropertyName("sources")]
    public List<AudioItemSource> Sources { get; set; } = new List<AudioItemSource>();
}