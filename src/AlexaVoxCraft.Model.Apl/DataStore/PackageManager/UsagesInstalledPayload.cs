using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore.PackageManager;

public class UsagesInstalledPayload
{
    [JsonProperty("packageId")]
    public string PackageId { get; set; }

    [JsonProperty("packageVersion",NullValueHandling = NullValueHandling.Ignore)]
    public string PackageVersion { get; set; }

    [JsonProperty("usages")]
    public Usage[] Usages { get; set; }
}