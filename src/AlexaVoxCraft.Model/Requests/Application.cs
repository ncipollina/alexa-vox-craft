using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Application
{
    [JsonPropertyName("applicationId")]
    public string ApplicationId { get; set; }
}