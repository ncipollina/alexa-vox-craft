using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class ResolutionAuthority
{
    [JsonPropertyName("authority")]
    public required string Name { get; set; }

    [JsonPropertyName("status")]
    public required ResolutionStatus Status { get; set; }

    [JsonPropertyName("values"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ResolutionValueContainer[]? Values { get; set; }
}