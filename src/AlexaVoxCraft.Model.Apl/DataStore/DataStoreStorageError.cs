using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class DataStoreStorageError : DataStoreError
{
    [JsonProperty("content")]
    public DataStoreStorageErrorContent Content { get; set; }
}