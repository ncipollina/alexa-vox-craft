using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class CommandsResponse
{
    [JsonProperty("results")]
    public CommandResult[] Results { get; set; }

    [JsonProperty("queuedResultId")]
    public string QueuedResultId { get; set; }
}