using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class APLViewportConfigurationContainer
{
    [JsonProperty("current",NullValueHandling = NullValueHandling.Ignore)]
    public APLViewportConfiguration Current { get; set; }
}