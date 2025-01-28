using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Resolution
{
    [JsonPropertyName("resolutionsPerAuthority")]
    public required ResolutionAuthority[] Authorities { get; set; }
}