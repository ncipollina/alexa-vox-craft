using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class CommandsRequest
{
    [JsonProperty("commands")]
    public List<DataStoreCommand> Commands = new();

    [JsonProperty("target")] public CommandsTarget Target { get; set; } = new();

    [JsonProperty("attemptDeliveryUntil", NullValueHandling = NullValueHandling.Ignore)]
    public string AttemptDeliveryUntil { get; set; }
}