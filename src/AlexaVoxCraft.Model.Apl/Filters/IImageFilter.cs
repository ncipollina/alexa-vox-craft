using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Filters;

[JsonConverter(typeof(ImageFilterConverter))]
public interface IImageFilter
{
    [JsonProperty("type")]
    string Type { get; }
}