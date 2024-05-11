using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class APLTViewport : ViewPort
{
    [JsonPropertyName("supportedProfiles")]
    public APLTProfile[] SupportedProfiles { get; set; }

    [JsonPropertyName("lineLength")]
    public int LineLength { get; set; }

    [JsonPropertyName("lineCount")]
    public int LineCount { get; set; }

    [JsonPropertyName("format")]
    public APLTFormat Format { get; set; }

    [JsonPropertyName("interSegments")]
    public InterSegment[] InterSegments { get; set; }
}