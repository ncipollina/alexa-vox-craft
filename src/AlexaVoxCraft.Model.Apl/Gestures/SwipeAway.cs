using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Gestures;

public class SwipeAway : APLGesture
{
    public override string Type => nameof(SwipeAway);

    [JsonProperty("onSwipeMove", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnSwipeMove { get; set; }

    [JsonProperty("onSwipeDone", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnSwipeDone { get; set; }

    [JsonProperty("item",NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLComponentListConverter))]
    public APLValue<IList<APLComponent>> Item { get; set; }

    [JsonProperty("action",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<SwipeAction?> Action { get; set; }

    [JsonProperty("direction")]
    public APLValue<SwipeDirection> Direction { get; set; }
}