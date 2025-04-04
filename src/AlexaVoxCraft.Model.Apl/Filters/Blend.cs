using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Filters;

public class Blend : IImageFilter
{
    [JsonProperty("type")]
    public string Type => nameof(Blend);

    [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> Destination { get; set; }

    [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> Source { get; set; }

    [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<BlendMode?> Mode { get; set; }
}