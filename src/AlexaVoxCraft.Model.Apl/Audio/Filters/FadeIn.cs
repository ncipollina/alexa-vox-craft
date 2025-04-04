using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio.Filters;

public class FadeIn : APLAFilter
{
    public override string Type => nameof(FadeIn);

    [JsonProperty("duration")]
    public APLValue<int> Duration { get; set; }
}