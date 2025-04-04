using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio.Filters;

public class Repeat : APLAFilter
{
    public override string Type => nameof(Repeat);

    [JsonProperty("repeatCount")]
    public APLValue<int> RepeatCount { get; set; }
}