using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Application
{
    [JsonPropertyName("applicationId")]
    public required string ApplicationId { get; set; }
}