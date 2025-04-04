using System.Collections.Generic;
using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Gestures;

public class DoublePress:APLGesture
{
    public override string Type => nameof(DoublePress);

    [JsonProperty("onDoublePress", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnDoublePress { get; set; }

    [JsonProperty("onSinglePress", NullValueHandling = NullValueHandling.Ignore),
     JsonConverter(typeof(APLCommandListConverter))]
    public APLValue<IList<APLCommand>> OnSinglePress { get; set; }
}