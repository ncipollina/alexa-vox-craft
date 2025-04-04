using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Gestures;

public class Tap : APLGesture
{
    public override string Type => nameof(Tap);

    [JsonProperty("onTap", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnTap { get; set; }
}