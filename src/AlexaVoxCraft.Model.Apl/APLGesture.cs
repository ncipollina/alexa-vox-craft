using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

[JsonConverter(typeof(APLGestureConverter))]
public abstract class APLGesture
{
    [JsonProperty("type")]
    public abstract string Type { get; }
}