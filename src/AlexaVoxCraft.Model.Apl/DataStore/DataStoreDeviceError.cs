using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class DataStoreDeviceError : DataStoreError
{
    [JsonProperty("content")]
    public DataStoreDeviceErrorContent Content { get; set; }
}