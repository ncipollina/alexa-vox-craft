using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore.PackageManager;

public class PackageManagerContext
{
    [JsonProperty("installedPackages", NullValueHandling = NullValueHandling.Ignore)]
    public InstalledPackage[] InstalledPackages { get; set; }
}