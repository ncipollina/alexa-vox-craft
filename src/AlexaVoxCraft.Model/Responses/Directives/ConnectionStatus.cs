using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses.Directives;

public class ConnectionStatus
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}