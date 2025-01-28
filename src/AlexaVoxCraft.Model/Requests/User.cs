using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class User
{
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    [JsonPropertyName("permissions")]
    public Permissions? Permissions { get; set; }
}