using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

public class VisibleComponentListItemTag
{
    [JsonProperty("index",NullValueHandling = NullValueHandling.Ignore)]
    public int? Index { get; set; }
}