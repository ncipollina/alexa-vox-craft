using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public sealed class Session
{
    [JsonPropertyName("new")]
    public bool New { get; set; }

    [JsonPropertyName("sessionId")]
    public required string SessionId { get; set; }

    [JsonPropertyName("attributes")] public Dictionary<string, object> Attributes { get; set; } = new();

    [JsonPropertyName("application")]
    public required Application Application { get; set; }

    [JsonPropertyName("user")]
    public required User User { get; set; }

}