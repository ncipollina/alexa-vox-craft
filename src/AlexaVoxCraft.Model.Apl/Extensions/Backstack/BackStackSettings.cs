using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Extensions.Backstack;

public class BackStackSettings
{
    [JsonProperty("backstackId", NullValueHandling = NullValueHandling.Ignore)]
    public string BackstackId { get; set; }
}