using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class ResolutionValueContainer
{
    [JsonPropertyName("value")]
    public ResolutionValue Value { get; set; }
}