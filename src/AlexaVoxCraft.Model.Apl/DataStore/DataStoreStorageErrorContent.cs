using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class DataStoreStorageErrorContent : DataStoreErrorContent
{
    [JsonProperty("message",NullValueHandling = NullValueHandling.Ignore)]
    public string Message { get; set; }

    [JsonProperty("failedCommand")]
    public DataStoreCommand FailedCommand { get; set; }
}