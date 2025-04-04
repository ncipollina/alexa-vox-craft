using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore.PackageManager;

public class InstalledPackage
{
    [JsonProperty("packageId")]
    public string PackageId { get; set; }

    [JsonProperty("packageVersion")]
    public string PackageVersion { get; set; }
}