using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class VideoAppDirective : Directive
{
    [JsonPropertyName("videoItem")]
    [JsonRequired]
    public VideoItem VideoItem { get; set; }
}