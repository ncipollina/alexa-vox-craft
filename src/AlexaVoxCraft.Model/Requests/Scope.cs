using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests;

public class Scope
{
    [JsonPropertyName("status")]
    public string Status { get; set; }
}