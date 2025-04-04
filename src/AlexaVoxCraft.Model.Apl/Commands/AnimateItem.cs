using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

public class AnimateItem:APLCommand
{
    [JsonProperty("type")]
    public override string Type => nameof(AnimateItem);

    [JsonProperty("componentId",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> ComponentId { get; set; }

    [JsonProperty("duration")]
    public APLValue<int?> Duration { get; set; }

    [JsonProperty("easing",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<string> Easing { get; set; }

    [JsonProperty("repeatCount",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> RepeatCount { get; set; }

    [JsonProperty("repeatMode",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<RepeatMode> RepeatMode { get; set; }

    [JsonProperty("value"),
     JsonConverter(typeof(AnimatedPropertyListConverter))]
    public APLValue<IList<AnimatedProperty>> Value { get; set; }
}