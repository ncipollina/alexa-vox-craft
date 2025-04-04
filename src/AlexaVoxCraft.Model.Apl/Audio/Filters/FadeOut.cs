using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio.Filters;

public class FadeOut : APLAFilter
{
    public override string Type => nameof(FadeOut);

    [JsonProperty("duration")]
    public APLValue<int> Duration { get; set; }
}