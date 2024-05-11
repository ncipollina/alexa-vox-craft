using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Types.Apl;

public class InstallationErrorRequest : RequestType
{
    public const string RequestType = "Alexa.DataStore.PackageManager.InstallationError";

    [JsonPropertyName("packageId")]
    public string PackageId { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("error")]
    public InstallationError Error { get; set; }
}