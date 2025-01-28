using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class ResolutionValueContainer
{
    [JsonPropertyName("value")]
    public required ResolutionValue Value { get; set; }
}