using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class UsagesUpdateRequest : RequestType
{
    public const string RequestType = "Alexa.DataStore.PackageManager.UpdateRequest";

    [JsonPropertyName("fromVersion")]
    public string FromVersion { get; set; }

    [JsonPropertyName("toVersion")]
    public string ToVersion { get; set; }

    [JsonPropertyName("packageId")]
    public string PackageId { get; set; }
}