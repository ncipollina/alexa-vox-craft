using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Responses;

public class AskForPermissionsConsentCard : Card
{
    [JsonPropertyName("permissions")]
    [JsonRequired]
    public List<string> Permissions { get; set; } = new List<string>();
}