using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AudioItemMetadata
{
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("subtitle")]
    public string Subtitle { get; set; }

    [JsonPropertyName("art")]
    public AudioItemSources Art { get; set; } = new AudioItemSources();

    [JsonPropertyName("backgroundImage")]
    public AudioItemSources BackgroundImage { get; set; } = new AudioItemSources();
}