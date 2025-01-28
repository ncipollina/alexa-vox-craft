using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class ResolutionValue
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }
}