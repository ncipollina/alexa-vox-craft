using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class APLError
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonExtensionData]
    public Dictionary<string,object> ExtraData { get; set; }
}