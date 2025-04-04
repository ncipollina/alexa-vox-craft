using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio.Filters;

public class Volume : APLAFilter
{
    public override string Type => nameof(Volume);

    [JsonProperty("amount")]
    public APLValue<double> Duration { get; set; }
}