using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLInterfaceDetails
{
    [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
    public APLInterfaceRuntime Runtime { get; set; }
}