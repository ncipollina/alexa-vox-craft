using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class DataStoreErrorContent
{
    [JsonProperty("deviceId")]
    public string DeviceId { get; set; }
}