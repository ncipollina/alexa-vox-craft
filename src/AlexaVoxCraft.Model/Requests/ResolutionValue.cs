using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class ResolutionValue
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}