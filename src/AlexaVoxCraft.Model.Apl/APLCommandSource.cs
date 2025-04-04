using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLCommandSource
{
    [JsonProperty("type",NullValueHandling = NullValueHandling.Ignore)]
    public string Type { get; set; }

    [JsonProperty("handler",NullValueHandling = NullValueHandling.Ignore)]
    public string Handler { get; set; }

    [JsonProperty("id",NullValueHandling = NullValueHandling.Ignore)]
    public string ComponentId { get; set; }
}