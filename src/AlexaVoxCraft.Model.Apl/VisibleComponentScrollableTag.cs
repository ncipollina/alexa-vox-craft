using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AlexaVoxCraft.Model.Apl;

public class VisibleComponentScrollableTag
{
    [JsonProperty("direction",NullValueHandling = NullValueHandling.Ignore)]
    [JsonConverter(typeof(StringEnumConverter))]
    public ScrollableTagDirection Direction { get; set; }

    [JsonProperty("allow_forward",NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowForward { get; set; }

    [JsonProperty("allow_backward",NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowBackward { get; set; }
}