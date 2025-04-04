using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

[JsonConverter(typeof(DataStoreErrorConverter))]
public class DataStoreError
{
    [JsonProperty("type")]
    public string Type { get; set; }
}