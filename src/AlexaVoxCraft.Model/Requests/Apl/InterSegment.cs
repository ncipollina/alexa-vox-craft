using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class InterSegment
{
    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }

    [JsonPropertyName("characters")]
    public string Characters { get; set; }
}