using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.VectorGraphics.Filters;

[JsonConverter(typeof(IAVGFilterConverter))]
public interface IAVGFilter
{
    [JsonProperty("type")]
    string Type { get; }
}