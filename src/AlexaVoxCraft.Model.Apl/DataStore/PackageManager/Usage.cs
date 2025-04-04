using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore.PackageManager;

public class Usage
{
    [JsonProperty("instanceId",NullValueHandling = NullValueHandling.Ignore)]
    public string InstanceId { get; set; }

    [JsonProperty("location")]
    public string Location { get; set; }
}