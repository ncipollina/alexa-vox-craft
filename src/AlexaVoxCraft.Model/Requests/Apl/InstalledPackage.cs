using System.Text.Json.Serialization;

namespace AlexaVoxCraft.Model.Requests.Apl;

public class InstalledPackage
{
    [JsonPropertyName("packageId")]
    public string PackageId { get; set; }

    [JsonPropertyName("packageVersion")]
    public string PackageVersion { get; set; }
}