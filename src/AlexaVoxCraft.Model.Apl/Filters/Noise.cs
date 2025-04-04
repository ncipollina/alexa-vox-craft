using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Filters;

public class Noise : IImageFilter
{
    [JsonProperty("type")]
    public string Type => nameof(Noise);

    [JsonProperty("useColor", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<bool?> UseColor { get; set; }

    [JsonProperty("sigma", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> Sigma { get; set; }

    [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<NoiseKind?> Kind { get; set; }
}