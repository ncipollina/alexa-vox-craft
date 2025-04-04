using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Commands;

[JsonConverter(typeof(AnimatedPropertyConverter))]
public abstract class AnimatedProperty
{
    [JsonProperty("property")]
    public abstract APLValue<string> Property { get; }
}