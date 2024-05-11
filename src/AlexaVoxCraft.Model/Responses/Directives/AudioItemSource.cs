using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class AudioItemSource
{
    [JsonPropertyName("url"), JsonRequired]
    public string Url { get; set; }
}