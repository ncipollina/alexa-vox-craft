using Newtonsoft.Json;

namespace AlexaVoxCraft.Model.Apl.Audio.Filters;

public class Trim:APLAFilter
{
    public override string Type => nameof(Trim);

    [JsonProperty("start",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> Start { get; set; }

    [JsonProperty("end",NullValueHandling = NullValueHandling.Ignore)]
    public APLValue<int?> End { get; set; }
}