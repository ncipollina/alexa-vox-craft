using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class ResolutionStatus
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
}