using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.DataStore;

public class QueuedResultResponse
{
    [JsonProperty("items")]
    public CommandResult[] Items { get; set; }

    [JsonProperty("paginationContext",NullValueHandling = NullValueHandling.Ignore)]
    public PaginationContext PaginationContext { get; set; }
}