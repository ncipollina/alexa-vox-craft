using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

[JsonConverter(typeof(DataStoreCommandConverter))]
public class DataStoreCommand
{
    public DataStoreCommand(string type) => Type = type;

    [JsonProperty("type")]
    public string Type { get; }
}