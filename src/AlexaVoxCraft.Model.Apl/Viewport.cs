using AlexaVoxCraft.Model.Apl.JsonConverter;
using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl;

[JsonConverter(typeof(ViewportConverter))]
public abstract class Viewport
{
    [JsonProperty("type")]
    public abstract string Type { get; }

    [JsonProperty("id")]
    public string ID { get; set; }
}