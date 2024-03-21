using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class Hint
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
        
    [JsonPropertyName("text")]
    public string Text { get; set; }
}